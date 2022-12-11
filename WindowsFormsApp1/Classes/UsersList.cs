using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class UsersList
    {
        DataTable dataTable;
        DataBase db = new DataBase();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        public UsersList ()
        {
            dataTable = select();

        }
        public UsersList (DataTable dataTable)
        {
            this.dataTable = dataTable; 
        }

        public DataTable select()
        {
            db.openConnection();
            DataTable data = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT `id`,`login`, `surname`, `name`,`post`,`role`,`status` FROM `users` ", db.getConnection());
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(data);
            db.closeConnection();
            this.dataTable = data;
            return dataTable;

        }

        public DataTable select(string field, string value)
        {
            db.openConnection();
            DataTable data = new DataTable();
            MySqlCommand usersListCommand = new MySqlCommand(" SELECT `id`,`login`, `surname`, `name`,`post`,`role`,`status` FROM `users`" +
                "WHERE `" + field + "` = @v", db.getConnection());
            usersListCommand.Parameters.Add("@v", MySqlDbType.VarChar).Value = value;
            adapter.SelectCommand = usersListCommand;
            adapter.Fill(data);
            db.closeConnection();
            this.dataTable = data;
            return dataTable;

        }
  

        public User selectDataUser(int id)
        {
           User user = new User();
           foreach (DataRow dataRow in dataTable.Rows)
            {
                if (int.Parse (dataRow["id"].ToString()) == id )
                {
                    user = new User(dataRow);
                }

            }
            return user;
            

        }
        public User selectDataUser(string loginUser)
        {
            User user = new User();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["login"].ToString().Equals(loginUser))
                {
                    user = new User(dataRow);
                    
                }

            }

            return user;


        }

        public void deleteRows( int id)
        {
            db.openConnection();
            MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `users` WHERE `ID` = @id;", db.getConnection());
            deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            deleteUser.ExecuteNonQuery();
            db.closeConnection();

        }



    }
}
