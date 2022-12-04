using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class User
    {
        private string nameUser;
        private string surnameUser;

        public User ()
        {

            this.nameUser = "NULL";
            this.surnameUser = "NULL";

        }

        public User (User user)
        {
            this.nameUser = user.get_nameUser();
            this.surnameUser = user.get_surnameUser();

        }
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
