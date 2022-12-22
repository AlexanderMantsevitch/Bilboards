using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.WindowsForms
{
    public partial class TranslationsForm : Form
    {
       private List<string> rotation = new List<string>();
       private Schedule schedule = new Schedule();
        private Dictionary<string, Semaphore> semaphors = new Dictionary<string, Semaphore>();
        private Dictionary<string, int> counter = new Dictionary<string, int>();
        private Semaphore semaphore = new Semaphore(1,1);
        string directory = "";
        public TranslationsForm(int id_device)
        {
            try {

                InitializeComponent();
                
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.enableErrorDialogs = false;
               
                Device device = new Device();
                DeviceList deviceList = new DeviceList();
                device = deviceList.selectDevice(id_device);
                directory = @"E:\Программирование\Третий курс\WindowsFormsApp1\WindowsFormsApp1\Server\video\" + device.Name + @"\";
                schedule = schedule.GetSchedule(device.Schedule.Id);
           //     Console.WriteLine(schedule.Name);
                rotation = Rotation.createRotation(id_device);



                try
                {
                    foreach (DataRow dataRow in schedule.DataTable.Rows)

                    {

                        semaphors.Add(dataRow["Ролик"].ToString(), new Semaphore(1, 1));
                        counter.Add(dataRow["Ролик"].ToString(), 0);


                    }
                    semaphors.Add("", new Semaphore(1, 1));
                }
                catch { }
                Thread downloadVideo = new Thread(() =>
                    {

                        try
                        {
                            Directory.Delete(directory, true);
                        }
                        catch 
                        {

                        }
                       
                        Directory.CreateDirectory(directory);
                        


                        foreach (DataRow dataRow in schedule.DataTable.Rows)
                        {
                            semaphors[dataRow["Ролик"].ToString()].WaitOne();
                            Videotape videoTape = new Videotape();
                            videoTape.downloadVideo(dataRow["Ролик"].ToString(), device);
                            semaphors[dataRow["Ролик"].ToString()].Release();
                        }

                        Thread.CurrentThread.Abort();
                    }

                );
                downloadVideo.Start();
                


                Thread checkNewSchedule = new Thread(() =>

                {
                    Action action = () =>
                    {
                        while (true)
                        {
                            try
                            {
                                Thread.Sleep(15000);
                                device = deviceList.selectDevice(48);
                                Schedule newschedule = new Schedule();
                                newschedule = schedule.GetSchedule(device.Schedule.Id);
                                //  Console.WriteLine(newschedule.Id + " " + schedule.Id);
                                if (newschedule.Id != schedule.Id)
                                {
                                    rotation = Rotation.createRotation(48);
                                    schedule = newschedule;
                                    try
                                    {
                                        downloadVideo.Start();
                                    }
                                    catch (ThreadAbortException)
                                    {

                                    }

                                }

                                if (axWindowsMediaPlayer1.status.Equals("Остановлен")) ;
                            }
                            catch
                            {

                                Thread.CurrentThread.Abort();

                            }
                        }
                    };
                    action();
                });
                checkNewSchedule.Start();


                Thread.Sleep(1500);
                Thread videoChangeThread = new Thread(() =>
                {
                    Videotape videotape = new Videotape();
                    
                    
                    Action action = () =>
                    {
                        int id = 0;
                        bool flag = true;
                     //   Console.WriteLine(rotation.Count);
                        string previous_name = "";
                        

                        while (flag)
                        {
                            if (File.Exists(directory + rotation.ElementAt(id)))
                            {

                               
                                previous_name = rotation.ElementAt(id);
                                
                                semaphors[rotation.ElementAt(id)].WaitOne();
                                
                                axWindowsMediaPlayer1.URL = directory + rotation.ElementAt(id);
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                                device.upDateStatus(rotation.ElementAt(id));
                                Videotape.upDateStats(rotation.ElementAt(id), 1);  


                                semaphore.WaitOne();
                                counter[rotation.ElementAt(id)]++;
                                semaphore.Release();

                                rotation.Add(rotation.ElementAt(id));
                                previous_name = rotation.ElementAt(id);                                
                                rotation.RemoveAt(id);
                                flag = false;
                                
                                
                            }
                            else
                            {
                                rotation.Add(rotation.ElementAt(id));
                                rotation.RemoveAt(id);
                            }
                        }
                        
                        while (true)
                        {
                            try
                            {
                                Thread.Sleep(100);

                                if (axWindowsMediaPlayer1.status.Equals("Остановлено"))
                                {
                                  //  Console.WriteLine("Остановлено");
                                    semaphors[previous_name].Release();
                                 
                                    semaphors[rotation.ElementAt(id)].WaitOne();

                                    axWindowsMediaPlayer1.URL = directory + rotation.ElementAt(id);

                                    device.upDateStatus(rotation.ElementAt(id));
                                    Videotape.upDateStats(rotation.ElementAt(id), 1);
                                    axWindowsMediaPlayer1.Ctlcontrols.play();
                                    semaphore.WaitOne();
                                    counter[rotation.ElementAt(id)]++;
                                    semaphore.Release();
                                    rotation.Add(rotation.ElementAt(id));
                                    previous_name = rotation.ElementAt(id);
                                    rotation.RemoveAt(id);

                                    
                                }
                            }
                          catch
                            {
                                
                                Thread.CurrentThread.Abort();

                            }
                        }

                    };

                    
                   action();
               
                action();

                }
                );

                videoChangeThread.Start();
                


               
                this.Hide();

            }
            catch (MySqlException)
            {
                

            }
        }

        private void TranslationsForm_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TranslationsForm_Shown(object sender, EventArgs e)
        {
          
        }
    }
}
