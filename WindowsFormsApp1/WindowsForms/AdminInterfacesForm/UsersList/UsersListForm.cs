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
using WindowsFormsApp1.WindowsForms.AdminInterfacesForm;

namespace WindowsFormsApp1
{
    public partial class UsersListForm : Form
    {
        private UsersList usersList = new UsersList();
        private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        private DataTable dataTable = new DataTable();
        private User user;
        
        AdminInterface parentForm;
        public UsersListForm(AdminInterface parentForm, User user)
        {

            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
           
            try
            {
               
                usersListGrid.DataSource = usersList.select(); 
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


                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить выбранного пользователя?", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                  
                    logDAO.addNotation(user, "Пользователь " + usersListGrid.CurrentRow.Cells["login"].Value + " был удален");
                    DeviceList devicesList = new DeviceList();
                    devicesList.updateCell("owner_id", 0, Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value));
                    usersList.deleteRows(Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value));
                    usersListGrid.DataSource = usersList.select();
                    usersListGrid.Update();
                    

                }
           
                
            }
            catch (MySqlException)
            {
                MessageBox.Show(" Нет соединения с базой данных");

            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            parentForm.PanelForm(new AddUserForm(user));
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            
            
            User currentUser = new User (usersList.selectDataUser(Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value)));
            parentForm.PanelForm(new UserInformationForm(currentUser, parentForm, user));
            
            
            

        }
    }
}
