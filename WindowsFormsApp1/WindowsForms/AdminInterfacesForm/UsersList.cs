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
        DataAccesObject dao = new DataAccesObject();
        DataTable dataTable = new DataTable();
        
        AdminInterface parentForm;
        public UsersList(AdminInterface parentForm)
        {

            InitializeComponent();
            this.parentForm = parentForm;
            try
            {
               
                usersListGrid.DataSource = dao.selectDataUsers(); 
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

                dao.setVarChar("devices", "owner_id", 0);
                dao.deleteRows("users",Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value));
                usersListGrid.DataSource = dao.selectDataUsers();
                usersListGrid.Update();

                
           
                
            }
            catch (MySqlException)
            {
                MessageBox.Show(" Нет соединения с базой данных");

            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            parentForm.PanelForm(new AddUserForm());
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            
            
            User user = new User (dao.selectDataUser(Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value)).Rows[0]);
            parentForm.PanelForm(new UserInformationForm(user, parentForm));
            
            
            

        }
    }
}
