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
using WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList;

namespace WindowsFormsApp1
{
    public partial class AdminInterface : Form
    {
        private User user;
        private Form activeForm;
        private const int countButton = 3;
        Button[] arrayButton = new Button[countButton];
        private Form parentForm = new Form();
        private bool logOutFlag = false; 
        UserDataAccesObject userDAO = new UserDataAccesObject();
        

        public AdminInterface(Form parentForm, User user)
        {
            InitializeComponent();

            updateStats();
            arrayButton[0] = usersListButton;
            arrayButton[1] = devicesListButton;
            arrayButton[2] = viewingLogsButton;
            this.parentForm = parentForm;
            this.user = user;
            UserNameLabel.Text = user.Name;
            UserSurnameLabel.Text = user.Surname;
            

        }

       

       


        private void usersListButton_Click(object sender, EventArgs e)
        {
           
        
            this.PanelForm(new UsersList(this, user));
            usersListButton.BackColor = Color.FromArgb(215,215,215);
            updateStats();
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logOutFlag = true;
            userDAO.upDateStatus(user.Id, "offline");
            parentForm.Show();
            this.Close();

        }

        private void devicesListButton_Click(object sender, EventArgs e)
        {
            this.PanelForm(new DevicesListForm(this, user));
            devicesListButton.BackColor = Color.FromArgb(215, 215, 215);
            updateStats();
        }

        private void viewingLogsButton_Click(object sender, EventArgs e)
        {
            this.PanelForm(new LogsForm(user));
            viewingLogsButton.BackColor = Color.FromArgb(215, 215, 215);
            updateStats();
        }

        private void updateStats ()

        {
            
           
                
                onlineUsersLabel.Text = "Пользователей online:" + userDAO.select("users", "status", "online").Rows.Count;
                workDeviceLabel.Text = "Работающих устройств:" + userDAO.select("devices", "status", "on").Rows.Count;
               
            

        }

        private void updateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateStats();
        }

        private void AdminInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logOutFlag) Application.Exit();
        }
    }
}
