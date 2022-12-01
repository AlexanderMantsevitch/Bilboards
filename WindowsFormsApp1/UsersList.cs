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
    public partial class UsersList : Form
    {
        private User user = new User();
        public UsersList()
        {

            InitializeComponent();
            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand autorizathionSqlCommand = new MySqlCommand(" SELECT `id`, `surname`, `name`, `role` FROM `users` ", db.getConnection());
          

            adapter.SelectCommand = autorizathionSqlCommand;
            adapter.Fill(dataTable);
            db.closeConnection();
           
            usersListGrid.DataSource = dataTable;
            usersListGrid.Update();
            

        }
        private void UsersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void set_User(User user_loginForm)
        {
            this.user = user_loginForm;
            UserNameLabel.Text = user.get_nameUser();
            UserSurnameLabel.Text = user.get_surnameUser();


        }

        
    }
}
