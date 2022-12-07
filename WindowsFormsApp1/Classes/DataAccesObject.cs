using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataAccesObject
    {
        private DataBase db = new DataBase();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public DataTable select (string table, string field)
        {
            DataTable dataTable = new DataTable();
            db.openConnection();
            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT" + field + " FROM `" + table + "`", db.getConnection());
         
            adapter.SelectCommand = autorizathionSqlCommand;
            adapter.Fill(dataTable);

            db.closeConnection();
            return dataTable;


        }
        public void deleteUserinDevices (string table, string field, int value, int id)
        {
            db.openConnection();
            MySqlCommand changeField = new MySqlCommand("UPDATE `" + table + "` SET `" +field +"` = @v " +
                " WHERE `" +table+"`.`"+field+"` = @id", db.getConnection());
            changeField.Parameters.Add("@v", MySqlDbType.Int32).Value = value;
            changeField.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changeField.ExecuteNonQuery();
            db.closeConnection();


        }
        public DataTable authorizathion (string loginUser, string passwordUser)
        {
            DataTable dataTable = new DataTable();

            db.openConnection();
            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP ", db.getConnection());
            autorizathionSqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;
            autorizathionSqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
        

            adapter.SelectCommand = autorizathionSqlCommand;
            adapter.Fill(dataTable);

            db.closeConnection();
            return dataTable;

        }
        public DataTable selectDataUsers ()
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT `id`,`login`, `surname`, `name`,`post`,`role` FROM `users` ", db.getConnection());
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;


        }

        public DataTable selectDataUser(int id)
        {
            db.openConnection();
            DataTable dataTable = new DataTable();
            MySqlCommand userListCommand = new MySqlCommand(" SELECT `id`,`login`, `surname`, `name`,`post`,`role` FROM `users` WHERE `id` = @id", db.getConnection());
            userListCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = userListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;


        }
        public void UpdateUser (string newName, string newSurname, string newPost, int id)
        {
            db.openConnection();
            MySqlCommand updateUser = new MySqlCommand("UPDATE `users` SET `name` = @uN , " +
                " `surname` = @uS, `post` = @uP WHERE `users`.`id` = @id", db.getConnection());
           updateUser.Parameters.Add("@uN", MySqlDbType.VarChar).Value = newName;
           updateUser.Parameters.Add("@uS", MySqlDbType.VarChar).Value = newSurname;
           updateUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newPost;
           updateUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
           updateUser.ExecuteNonQuery();
            db.closeConnection();

        }
        public void deleteRows(string table, int id)
        {
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `"+ table +"` WHERE `ID` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }
        public void addUsers (string name, string surname, string login, string post)
        {

            db.openConnection();
            MySqlCommand addUser = new MySqlCommand("INSERT INTO `users` ( `name`, `surname`, `login`, `password`, `post`, `first_entry`) " +
                "VALUES (@n, @sn, @lg, '', @ps, '1')", db.getConnection());
            addUser.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            addUser.Parameters.Add("@sn", MySqlDbType.VarChar).Value = surname;
            addUser.Parameters.Add("@lg", MySqlDbType.VarChar).Value = login;
            addUser.Parameters.Add("@ps", MySqlDbType.VarChar).Value = post;

            addUser.ExecuteNonQuery();
            db.closeConnection();

        }
        public void addDevice (string name)
        {
            db.openConnection();
            MySqlCommand addDevices = new MySqlCommand("INSERT INTO `devices` (`name`) " + "VALUES (@n)", db.getConnection());
            addDevices.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            addDevices.ExecuteNonQuery();
            db.closeConnection();
        }
        public void changePassword (string password, int id)
        {
            
            db.openConnection();
            MySqlCommand changePassword = new MySqlCommand("UPDATE `users` SET `password` = @uP , " +
                " `first_entry` = 1 WHERE `users`.`id` = @id", db.getConnection());
            changePassword.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            changePassword.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changePassword.ExecuteNonQuery();
            db.closeConnection();
        }

        public DataTable selectAvailableDevices (int owner_id)
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
        public DataTable selectDataDevice (string name)
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
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `devices` WHERE `owner_id` = @id", db.getConnection());
            selectDataCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }
        public void addDeviceToUser (string nameDevice, int idUser)
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
