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
        private int id_user;
        public Videotape ()
        {
            name = "NULL";
            data = "NULL" ;
            id_user = 0;
        }

        public Videotape (Videotape video)
        {
            name = video.Name;
            this.data  = video.Data;
        }

        




        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
       
        public string Data { get => data; }
        public int Id_user { get => id_user; set => id_user = value; }

        public void createNewVideo (string filePath, int id_user)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            if (!chekRepeat(Path.GetFileName(filePath)))
            {
                 data = Convert.ToBase64String(File.ReadAllBytes(filePath));
                MySqlCommand addVideo = new MySqlCommand("INSERT INTO `video` ( `name`,`data`,`id_user`) " +
                        "VALUES (@n, @d,@id)", dataBase.getConnection());
                    addVideo.Parameters.Add("@n", MySqlDbType.VarChar).Value = Path.GetFileName(filePath);
                    addVideo.Parameters.Add("@d", MySqlDbType.LongBlob).Value = data;
                    addVideo.Parameters.Add("@id", MySqlDbType.Int32).Value = id_user;
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

        public static void deleteVideo(int id)
        {
            DataBase db = new DataBase();
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `video` WHERE `id` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();


        }

        public void saveOnPC (string nameDevice)
        {

               File.WriteAllBytes("E:\\Программирование\\Третий курс\\WindowsFormsApp1\\WindowsFormsApp1\\Server\\video\\"+nameDevice + "\\" + this.name, 
               Convert.FromBase64String(this.data));


        }
       
        public void downloadVideo (int id, Device device)
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
            saveOnPC(device.Name);

        }

        public void downloadVideo(string name, Device device)
        {
            DataBase db = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT * FROM `video`" +
                "WHERE `name` = @name", db.getConnection());
            usersListCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            
            this.name = dataTable.Rows[0]["name"].ToString();
            this.data = dataTable.Rows[0]["data"].ToString();
            this.id_user = int.Parse(dataTable.Rows[0]["id_user"].ToString());
            saveOnPC(device.Name);
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

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0]["name"].ToString();
            else return null;
        }



        public static void deleteUnAviable ()
        {
            DataBase db = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectActiveVideo = new MySqlCommand(" SELECT * FROM `intermediatetable`", db.getConnection());

            adapter.SelectCommand = selectActiveVideo;
            adapter.Fill(dataTable);

            DataTable dt = new DataTable();
            MySqlCommand selectVideo = new MySqlCommand(" SELECT * FROM `video`" , db.getConnection());

            adapter.SelectCommand = selectVideo;
            adapter.Fill(dt);

            db.closeConnection();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                
                bool flag = true;
               foreach (DataRow dr in dt.Rows)
                {

                    if (dataRow["id_video"].Equals(dr["id"])) flag = false;

                }

                if (flag) deleteRows(int.Parse(dataRow["id_video"].ToString()));

            }

        }


        public static void deleteRows(int id)
        {
            DataBase db = new DataBase();
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `video` WHERE `ID` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }

        public static void upDateStats(string name, int count)
        {

            DataBase db = new DataBase();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            MySqlCommand checkDate = new MySqlCommand("SELECT * FROM `statistic` WHERE `date` = @d AND `name_video` = @n", db.getConnection());
            checkDate.Parameters.Add("@d", MySqlDbType.Date).Value = DateTime.Now.Date;
            checkDate.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = checkDate;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)

            {
                dt = new DataTable();
                MySqlCommand getPreviousValues = new MySqlCommand("SELECT `repeat` FROM `statistic` WHERE `name_video` = @n", db.getConnection());
                getPreviousValues.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;

                adapter.SelectCommand = getPreviousValues;
                adapter.Fill(dt);

                MySqlCommand upDateStatus = new MySqlCommand("UPDATE `statistic` SET `repeat` = @v " +
                    " WHERE `statistic`.`name_video` = @n AND `date` = @d", db.getConnection());
                upDateStatus.Parameters.Add("@v", MySqlDbType.Int32).Value = int.Parse(dt.Rows[0]["repeat"].ToString()) + count;
                upDateStatus.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
                upDateStatus.Parameters.Add("@d", MySqlDbType.Date).Value = DateTime.Now.Date;
                upDateStatus.ExecuteNonQuery();
            }

            else
            {

                MySqlCommand addRow = new MySqlCommand("INSERT INTO `statistic` (`date`, `name_video`, `repeat`) " + "VALUES (@d, @n,@r)", db.getConnection());
        
                addRow.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
                addRow.Parameters.Add("@r", MySqlDbType.Int32).Value = count;
                addRow.Parameters.Add("@d", MySqlDbType.Date).Value = DateTime.Now.Date;
                addRow.ExecuteNonQuery();

            }
            db.closeConnection();


        }
    }
}
