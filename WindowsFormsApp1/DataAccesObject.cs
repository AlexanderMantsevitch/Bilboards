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
        public DataTable authorizathion (string loginUser, string passwordUser)
        {
            DataTable dataTable = new DataTable();
            
           
           
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
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT `id`, `surname`, `name`,`post`,`role` FROM `users` ", db.getConnection());
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

           

            return dataTable;


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
    }
}
