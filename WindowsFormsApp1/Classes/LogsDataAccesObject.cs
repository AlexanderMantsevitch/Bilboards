using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class LogsDataAccesObject
    {

       private  DataBase db = new DataBase();
       private MySqlDataAdapter adapter = new MySqlDataAdapter();


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
        public DataTable selectLogs()
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `logs`", db.getConnection());
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public DataTable filterLogs(DateTime fromDateTime, DateTime toDateTime)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `logs` WHERE  `date` >= @fr AND `date` <= @to", db.getConnection());
            selectDataCommand.Parameters.Add("@fr", MySqlDbType.Date).Value = fromDateTime.Date;
            selectDataCommand.Parameters.Add("@to", MySqlDbType.Date).Value = toDateTime.Date;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }

        public DataTable filterLogs(string username)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `logs` WHERE  `user` = @uL", db.getConnection());
            selectDataCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = username;
        
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public DataTable filterLogs(DateTime fromDateTime, DateTime toDateTime, string username)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `logs` WHERE  `date` >= @fr AND `date` <= @to AND `user` = @uL", db.getConnection());
            selectDataCommand.Parameters.Add("@fr", MySqlDbType.Date).Value = fromDateTime.Date;
            selectDataCommand.Parameters.Add("@to", MySqlDbType.Date).Value = toDateTime.Date;
            selectDataCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public void deleteRows(string name)
        {
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `logs` WHERE `logs`.`user` = @n;", db.getConnection());
            deleteUser.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }

    }
}
