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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private User user = new User();
        public Login()
        {
            InitializeComponent();
            
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AdminInterface adminInterface1 = new AdminInterface();
            //adminInterface1.Show();
            //return;
            String loginUser = LogintextBox.Text;
            String passUser = PasswordtextBox.Text;

            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP ", db.getConnection());
            autorizathionSqlCommand.Parameters.Add("@uL" , MySqlDbType.VarChar ).Value = loginUser;
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
                    

                    if ( a["role"].Equals("Admin"))
                    {
                        this.Hide();
                        AdminInterface adminInterface = new AdminInterface();
                        adminInterface.set_User(user);
                        adminInterface.Show();
                        

                    }

                }

                
            }

            else errorAuthorizathionLbl.Text = "Неправильный логин или пароль";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
