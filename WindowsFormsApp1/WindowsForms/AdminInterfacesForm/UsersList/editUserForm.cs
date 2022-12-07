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
    public partial class editUserForm : Form
    {
        AdminInterface parentForm;
        private User user = new User(); 
        public editUserForm(User user, AdminInterface parentForm)
        {
            InitializeComponent();
            this.user = user;
            this.parentForm = parentForm;
            errorLbl.Text = "";
            loginTextBox.Text = user.Login;
            loginTextBox.Enabled = false;
            nameTextBox.Text = user.Name;
            surameTextBox.Text = user.Surname;
            postTextBox.Text = user.Post;
            editUserPanel.Location = new Point(((this.Width - editUserPanel.Width) / 2) - 8,
                   ((this.Height - editUserPanel.Height) / 2) - 19);

        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            if (!(surameTextBox.Text.Equals("") || nameTextBox.Text.Equals("")))
            {
                DataAccesObject dao = new DataAccesObject();
                user.Name = nameTextBox.Text;
                user.Surname = surameTextBox.Text;
                user.Post = postTextBox.Text;
                dao.UpdateUser(nameTextBox.Text, surameTextBox.Text, postTextBox.Text, user.Id);
                parentForm.PanelForm(new UserInformationForm(user, parentForm));
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
