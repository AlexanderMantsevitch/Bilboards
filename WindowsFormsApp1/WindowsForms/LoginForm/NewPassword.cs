﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.WindowsForms.LoginForm
{
    public partial class NewPassword : Form
    {
        int id;
        private Login parentForm;
        public NewPassword(Login parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            errorAuthorizathionLbl.Text = "";
        }

       public void set_id (int id)
        {
            this.id = id;

        }

        private void NewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

     

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            bool rulePassword = true;
            for (int i = 0; i < PasswordtextBox.Text.Length && rulePassword; i++ )
            {
                if (!((int)PasswordtextBox.Text[i] < 127 && (int)PasswordtextBox.Text[i] > 0)) rulePassword = false;

            }

            if (rulePassword)
            {
                if (PasswordtextBox.Text.Equals(dublicatePasswordTextBox.Text)) 
                {
                    DataAccesObject dao = new DataAccesObject();
                    dao.changePassword(PasswordtextBox.Text, id);
                    parentForm.clear_textBox();
                    parentForm.Show();
                    parentForm.SignIn();
                    this.Close();
                }
            else
            {
                    errorAuthorizathionLbl.Text = "Введенные пароли не совпадают";

            }
            }
            else
            {
                errorAuthorizathionLbl.Text = "Введенный пароль содержит \nнедопустимые символы";
            }

        }
    }
}