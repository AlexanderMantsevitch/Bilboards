using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class DataAccesObject
    {
        protected DataBase db = new DataBase();
        protected MySqlDataAdapter adapter = new MySqlDataAdapter();

        public DataTable select (string table, string field)
        {
            DataTable dataTable = new DataTable();
            db.openConnection();
            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT `" + field + "` FROM `" + table + "`", db.getConnection());
         
            adapter.SelectCommand = autorizathionSqlCommand;
            adapter.Fill(dataTable);

            db.closeConnection();
            return dataTable;


        }

        public DataTable select (string table, string field, string value)
        {
            DataTable dataTable = new DataTable();
            db.openConnection();
            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT * FROM `" + table + "` WHERE `"+ field+"` = @v" , db.getConnection());
            autorizathionSqlCommand.Parameters.Add("@v", MySqlDbType.VarChar).Value = value;
         
            adapter.SelectCommand = autorizathionSqlCommand;
            adapter.Fill(dataTable);

            db.closeConnection();
            return dataTable;


        }
        public void updateCell (string table, string field, int value, int id)
        {
            db.openConnection();
            MySqlCommand changeField = new MySqlCommand("UPDATE `" + table + "` SET `" +field +"` = @v " +
                " WHERE `" +table+"`.`"+field+"` = @id", db.getConnection());
            changeField.Parameters.Add("@v", MySqlDbType.Int32).Value = value;
            changeField.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            changeField.ExecuteNonQuery();
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
       
       
      

      
    }
}
