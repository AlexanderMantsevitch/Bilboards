using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1.Classes
{
    public class Schedule
    {
        private int id;
        private DataTable dataTable;
        private string name;
       
       public Schedule ()
        {
            id = 0;
            dataTable = null;
            name = "Расписания нет";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; }
        public DataTable DataTable { get => dataTable; }

        public void downloadSchedule (string filePath)
        {
            DataBase dataBase = new DataBase();
            dataTable = ConvertExcel.ExcelInDataTable(filePath);
            if (!checkFormat()) throw new AddException();

            dataBase.openConnection();

            MySqlCommand addVideo = new MySqlCommand("INSERT INTO `schedule` (`name`) " +
                "VALUES (@n)", dataBase.getConnection());

            string[] fileNameArray = Path.GetFileName(filePath).Split('.');
            string fileName = fileNameArray[0];
        
            addVideo.Parameters.Add("@n", MySqlDbType.VarChar).Value = fileName;
            addVideo.ExecuteNonQuery();
            dataBase.closeConnection();

            this.id = GetId(fileName);
            this.name = fileName;


        }

        private bool checkFormat ()
        {
            Console.WriteLine(this.dataTable.Columns[0].ColumnName + (this.dataTable.Columns[0].ColumnName));
            if (this.dataTable.Columns[0].ColumnName.Equals("Ролик"))
            {
                if (this.dataTable.Columns[1].ColumnName.Equals("Частота")) return true;
                else return false;


            } 
            else return false;
        }

        public Schedule GetSchedule (int id)
        {
            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dataBase.openConnection();

            MySqlCommand getNameandID = new MySqlCommand("SELECT * FROM `schedule` WHERE `id` = @id", dataBase.getConnection());
            getNameandID.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = getNameandID;
            adapter.Fill(dt);

            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `intermediatetable` WHERE `id_schedule` = @id", dataBase.getConnection());
            selectDataCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dt2);
            dataBase.closeConnection();

            int id_device = int.Parse ( dt2.Rows[0]["id_device"].ToString());
            dt2.Columns.Add("Ролик");
            dt2.Columns.Add("Частота");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (int.Parse(dt2.Rows[i]["id_device"].ToString()) != id_device)
                {
                    dt2.Rows[i].Delete();
                }
               
                dt2.Rows[i]["Ролик"] = Videotape.get_name(int.Parse(dt2.Rows[i]["id_video"].ToString()));
                dt2.Rows[i]["Частота"] = int.Parse(dt2.Rows[i]["freqyency"].ToString());
            }

            dt2.Columns.Remove("id_schedule");
            dt2.Columns.Remove("id_device");
            dt2.Columns.Remove("id_video");
            dt2.Columns.Remove("freqyency");

            this.name = dt.Rows[0]["name"].ToString();
            this.id = Convert.ToInt32 (dt.Rows[0]["id"]);
            this.dataTable = dt2;
            
            
           
            return this;
        }

        private int GetId (string name)
        {
            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            dataBase.openConnection();

            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT `id` FROM `schedule` WHERE `name` = @n", dataBase.getConnection());
            selectDataCommand.Parameters.Add("@n", MySqlDbType.VarChar).Value =name;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dt);
            dataBase.closeConnection();
            return Convert.ToInt32(dt.Rows[0]["id"]);

        }

        public void AssignSchedule (Device device)
        {

            device.updateCell("schedule_id", this.id, device.Id);
            device.Schedule = this;
            DataBase dataBase = new DataBase();
            dataBase.openConnection();

            MySqlCommand deleteOldSchedule = new MySqlCommand("DELETE FROM `intermediatetable` WHERE `id_device` = @id;", dataBase.getConnection());
            deleteOldSchedule.Parameters.Add("@id", MySqlDbType.Int32).Value = device.Id;
            deleteOldSchedule.ExecuteNonQuery();
            foreach (DataRow dataRow in dataTable.Rows)
            {

               
               
                if (!checkFormat()) throw new AddException();

               


                MySqlCommand assignSchedule = new MySqlCommand("INSERT INTO `intermediatetable` (`id_device`, `id_schedule`, `id_video`, `freqyency`) " +
                    "VALUES (@d, @s, @v, @f)", dataBase.getConnection());
                                Videotape video = new Videotape();
                assignSchedule.Parameters.Add("@v", MySqlDbType.Int32).Value = video.select (dataRow ["Ролик"].ToString()).Id;
                assignSchedule.Parameters.Add("@s", MySqlDbType.Int32).Value = this.id;
                assignSchedule.Parameters.Add("@d", MySqlDbType.Int32).Value = device.Id;
                assignSchedule.Parameters.Add("@f", MySqlDbType.Int32).Value = int.Parse (dataRow["Частота"].ToString());
                assignSchedule.ExecuteNonQuery();
              



            }

            dataBase.closeConnection();
        }

    }
}
