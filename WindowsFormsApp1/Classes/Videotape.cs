using DocumentFormat.OpenXml.Presentation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1.Classes
{
    public class Videotape
    {
        private int id;
        private string name;
        private StringBuilder data = new StringBuilder("");
        public Videotape ()
        {
            name = "NULL";
            data.Append ("NULL");
        }

        public Videotape (Videotape video)
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
            if (!chekRepeat(Path.GetFileName(filePath)))
            {
                
                    MySqlCommand addVideo = new MySqlCommand("INSERT INTO `video` ( `name`) " +
                        "VALUES (@n)", dataBase.getConnection());
                    addVideo.Parameters.Add("@n", MySqlDbType.VarChar).Value = Path.GetFileName(filePath);
                    addVideo.ExecuteNonQuery();
                    dataBase.closeConnection();


                    FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    FileStream fileNew = new FileStream("E:\\Программирование\\Третий курс\\WindowsFormsApp1\\WindowsFormsApp1\\Server\\video\\" + Path.GetFileName(filePath), FileMode.Create, FileAccess.Write);
                    fileStream.CopyTo(fileNew);

                    fileNew?.Close();
                    fileStream?.Close();
                
              
               
            }
            else throw new AddException();

        }

        private bool chekRepeat (string name)
        {
           
            DataBase db = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            DataTable data = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT * FROM `video`" +
                "WHERE `name` = @v", db.getConnection());
            usersListCommand.Parameters.Add("@v", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(data);
            db.closeConnection();

            if (data.Rows.Count > 0) return true;
            else return false;
        }

        public static void deleteVideo (string name)
        {
            DataBase db = new DataBase();
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `video` WHERE `name` = @n;", db.getConnection());
            deleteUser.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

            
        }

       
    }
}
