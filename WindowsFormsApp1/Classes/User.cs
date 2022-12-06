using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class User
    {
        private string name;
        private string surname;
        private int id;
        private string post;
        private string role;
        private string login;

        public string Login { get => login; set => login = value; }
        public string Role { get => role; set => role = value; }
        public string Post { get => post; set => post = value; }
        public int Id { get => id; set => id = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }

        public User ()
        {

            this.name = "NULL";
            this.surname = "NULL";
            this.login = "NULL";
            this.id = 0;
            this.post = "NULL";
            this.role = "NULL";

        }

        public User (User user)
        {
            this.name = user.Name;
            this.surname = user.Surname;
            this.id = user.Id;
            this.login = user.Login;
            this.post = user.Post;
            this.role = user.Role;

        }
       public User (DataRow dataRow)
        {
            this.name = dataRow["name"].ToString();  
            this.surname = dataRow["surname"].ToString(); ;
            this.id = Convert.ToInt32(dataRow["id"].ToString()); 
            this.login = dataRow["login"].ToString(); 
            this.post = dataRow["post"].ToString();
            this.role = dataRow["role"].ToString();

        }
        
    }
}
