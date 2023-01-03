using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class VideoTapeList
    {
        private DataBase db = new DataBase();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private DataTable dataTable;

        public VideoTapeList()
        {
            dataTable = new DataTable();
            

        }

        private DataTable select ()
        {

            db.openConnection();
            dataTable = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `video`", db.getConnection());
            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dataTable);
            db.closeConnection();

            return dataTable;

        }

        public  DataTable selectInformationAboutVideo ()
        {
         
            db.openConnection();
            DataTable dt = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `video`", db.getConnection());
            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dt);
            db.closeConnection();

            dt.Columns.Remove("Data");
            dt.Columns.Remove("id");

            dt.Columns.Add("added");
            UsersList usersList = new UsersList();
            foreach (DataRow dataRow in dt.Rows)
            {
                User user = new User(usersList.selectDataUser(int.Parse (dataRow["id_user"].ToString())));
                dataRow["added"] = user.Login;

            }
            dt.Columns.Remove("id_user");
            return dt;

        }

        public DataTable selectUserVideo (int id_user)
        {

            db.openConnection();
            DataTable dt = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `video` WHERE `id_user` = @id", db.getConnection());
            VideoListCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = id_user;
            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dt);
            db.closeConnection();

            dt.Columns.Remove("Data");
            dt.Columns.Remove("id");
            dt.Columns.Remove("id_user");
            return dt;


        }

        public DataTable selectStatistic ()
        {
            db.openConnection();
            DataTable dt = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `statistic`", db.getConnection());
           
            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dt);


            DataTable bufferDataTable = new DataTable();
            bufferDataTable = selectInformationAboutVideo();

            

            db.closeConnection();
            dt.Columns.Add("added");
            dt.Columns.Remove("date");
            UsersList usersList = new UsersList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (i != j)
                    {
                        if (dt.Rows[i]["name_video"].Equals(dt.Rows[j]["name_video"]))
                        {
                            dt.Rows[i]["repeat"] = int.Parse(dt.Rows[i]["repeat"].ToString()) + int.Parse(dt.Rows[j]["repeat"].ToString());
                            dt.Rows.RemoveAt(j); 

    
                        }

                    } }

            }




            foreach (DataRow dataRow in dt.Rows)
            {
                

                foreach (DataRow dr in bufferDataTable.Rows)
                {
                    if (dataRow["name_video"].Equals(dr["name"].ToString()))
                    {

                        
                        dataRow["added"] = dr["added"];

                    }
                }
                
                
            }

            return dt;
        }



        public DataTable selectUserStatistic (int id_user)
        {

            DataTable videoDT = selectUserVideo(id_user);
            db.openConnection();
            DataTable dt = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `statistic`", db.getConnection());

            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dt);


            db.closeConnection();
          
            dt.Columns.Remove("date");
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < videoDT.Rows.Count; j++)
                {
                    if (dt.Rows[i]["name_video"].Equals(videoDT.Rows[j]["name"].ToString()))
                    {
                        flag = true;
                        
                    }   


                }

                if (!flag)
                {

                    dt.Rows.RemoveAt(i);
                    i--;
                }
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (i != j)
                    {
                        if (dt.Rows[i]["name_video"].Equals(dt.Rows[j]["name_video"]))
                        {
                            dt.Rows[i]["repeat"] = int.Parse(dt.Rows[i]["repeat"].ToString()) + int.Parse(dt.Rows[j]["repeat"].ToString());
                            dt.Rows.RemoveAt(j);


                        }

                    }
                }

            }

            return dt;


        }


        public DataTable selectStatistic(DateTime dateTime)
        {
            db.openConnection();
            DataTable dt = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `statistic` WHERE `date` = @d", db.getConnection());
            VideoListCommand.Parameters.Add("@d", MySqlDbType.Date).Value = dateTime.Date;
            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dt);


            DataTable bufferDataTable = selectInformationAboutVideo();
            
            db.closeConnection();
            dt.Columns.Add("added");
           
            UsersList usersList = new UsersList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (i != j)
                    {
                        if (dt.Rows[i]["name_video"].Equals(dt.Rows[j]["name_video"]))
                        {
                            dt.Rows[i]["repeat"] = int.Parse(dt.Rows[i]["repeat"].ToString()) + int.Parse(dt.Rows[j]["repeat"].ToString());
                            dt.Rows.RemoveAt(j);


                        }

                    }
                }

            }




            foreach (DataRow dataRow in dt.Rows)
            {


                foreach (DataRow dr in bufferDataTable.Rows)
                {
                    if (dataRow["name_video"].Equals(dr["name"].ToString()))
                    {


                        dataRow["added"] = dr["added"];

                    }
                }


            }

            return dt;
        }

        public DataTable selectUserStatistic(int id_user, DateTime dateTime)
        {

            DataTable videoDT = selectUserVideo(id_user);
            db.openConnection();
            DataTable dt = new DataTable();
            MySqlCommand VideoListCommand = new MySqlCommand(" SELECT * FROM `statistic` WHERE `date` = @d", db.getConnection());
            VideoListCommand.Parameters.Add("@d", MySqlDbType.Date).Value = dateTime.Date;
            adapter.SelectCommand = VideoListCommand;
            adapter.Fill(dt);


            db.closeConnection();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < videoDT.Rows.Count; j++)
                {
                    if (dt.Rows[i]["name_video"].Equals(videoDT.Rows[j]["name"].ToString()))
                    {
                        flag = true;

                    }


                }

                if (!flag)
                {

                    dt.Rows.RemoveAt(i);
                    i--;
                }
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (i != j)
                    {
                        if (dt.Rows[i]["name_video"].Equals(dt.Rows[j]["name_video"]))
                        {
                            dt.Rows[i]["repeat"] = int.Parse(dt.Rows[i]["repeat"].ToString()) + int.Parse(dt.Rows[j]["repeat"].ToString());
                            dt.Rows.RemoveAt(j);


                        }

                    }
                }

            }

            return dt;


        }
    }

}
