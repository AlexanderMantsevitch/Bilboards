using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1
{
   public class User
    {
        private UserDataAccesObject dao = new UserDataAccesObject();
        private string name;
        private string surname;
        private int id;
        private string post;
        private string role;
        private string login;
        private string status;
      

        public string Login { get => login; set => login = value; }
        public string Role { get => role; set => role = value; }
        public string Post { get => post; set => post = value; }
        public int Id { get => id; set => id = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public User ()
        {

            this.name = "NULL";
            this.surname = "NULL";
            this.login = "NULL";
            this.id = 0;
            this.post = "NULL";
            this.role = "NULL";
            this.status = "Offline";

        }

        public User (User user)
        {
            this.name = user.Name;
            this.surname = user.Surname;
            this.id = user.Id;
            this.login = user.Login;
            this.post = user.Post;
            this.role = user.Role;
            this.status = user.Status;

        }
       public User (DataRow dataRow)
        {
            this.setInformation(dataRow);

        }

        private void setInformation (DataRow dataRow)
        {
            this.name = dataRow["name"].ToString();
            this.surname = dataRow["surname"].ToString(); ;
            this.id = Convert.ToInt32(dataRow["id"].ToString());
            this.login = dataRow["login"].ToString();
            this.post = dataRow["post"].ToString();
            this.role = dataRow["role"].ToString();
            this.status = dataRow["status"].ToString();

        }

        public void authorizathion (string login, string password)
        {
            DataTable dataTable = new DataTable();
            dataTable = dao.authorizathion(login, password);

            if (dataTable.Rows.Count > 0)
            {
                this.setInformation(dataTable.Rows[0]);
                if (!Convert.ToBoolean((dataTable.Rows[0])["first_entry"].ToString()))
                {
                    throw new FirstAuthorizationException();

                }
                
            }
            else
            {

                throw new AuthorizationException("Неверный логин или пароль");
            }


        }
        public void upDateStatus (string value)
        {

            dao.upDateStatus(this.id, value);
            this.status = value;

        }
        public void changePassword (int id, string password)
        {
            dao.changePassword(password, id);

        }
        public void upDateUser (string name, string surname, string post)
        {
            dao.UpdateUser(name, surname, post, this.Id);

        }
        public void addUser (string name, string surname, string login, string post)
        {
            UsersList usersList = new UsersList();
            if (usersList.selectDataUser(login).Id == 0)
            {
                dao.addUsers(name, surname, login, post);
               
                this.setInformation(usersList.select("login", login).Rows[0]);

            }
            else
            {
                throw new AddException();

            }

        }
    }
}
