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
    public partial class UsersList : Form
    {
        private UserDataAccesObject dao = new UserDataAccesObject();
        private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        private DataTable dataTable = new DataTable();
        private User user;
        
        AdminInterface parentForm;
        public UsersList(AdminInterface parentForm, User user)
        {

            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
           
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
            
           // try
            {


                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить выбранного пользователя?", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                  
                    logDAO.addNotation(user, "Пользователь " + usersListGrid.CurrentRow.Cells["login"].Value + " был удален");
                   
                    dao.updateCell("devices", "owner_id", 0, Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value));
                    dao.deleteRows("users", Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value));
                    usersListGrid.DataSource = dao.selectDataUsers();
                    usersListGrid.Update();
                    

                }
           
                
            }
            //catch (MySqlException)
            //{
            //    MessageBox.Show(" Нет соединения с базой данных");

            //}
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            parentForm.PanelForm(new AddUserForm(user));
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            
            
            User currentUser = new User (dao.selectDataUser(Convert.ToInt32(usersListGrid.CurrentRow.Cells[0].Value)).Rows[0]);
            parentForm.PanelForm(new UserInformationForm(currentUser, parentForm, user));
            
            
            

        }
    }
}
