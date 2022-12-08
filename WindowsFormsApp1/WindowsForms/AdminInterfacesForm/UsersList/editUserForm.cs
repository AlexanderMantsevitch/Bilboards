using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    public partial class editUserForm : Form
    {
        private AdminInterface parentForm;
        private User currentUser = new User();
        private User user;
        private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        public editUserForm(User currentUser, AdminInterface parentForm, User user)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.parentForm = parentForm;
            this.user = user;
            errorLbl.Text = "";
            loginTextBox.Text = currentUser.Login;
            loginTextBox.Enabled = false;
            nameTextBox.Text = currentUser.Name;
            surameTextBox.Text = currentUser.Surname;
            postTextBox.Text = currentUser.Post;
            editUserPanel.Location = new Point(((this.Width - editUserPanel.Width) / 2) - 8,
                   ((this.Height - editUserPanel.Height) / 2) - 19);

        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            if (!(surameTextBox.Text.Equals("") || nameTextBox.Text.Equals("")))
            {
                UserDataAccesObject dao = new UserDataAccesObject();
                currentUser.Name = nameTextBox.Text;
                currentUser.Surname = surameTextBox.Text;
                currentUser.Post = postTextBox.Text;
                dao.UpdateUser(nameTextBox.Text, surameTextBox.Text, postTextBox.Text, currentUser.Id);
                logDAO.addNotation(user, "Отредактирован профиль " + currentUser.Login);
                parentForm.PanelForm(new UserInformationForm(currentUser, parentForm,user));

            }
            else
            {
                errorLbl.Text = "Заполните поля: имя, фамилия";
            }

        }

        private void editUserForm_Resize(object sender, EventArgs e)
        {
           
                editUserPanel.Location = new Point(((this.Width - editUserPanel.Width) / 2) - 8,
                   ((this.Height - editUserPanel.Height) / 2) - 19);

            
        }
    }
}
