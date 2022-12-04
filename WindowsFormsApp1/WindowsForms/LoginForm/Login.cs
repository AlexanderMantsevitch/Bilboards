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

            String loginUser = LogintextBox.Text;
            String passUser = PasswordtextBox.Text;

            try
            {

                DataBase db = new DataBase();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                db.openConnection();
                MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP ", db.getConnection());
                autorizathionSqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                autorizathionSqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = autorizathionSqlCommand;
                adapter.Fill(dataTable);

                db.closeConnection();
                if (dataTable.Rows.Count > 0)
                {


                    foreach (DataRow a in dataTable.Rows)
                    {

                        user.set_nameUser(a["name"].ToString());
                        user.set_surnameUser(a["surname"].ToString());
                        Console.WriteLine(a["name"].ToString());

                        if (!Convert.ToBoolean(a["first_entry"].ToString()))
                        {
                            NewPassword newPassword = new NewPassword(this);
                            newPassword.set_id(Convert.ToInt32(a["id"].ToString()));

                            newPassword.Show();
                            this.Hide();





                        }
                        else
                        {
                            if (a["role"].Equals("Admin"))
                            {
                                this.Hide();
                                AdminInterface adminInterface = new AdminInterface();
                                adminInterface.set_User(user);
                                adminInterface.Show();


                            }
                        }
                    }


                }

                else errorAuthorizathionLbl.Text = "Неправильный логин или пароль";
            }
            catch (MySqlException)
            {

                MessageBox.Show(" Нет соединения с базой данных");


            }
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.SignIn();

            
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AutorithationLabel_Click(object sender, EventArgs e)
        {

        }
        public void clear_textBox ()
        {
            LogintextBox.Text = "";
            PasswordtextBox.Text = "";
            errorAuthorizathionLbl.Text = "";

        }
    }
}
