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
        public TranslationsForm()
        {
            InitializeComponent();
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.enableErrorDialogs = false;
                Device device = new Device();
                DeviceList deviceList = new DeviceList();
                device = deviceList.selectDevice(48);
                schedule = schedule.GetSchedule(device.Schedule.Id);
                Console.WriteLine(schedule.Name);
                rotation = Rotation.createRotation(48);

            Thread downloadVideo = new Thread(() =>
            {
                foreach (DataRow dataRow in schedule.DataTable.Rows)
                {
                    Videotape videoTape = new Videotape();
                    videoTape.downloadVideo(dataRow["Ролик"].ToString());
                }

                Thread.CurrentThread.Abort();
            }
            
            );
            downloadVideo.Start();


            Console.WriteLine(axWindowsMediaPlayer1.status);
            
            Thread videoChangeThread = new Thread(() =>
            {
                Videotape videotape = new Videotape();
                Action action = () =>
                {
                    int id = 0;
                    bool flag = true;
                    Console.WriteLine(rotation.Count);
                    while (flag)
                    {
                        if (File.Exists(@"E:\Программирование\Третий курс\WindowsFormsApp1\WindowsFormsApp1\Server\video\" + rotation.ElementAt(id)))
                        {
                            axWindowsMediaPlayer1.URL = @"E:\Программирование\Третий курс\WindowsFormsApp1\WindowsFormsApp1\Server\video\" + rotation.ElementAt(id);
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            rotation.Add(rotation.ElementAt(id));
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
                            // Console.WriteLine(File.Exists(@"E:\\Программирование\\Третий курс\\WindowsFormsApp1\\WindowsFormsApp1\\Server\\video\\" + videotape.Name));
                           
                            Thread.Sleep(1000);
                            
                            if (axWindowsMediaPlayer1.status.Equals("Остановлено"))
                            {
                                
                                axWindowsMediaPlayer1.URL = @"E:\Программирование\Третий курс\WindowsFormsApp1\WindowsFormsApp1\Server\video\" + rotation.ElementAt(id);
                                rotation.Add(rotation.ElementAt(id));
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                                rotation.RemoveAt(id);
                                

                            }
                        }
                        catch
                        {
                            Thread.CurrentThread.Abort();

                        }
                    }
                   
                };
               
                
                // if (InvokeRequired) Invoke(action);
                // else action();
                action();

            }
         );
            
            videoChangeThread.Start();





        }

     
    }
}
