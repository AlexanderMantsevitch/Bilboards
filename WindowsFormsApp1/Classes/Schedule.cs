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

        public void downloadSchedule (string filePath)
        {
            DataBase dataBase = new DataBase();
            dataTable = ConvertExcel.ExcelInDataTable(filePath);
            if (!checkFormat()) throw new AddException();

            dataBase.openConnection();

            MySqlCommand addVideo = new MySqlCommand("INSERT INTO `schedule ( `name`) " +
                "VALUES (@n)", dataBase.getConnection());

            string[] fileNameArray = Path.GetFileName(filePath).Split('.');
            string fileName = fileNameArray[0];
            addVideo.Parameters.Add("@n", MySqlDbType.VarChar).Value = fileName;
            addVideo.ExecuteNonQuery();
            dataBase.closeConnection();

            this.id = GetId(fileName);



        }

        private bool checkFormat ()
        {
            if (this.dataTable.Columns[0].ColumnName.Equals("Ролик"))
            {
                if (this.dataTable.Columns[0].ColumnName.Equals("Частота")) return true;
                else return false;


            } 
            else return false;
        }

        public Schedule GetSchedule (int id)
        {
            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            dataBase.openConnection();
          
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `schedule` WHERE `id` = @id", dataBase.getConnection());
            selectDataCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dt);
            dataBase.closeConnection();
            this.name = dt.Rows[0]["name"].ToString();
            this.id = Convert.ToInt32 (dt.Rows[0]["id"]);
            ConvertExcel.ExcelInDataTable("E:\\Программирование\\Третий курс\\WindowsFormsApp1\\WindowsFormsApp1\\Server\\schedule\\" + this.name + ".xlsx");
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

    }
}
