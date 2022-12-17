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
        private string data;
        public Videotape ()
        {
            name = "NULL";
            data = "NULL" ;
        }

        public Videotape (Videotape video)
        {
            name = video.Name;
            this.data  = video.Data;
        }

        




        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
       
        public string Data { get => data; }

        public void createNewVideo (string filePath)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            if (!chekRepeat(Path.GetFileName(filePath)))
            {
                 data = Convert.ToBase64String(File.ReadAllBytes(filePath));
                MySqlCommand addVideo = new MySqlCommand("INSERT INTO `video` ( `name`, `data`) " +
                        "VALUES (@n, @d)", dataBase.getConnection());
                    addVideo.Parameters.Add("@n", MySqlDbType.VarChar).Value = Path.GetFileName(filePath);
                    addVideo.Parameters.Add("@d", MySqlDbType.LongBlob).Value = data;
                    addVideo.ExecuteNonQuery();
                    dataBase.closeConnection();

                    name = Path.GetFileName(filePath);

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

        public void saveOnPC ()
        {

            File.WriteAllBytes("E:\\Программирование\\Третий курс\\WindowsFormsApp1\\WindowsFormsApp1\\Server\\video\\" + this.name, 
                Convert.FromBase64String(this.data));


        }
       
        public void downloadVideo (int id)
        {
            DataBase db = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT * FROM `video`" +
                "WHERE `id` = @id", db.getConnection());
            usersListCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            this.id = id;
            this.name = dataTable.Rows[0]["name"].ToString();
            this.data = dataTable.Rows[0]["data"].ToString();

        }

        public Videotape select (string name)
        {
            DataBase db = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT * FROM `video`" +
                "WHERE `name` = @n", db.getConnection());
            usersListCommand.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            if (dataTable.Rows.Count > 0)
            {
                this.id = int.Parse( dataTable.Rows[0]["id"].ToString()); 
                this.name = name;
             //   this.data = dataTable.Rows[0]["data"].ToString();
            }
            return this;
        }

        public static string get_name(int id)
        {
            DataBase db = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand getNameCommand = new MySqlCommand(" SELECT * FROM `video`" +
                "WHERE `id` = @id", db.getConnection());
            getNameCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = getNameCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

           
            return dataTable.Rows[0]["name"].ToString();
        }

    }
}
