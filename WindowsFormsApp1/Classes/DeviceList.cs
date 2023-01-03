using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class DeviceList: DataAccesObject
    {
        DataTable dataTable;
      

        public DeviceList()
        {
            dataTable = select();

        }
        public DeviceList(DataTable dataTable)
        {
            this.dataTable = dataTable;
        }

        public DataTable selectAvailableDevices(int owner_id)
        {
            DataTable dataTable = new DataTable();

            db.openConnection();

            MySqlCommand devicesListCommand = new MySqlCommand(" SELECT * FROM `devices`  WHERE `owner_id` = @id", db.getConnection());
            devicesListCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = owner_id;
            adapter.SelectCommand = devicesListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }

        public DataTable selectAvailableDevicesFromUser(int owner_id)
        {
            DataTable dataTable = new DataTable();

            db.openConnection();

            MySqlCommand devicesListCommand = new MySqlCommand(" SELECT `name`, `type`,`schedule_id`,`status` FROM `devices`  WHERE `owner_id` = @id", db.getConnection());
            devicesListCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = owner_id;
            adapter.SelectCommand = devicesListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            dataTable.Columns.Add("schedule");
            Schedule schedule = new Schedule();
            foreach (DataRow dataRow in dataTable.Rows)
            {

             if (!dataRow["schedule_id"].ToString().Equals("0"))   dataRow["schedule"] = schedule.GetSchedule(int.Parse(dataRow["schedule_id"].ToString())).Name;

            }

            dataTable.Columns.Remove("schedule_id"); 
            return dataTable;

        }

        public Device selectDevice(string name)
        {
            Device device = new Device();
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices` WHERE `name` = @dN", dataBase.getConnection());
            selectDataCommand.Parameters.Add("@dN", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            dataBase.closeConnection();
            if(dataTable.Rows.Count > 0)
            device = new Device(dataTable.Rows[0]);
            return device;

        }
        public Device selectDevice(int id)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices` WHERE `id` = @id", db.getConnection());
            selectDataCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
          //  Console.WriteLine("tut");
            db.closeConnection();

            Device device = new Device(dataTable.Rows[0]);
            return device;

        }
        public DataTable select()
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices`", db.getConnection());
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public override void deleteRows(int id)
        {
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `devices` WHERE `ID` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }
        public override void updateCell(string field, int value, int id)
        {
            db.openConnection();
            MySqlCommand changeField = new MySqlCommand("UPDATE `devices` SET `" + field + "` = @v " +
                " WHERE `devices`.`" + field + "` = @id", db.getConnection());
            changeField.Parameters.Add("@v", MySqlDbType.Int32).Value = value;
            changeField.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changeField.ExecuteNonQuery();
            db.closeConnection();


        }
        public DataTable select(string field, string value)
        {
            db.openConnection();
            DataTable data = new DataTable();
            MySqlCommand devicesListCommand = new MySqlCommand(" SELECT * FROM `devices`" +
                "WHERE `" + field + "` = @v", db.getConnection());
            devicesListCommand.Parameters.Add("@v", MySqlDbType.VarChar).Value = value;
            adapter.SelectCommand = devicesListCommand;
            adapter.Fill(data);
            db.closeConnection();
            this.dataTable = data;
            return dataTable;

        }
    }
}
