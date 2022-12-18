using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public abstract class Rotation
    {
        public static List<string> createRotation(int id_device)
        {

            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            
            dataBase.openConnection();
            MySqlCommand selectDataCommand = new MySqlCommand(" SELECT * FROM `intermediatetable` WHERE `id_device` = @id", dataBase.getConnection());
            selectDataCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id_device;
            adapter.SelectCommand = selectDataCommand;
            adapter.Fill(dt);
            dataBase.closeConnection();

            

            List<string> rotation = new List<string>();

           
            string name_max = "";
            int previous_video = 0;
            int count = 0;

            foreach (DataRow dataRow in dt.Rows)
            {
                count += int.Parse(dataRow["freqyency"].ToString());

            }
           

            for (int i = 0; i < count; i++)
            {
                int max_freqyency = 0;
                int max_id = 0;
                int count_in_DT = 0;
                int number_max_row_in_dt = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (int.Parse(dataRow["freqyency"].ToString()) > max_freqyency && int.Parse(dataRow["id_video"].ToString()) != previous_video)
                    {

                        max_freqyency = int.Parse(dataRow["freqyency"].ToString());
                        max_id = int.Parse(dataRow["id_video"].ToString());
                        number_max_row_in_dt = count_in_DT;
 

                    }
                    count_in_DT++;
                }
              //  Console.WriteLine(max_id);
                dt.Rows[number_max_row_in_dt]["freqyency"] = int.Parse(dt.Rows[number_max_row_in_dt]["freqyency"].ToString()) - 1;
                previous_video = max_id;
                name_max = Videotape.get_name(previous_video);
                rotation.Add(name_max);
            }


            foreach (string a in rotation)
            {
                Console.WriteLine(a);

            }
            return rotation;
        }


    }
}
