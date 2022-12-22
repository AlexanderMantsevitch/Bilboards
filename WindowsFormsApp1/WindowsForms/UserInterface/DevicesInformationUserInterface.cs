using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1.WindowsForms.UserInterface
{
    public partial class DevicesInformationUserInterface : Form
    {
        private UdpClient client;
        private UsersList usersList = new UsersList();
        private Device device;
        private User user;
        private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        
        public DevicesInformationUserInterface(Device device, User user)
        {
            InitializeComponent();
            try

            {

                this.device = device;
                this.user = user;
                idLabel.Text = "Id: " + device.Id;
                deviceNameLabel.Text = "Устройство: " + device.Name;
                ownerLabel.Text = "Владелец: " + (usersList.selectDataUser(device.Owner_id).Login);
                typeLabel.Text = "Тип: " + device.Type;
                statusLabel.Text = "Статус: " + device.Status;
                scheduleLinkLabel.Text = device.Schedule.Name;
                if (device.Status.Equals("on"))
                {
                    SendMessageFromSocket(48655);
                    udpConnection(int.Parse(ConfigurationManager.AppSettings.Get("port")));
                }
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void SendMessageFromSocket(int port)
        {
            //буфер для входящих данных
            byte[] bytes = new byte[1024];
            //соединяемся с удаленным устройством
            //устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream,
            ProtocolType.Tcp);
            //соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);
            Console.Write("Введите сообщение: ");
            string message = "127.0.0.1:" + ConfigurationManager.AppSettings.Get("port");
            Console.WriteLine("Сокет соединяется с {0} ",
            sender.RemoteEndPoint.ToString());
            byte[] msg = Encoding.UTF8.GetBytes(message);
            //отправляем данные через сокет
            int bytesSend = sender.Send(msg);
           
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        

   
        }
        private async void udpConnection(int port)
        {

                client = new UdpClient(port);
                while (true)
                {
          
                try
                {
                    var data = await client.ReceiveAsync();
                    using (var ms = new MemoryStream(data.Buffer))
                    {
                        //translationPictureBox.Image = new Bitmap(ms);
                      
                        this.Update();

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception");
                    break;

                }
                }
            
            
        }

        private void DevicesInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

               
            }
            catch (System.NullReferenceException)
            {


            }
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void scheduleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Лист Excel (*.xlsx)|*.xlsx";
                saveFileDialog.DefaultExt = "xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                ConvertExcel.DataTableInExcel(device.Schedule.DataTable, fileName);

                }
            
        }

        private void addSchedule_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Лист Excel (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    Schedule schedule = new Schedule();
                    schedule.downloadSchedule(fileName);
                    schedule.AssignSchedule(device);
                    scheduleLinkLabel.Text = device.Schedule.Name;
                    logDAO.addNotation(user, "Устройству " + device.Name + " назначено расписание" + device.Schedule.Name );

                }
                catch (AddException)
                {

                    MessageBox.Show("Неверный формат файла");

                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Закройте выбранный файл");

                }




            }

        }

        
    }

   

}
