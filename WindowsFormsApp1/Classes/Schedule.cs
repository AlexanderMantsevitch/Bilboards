using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Schedule
    {
        private int id;
        private DataTable dataTable;
       
       public Schedule ()
        {
            id = 0;
            dataTable = null;
        }

        public int Id { get => id; set => id = value; }

        public void downloadSchedule (string filePath)
        {
            DataBase dataBase = new DataBase();
            dataTable = ConvertExcel.ExcelInDataTable(filePath);

            Console.WriteLine((dataTable.Rows[0])["ФИО"] );


        }

    }
}
