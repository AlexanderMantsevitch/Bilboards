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

namespace WindowsFormsApp1.WindowsForms
{
    public partial class UserInterfaceForm : Form
    {
        private User user;
        private Form activeForm;
        private const int countButton = 3;
        private Button[] arrayButton = new Button[countButton];
        private Form parentForm;
        bool flagLogout = false;
        UserDataAccesObject userDAO = new UserDataAccesObject();


        public UserInterfaceForm(User user, Form parentForm)
        {
            InitializeComponent();
            this.user = user;
            this.parentForm = parentForm;
            UserSurnameLabel.Text = user.Surname;
            UserNameLabel.Text = user.Name;


            arrayButton[0] = devicesListButton;
            arrayButton[1] = statsButton;
            arrayButton[2] = exportVideoButton;

        }


        public void PanelForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            for (int i = 0; i < countButton; i++)
            {

                arrayButton[i].BackColor = SystemColors.Control;

            }
            activeForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.userInterfacePanel.Controls.Add(form);
            this.userInterfacePanel.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void devicesListButton_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            userDAO.upDateStatus(user.Id, "offline");
            parentForm.Show();
            this.Close();
        }
    }
}
