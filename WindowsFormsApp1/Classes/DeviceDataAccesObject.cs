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
      
        public void addDeviceToUser(string nameDevice, int idUser)
        {
            db.openConnection();
            MySqlCommand addDevice = new MySqlCommand("UPDATE `devices` SET `owner_id` = @id  WHERE `devices`.`name` = @dN", db.getConnection());
            addDevice.Parameters.Add("@dN", MySqlDbType.VarChar).Value = nameDevice;
            addDevice.Parameters.Add("@id", MySqlDbType.Int32).Value = idUser;
            addDevice.ExecuteNonQuery();
            db.closeConnection();


        }
        public override void updateCell(string field, int value, int id)
        {
            db.openConnection();
            MySqlCommand changeField = new MySqlCommand("UPDATE `devices` SET `" + field + "` = @v " +
                " WHERE `devices`.`id` = @id", db.getConnection());
            changeField.Parameters.Add("@v", MySqlDbType.Int32).Value = value;
            changeField.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changeField.ExecuteNonQuery();
            db.closeConnection();


        }
        public override void deleteRows(int id)
       
         {
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `devices` WHERE `ID` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }
}
}
