using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1.Classes
{
    public class Device
    {
        private int id;
        private int owner_id;
        private string name;
        private string type;
        private string status;
        private DeviceDataAccesObject dao = new DeviceDataAccesObject();
        private Schedule schedule = new Schedule();

        public int Id { get => id; set => id = value; }
        public int Owner_id { get => owner_id; set => owner_id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Status { get => status; set => status = value; }
        public Schedule Schedule { get => schedule; set => schedule = value; }

        public Device ()
        {
            this.id = 0;
            this.owner_id = 0;
            this.name = "Null";
            this.type = "Null";
            this.status = "off";

        }
        public Device (Device device)
        {
            this.id = device.Id;
            this.name = device.Name;
            this.owner_id = device.Owner_id;
            this.type = device.Type;
            this.status = device.Status;
            this.schedule = device.Schedule;


        }

        public Device(DataRow dataRow)
        {
            this.name = dataRow["name"].ToString();
            this.id = Convert.ToInt32(dataRow["id"].ToString());
            this.owner_id = Convert.ToInt32(dataRow["owner_id"].ToString());
            this.type = dataRow["type"].ToString();
            this.status = dataRow["status"].ToString();
            if (int.Parse(dataRow["schedule_id"].ToString()) != 0) this.schedule = new Schedule().GetSchedule(int.Parse(dataRow["schedule_id"].ToString()));
                

        }

        public void addDeviceToUser (int idUser)
        {
           

            if (this.Owner_id == 0)
            {
                dao.addDeviceToUser(this.Name, idUser);
               
            }
            else
            {
                throw new AssignUserDeviceException();
            }

        }
        public void updateCell(string field, int value, int id)
        {
            dao.updateCell(field, value, id);


        }
        public void deleteRows(int id)

        {
            dao.deleteRows(this.Id);

        }

        public void upDateStatus (string status)
        {
            DataBase db = new DataBase();
            db.openConnection();
            MySqlCommand changeField = new MySqlCommand("UPDATE `devices` SET `status` = @v " +
                " WHERE `devices`.`id` = @id", db.getConnection());
            changeField.Parameters.Add("@v", MySqlDbType.VarChar).Value= status;
            changeField.Parameters.Add("@id", MySqlDbType.Int32).Value = this.Id;
            changeField.ExecuteNonQuery();
            db.closeConnection();

        }
        public void addDevice(string name,  string type, int userId)
        {
            DeviceList devicesList = new DeviceList();
            if (devicesList.selectDevice(name).Id == 0)
            {
                dao.addDevice (name, type, userId);

            }
            else
            {
                throw new AddException();

            }

        }

        public void setInformation (DataRow dataRow)
        {

            this.name = dataRow["name"].ToString();
            this.id = Convert.ToInt32(dataRow["id"].ToString());
            this.owner_id = Convert.ToInt32(dataRow["owner_id"].ToString());
            this.type = dataRow["type"].ToString();
            this.status = dataRow["status"].ToString();

        }
    }
}
