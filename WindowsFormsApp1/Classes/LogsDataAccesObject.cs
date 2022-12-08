using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class LogsDataAccesObject
    {

        DataBase db = new DataBase();


        public void addNotation(User user, string operation)
        {
            string userLogin = user.Login;
            db.openConnection();
            MySqlCommand addDevices = new MySqlCommand("INSERT INTO `logs` (`date`, `time`, `user`, `operation`) " + "VALUES (@d, @t,@u,@o)", db.getConnection());
            addDevices.Parameters.Add("@d", MySqlDbType.Date).Value = DateTime.Now.Date;
            addDevices.Parameters.Add("@t", MySqlDbType.Time).Value = DateTime.Now.TimeOfDay;
            addDevices.Parameters.Add("@u", MySqlDbType.VarChar).Value = userLogin;
            addDevices.Parameters.Add("@o", MySqlDbType.VarChar).Value = operation;

            addDevices.ExecuteNonQuery();
            db.closeConnection();
        }


    }
}
