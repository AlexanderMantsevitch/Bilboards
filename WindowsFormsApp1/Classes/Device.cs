using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Device
    {
        private int id;
        private int owner_id;
        private string name;

        public int Id { get => id; set => id = value; }
        public int Owner_id { get => owner_id; set => owner_id = value; }
        public string Name { get => name; set => name = value; }

        public Device ()
        {
            this.id = 0;
            this.owner_id = 0;
            this.name = "Null";

        }
        public Device (Device device)
        {
            this.id = device.id;
            this.name = device.name;
            this.owner_id = device.owner_id;

        }

        public Device(DataRow dataRow)
        {
            this.name = dataRow["name"].ToString();
            this.id = Convert.ToInt32(dataRow["id"].ToString());
            this.owner_id = Convert.ToInt32(dataRow["owner_id"].ToString());


        }
    }
}
