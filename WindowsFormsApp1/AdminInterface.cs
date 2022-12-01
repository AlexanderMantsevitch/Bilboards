﻿using System;
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
        public AdminInterface()
        {
            InitializeComponent();
           
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
            this.Hide();
            UsersList usersList = new UsersList();
            usersList.set_User(user);
            usersList.Show();
        }
    }
}