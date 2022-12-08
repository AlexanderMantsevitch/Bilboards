using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Device
    {
        private int id;
        private int owner_id;
        private string name;
        private string type;
        private string status;

        public int Id { get => id; set => id = value; }
        public int Owner_id { get => owner_id; set => owner_id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Status { get => status; set => status = value; }

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


        }

        public Device(DataRow dataRow)
        {
            this.name = dataRow["name"].ToString();
            this.id = Convert.ToInt32(dataRow["id"].ToString());
            this.owner_id = Convert.ToInt32(dataRow["owner_id"].ToString());
            this.type = dataRow["type"].ToString();
            this.status = dataRow["status"].ToString();


        }
    }
}
