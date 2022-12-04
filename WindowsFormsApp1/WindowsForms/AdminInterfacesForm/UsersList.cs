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
using WindowsFormsApp1.WindowsForms.AdminInterfacesForm;

namespace WindowsFormsApp1
{
    public partial class UsersList : Form
    {
        DataBase db = new DataBase();
        DataTable dataTable = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        AdminInterface parentForm;
        public UsersList(AdminInterface parentForm)
        {

            InitializeComponent();
            this.parentForm = parentForm;
            try
            {
                db.openConnection();
                MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT `id`, `surname`, `name`, `role` FROM `users` ", db.getConnection());


                adapter.SelectCommand = autorizathionSqlCommand;
                adapter.Fill(dataTable);
                db.closeConnection();

                usersListGrid.DataSource = dataTable;
                usersListGrid.Update();
            }
            catch (MySqlException)
            {
                
                MessageBox.Show(" Нет соединения с базой данных");

            }

        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                MySqlCommand deleteUser = new MySqlCommand("DELETE FROM `USERS` WHERE `ID` = @id;", db.getConnection());
                deleteUser.Parameters.Add("@id", MySqlDbType.Int32).Value = usersListGrid.CurrentRow.Cells[0].Value;
                deleteUser.ExecuteNonQuery();
            
                dataTable = new DataTable();
                    MySqlCommand usersListCommand = new MySqlCommand(" SELECT `id`, `surname`, `name`,`post`,`role` FROM `users` ", db.getConnection());
                adapter.SelectCommand = usersListCommand;
                adapter.Fill(dataTable);
                db.closeConnection();

                usersListGrid.DataSource = dataTable;
                usersListGrid.Update();

                
           
                
            }
            catch (MySqlException)
            {
                MessageBox.Show(" Нет соединения с базой данных");

            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            parentForm.PanelForm(new AddUserFrom());
        }
    }
}
