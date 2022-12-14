using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class UserDataAccesObject : DataAccesObject
    {

        public DataTable authorizathion(string loginUser, string passwordUser)
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
        public void UpdateUser(string newName, string newSurname, string newPost, int id)
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
        public void addUsers(string name, string surname, string login, string post)
        {

            db.openConnection();
            MySqlCommand addUser = new MySqlCommand("INSERT INTO `users` ( `name`, `surname`, `login`, `password`, `post`, `first_entry`) " +
                "VALUES (@n, @sn, @lg, '', @ps, '0')", db.getConnection());
            addUser.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            addUser.Parameters.Add("@sn", MySqlDbType.VarChar).Value = surname;
            addUser.Parameters.Add("@lg", MySqlDbType.VarChar).Value = login;
            addUser.Parameters.Add("@ps", MySqlDbType.VarChar).Value = post;

            addUser.ExecuteNonQuery();
            db.closeConnection();

        }
        public void changePassword(string password, int id)
        {

            db.openConnection();
            MySqlCommand changePassword = new MySqlCommand("UPDATE `users` SET `password` = @uP , " +
                " `first_entry` = 1 WHERE `users`.`id` = @id", db.getConnection());
            changePassword.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            changePassword.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changePassword.ExecuteNonQuery();
            db.closeConnection();
        }

        public void upDateStatus(int id, string status)
        {

            db.openConnection();
            MySqlCommand changePassword = new MySqlCommand("UPDATE `users` SET `status` = @uS , " +
                " `first_entry` = 1 WHERE `users`.`id` = @id", db.getConnection());
            changePassword.Parameters.Add("@uS", MySqlDbType.VarChar).Value = status;
            changePassword.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changePassword.ExecuteNonQuery();
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
        public override void deleteRows(int id)
         {
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `users` WHERE `ID` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }
}
}
