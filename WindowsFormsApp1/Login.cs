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
                foreach (DataColumn dc in dataTable.Columns)
                {

                    Console.Write("\t{0}", dc.ColumnName);

                }
                if (dataTable.Columns[2].Expression == "Admin")
                {
                   

                }


            }

            else errorAuthorizathionLbl.Text = "Неправильный логин или пароль";
        }

  
    }
}
