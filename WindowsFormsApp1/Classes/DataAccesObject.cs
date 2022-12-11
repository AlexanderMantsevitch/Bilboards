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

        public abstract void updateCell(string field, int value, int id);
        public abstract void deleteRows(int id);
       
       
       
      

      
    }
}
