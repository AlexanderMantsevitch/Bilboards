using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WindowsFormsApp1.Classes
{
    public class VideoClass
    {
        private int id;
        private string name;
        private StringBuilder data = new StringBuilder("");
        public VideoClass ()
        {
            name = "NULL";
            data.Append ("NULL");
        }

        public VideoClass (VideoClass video)
        {
            name = video.Name;
            this.data.Append(video.Data);
        }

        


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public StringBuilder Data { get => data; }

        public void createNewVideo (string filePath)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            
            MySqlCommand addVideo = new MySqlCommand("INSERT INTO `video` ( `name`) " +
                "VALUES (@n)", dataBase.getConnection());
            addVideo.Parameters.Add("@n", MySqlDbType.VarChar).Value = Path.GetFileName(filePath);
            addVideo.ExecuteNonQuery();
            dataBase.closeConnection();

            

        }


       
    }
}
