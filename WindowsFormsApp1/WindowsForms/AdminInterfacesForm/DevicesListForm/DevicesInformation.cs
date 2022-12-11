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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    public partial class DevicesInformation : Form
    {
        private UdpClient client;
        UsersList usersList = new UsersList();
        public DevicesInformation(Device device)
        {
            InitializeComponent();
            try

            {
                idLabel.Text = "Id: " + device.Id;
                deviceNameLabel.Text = "Устройство: " + device.Name;
                ownerLabel.Text = "Владелец: " + (usersList.selectDataUser(device.Owner_id).Login);
                typeLabel.Text = "Тип: " + device.Type;
                statusLabel.Text = "Статус: " + device.Status;
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
                        translationPictureBox.Image = new Bitmap(ms);
                      
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
    }

   

}
