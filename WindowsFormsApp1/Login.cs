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
        public Login()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            String loginUser = LogintextBox.Text;
            String passUser = PasswordtextBox.Text;

            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP ", db.getConnection());
            autorizathionSqlCommand.Parameters.Add("@uL" , MySqlDbType.VarChar ).Value = loginUser;
            autorizathionSqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = autorizathionSqlCommand;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {

               foreach (DataRow a in dataTable.Rows)
                {
                   
                    if ( a["role"].Equals("Admin"))
                    {
                        this.Hide();
                        AdminInterface adminInterface = new AdminInterface();
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
