using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        private string nameUser = "Null";
        private string surnameUser = "Null";

        public string get_nameUser ()
        {
            return this.nameUser;

        }

        public string get_surnameUser()
        {
            return this.surnameUser;

        }


        public void set_nameUser(string userName )
        {
            this.nameUser = userName;

        }

        public void set_surnameUser(string userSurname)
        {
            this.surnameUser = userSurname;
        }
    }
}
