using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.Exception;
using WindowsFormsApp1.WindowsForms;
using WindowsFormsApp1.WindowsForms.LoginForm;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            this.errorAuthorizathionLbl.Text = "";
           
        }

        public void SignIn ()
        {
            User user = new User();
            try
            {
               

                user.authorizathion(LogintextBox.Text, PasswordtextBox.Text);

                if (user.Role.Equals("Admin"))
                {
                    this.Hide();
                    AdminInterface adminInterface = new AdminInterface(this, user);
                    user.upDateStatus("online");
                    adminInterface.Show();


                }
                else
                {
                    this.Hide();
                    UserInterfaceForm adminInterface = new UserInterfaceForm(user, this);
                    adminInterface.Show();

                    user.upDateStatus("online");


                }

                Thread clearFideotapeList = new Thread( ()=>
                {
                    Videotape.deleteUnAviable();
                    
                   // Thread.Sleep(3600000);
                    Thread.CurrentThread.Abort();

                }


                    );
                clearFideotapeList.Start();

            }

            catch (MySqlException) { MessageBox.Show(" Нет соединения с базой данных");    }
            catch (AuthorizationException) { errorAuthorizathionLbl.Text = "Неверный логин или пароль"; }
            catch (FirstAuthorizationException)
            {
                this.errorAuthorizathionLbl.Text = "";
                NewPassword newPassword = new NewPassword(this, user);
                newPassword.Show();
                this.clear_textBox();
                this.Hide();

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
