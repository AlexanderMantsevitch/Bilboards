using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class DeviceDataAccesObject: DataAccesObject
    {
        public void addDevice(string name, string type, int id_owner)
        {
            db.openConnection();
            MySqlCommand addDevices = new MySqlCommand("INSERT INTO `devices` (`name`, `type`, `owner_id`) " + "VALUES (@n, @t,@id)", db.getConnection());
            addDevices.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            addDevices.Parameters.Add("@t", MySqlDbType.VarChar).Value = type;
            addDevices.Parameters.Add("@id", MySqlDbType.Int32).Value = id_owner;
            addDevices.ExecuteNonQuery();
            db.closeConnection();
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
        public DataTable selectDataDevice(string name)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices` WHERE `name` = @dN", db.getConnection());
            selectDataCommand.Parameters.Add("@dN", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public DataTable selectDataDevice(int id)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices` WHERE `id` = @id", db.getConnection());
            selectDataCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            Console.WriteLine("tut"); 
            db.closeConnection();

            return dataTable;

        }
        public DataTable selectDataDevice()
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices`", db.getConnection());
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public void addDeviceToUser(string nameDevice, int idUser)
        {
            db.openConnection();
            MySqlCommand addDevice = new MySqlCommand("UPDATE `devices` SET `owner_id` = @id  WHERE `devices`.`name` = @dN", db.getConnection());
            addDevice.Parameters.Add("@dN", MySqlDbType.VarChar).Value = nameDevice;
            addDevice.Parameters.Add("@id", MySqlDbType.Int32).Value = idUser;
            addDevice.ExecuteNonQuery();
            db.closeConnection();


        }
    }
}
