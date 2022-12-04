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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    public partial class AddUserFrom : Form
    {
        public AddUserFrom()
        {
            InitializeComponent();
        }

       
        private void panelForm_Resize(object sender, EventArgs e)
        {
            panelAddUser.Location = new Point(((this.Width - panelAddUser.Width) / 2) - 8,
               ((this.Height - panelAddUser.Height) / 2) - 19);

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();
                DataTable dataTable = new DataTable();
                db.openConnection();
                MySqlCommand addUser = new MySqlCommand("INSERT INTO `users` ( `name`, `surname`, `login`, `password`, `post`, `first_entry`) " +
                    "VALUES (@n, @sn, @lg, '', @ps, '1')", db.getConnection());
                addUser.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameTextBox.Text;
                addUser.Parameters.Add("@sn", MySqlDbType.VarChar).Value = surameTextBox.Text;
                addUser.Parameters.Add("@lg", MySqlDbType.VarChar).Value = loginTextBox.Text;
                addUser.Parameters.Add("@ps", MySqlDbType.VarChar).Value = postTextBox.Text;

                addUser.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Пользователь успешно добавлен");
                nameTextBox.Text = ""; surameTextBox.Text = ""; loginTextBox.Text = ""; postTextBox.Text = "";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Нет соединения с базой данных");

            }
        }
    }
}
