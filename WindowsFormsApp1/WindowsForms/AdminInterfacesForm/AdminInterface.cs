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
    public partial class AdminInterface : Form
    {
        private User user = new User();
        private Form activeForm;
        private const int countButton = 3;
        Button[] arrayButton = new Button[countButton];
        public AdminInterface()
        {
            InitializeComponent();
           
            arrayButton[0] = usersListButton;
            arrayButton[1] = devicesListButton;
            arrayButton[2] = viewingLogsButton;
           
        }

       

        private void AdminInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void set_User (User user_loginForm)
        {
            this.user = user_loginForm;
            UserNameLabel.Text = user.get_nameUser();
            UserSurnameLabel.Text = user.get_surnameUser();
           
           
        }

        private void usersListButton_Click(object sender, EventArgs e)
        {
           
        
            this.PanelForm(new UsersList(this));
            usersListButton.BackColor = Color.FromArgb(215,215,215);
        }

        public void PanelForm (Form form)
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
            this.adminInterfacePanel.Controls.Add(form);
            this.adminInterfacePanel.Tag = form;
            form.BringToFront();
            form.Show();

        }
        
    }
}
