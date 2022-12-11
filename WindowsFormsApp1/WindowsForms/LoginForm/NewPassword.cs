using MySql.Data.MySqlClient;
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

namespace WindowsFormsApp1.WindowsForms.LoginForm
{
    public partial class NewPassword : Form
    {
        
        private Login parentForm;
        private User user;
        public NewPassword(Login parentForm, User user)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
            errorAuthorizathionLbl.Text = "";
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
                   
                    user.changePassword(user.Id, PasswordtextBox.Text);
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
