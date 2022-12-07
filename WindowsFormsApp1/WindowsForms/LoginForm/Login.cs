using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.WindowsForms.LoginForm;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private User user = new User();
        public Login()
        {
            InitializeComponent();

            
        }

        public void SignIn ()
        {

            try
            {

                DataTable dataTable = new DataTable();
                UserDataAccesObject dao = new UserDataAccesObject();
                dataTable = dao.authorizathion(LogintextBox.Text, PasswordtextBox.Text);


                if (dataTable.Rows.Count > 0)
                {


                    foreach (DataRow a in dataTable.Rows)
                    {

                        user.Name = (a["name"].ToString());
                        user.Surname = (a["surname"].ToString());
                        user.Id = (Convert.ToInt32(a["id"].ToString()));
                        user.Post = (a["post"].ToString());
                        user.Role = ((a["role"].ToString()));
                        user.Login = (a["login"].ToString());
                        Console.WriteLine(a["name"].ToString());

                        if (!Convert.ToBoolean(a["first_entry"].ToString()))
                        {
                            NewPassword newPassword = new NewPassword(this);
                            newPassword.set_id(Convert.ToInt32(a["id"].ToString()));

                            newPassword.Show();
                            this.clear_textBox();
                            this.errorAuthorizathionLbl.Text = "";
                            this.Hide();


                        }
                        else
                        {
                            if (a["role"].Equals("Admin"))
                            {
                                this.Hide();
                                AdminInterface adminInterface = new AdminInterface(this);
                                adminInterface.set_User(user);
                                adminInterface.Show();


                            }
                        }
                    }


                }

                else
                {
                    Console.WriteLine("go");
                    this.errorAuthorizathionLbl.Text = "Неправильный логин или пароль";
                }
            }
            catch (MySqlException)
            {

                MessageBox.Show(" Нет соединения с базой данных");


            }
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {

            errorAuthorizathionLbl.Text = "";
            this.SignIn();
            clear_textBox();


        }

      
        public void clear_textBox ()
        {
            LogintextBox.Text = "";
            PasswordtextBox.Text = "";
           

        }
    }
}
