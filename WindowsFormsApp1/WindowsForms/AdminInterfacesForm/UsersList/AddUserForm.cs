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
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    public partial class AddUserForm : Form
    {
        User user;
        LogsDataAccesObject logDAO = new LogsDataAccesObject();
        public AddUserForm( User user)
        {
            InitializeComponent();
            errorLbl.Text = "";
            this.user = user;
        }

       
        private void panelForm_Resize(object sender, EventArgs e)
        {
            panelAddUser.Location = new Point(((this.Width - panelAddUser.Width) / 2) - 8,
               ((this.Height - panelAddUser.Height) / 2) - 19);

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User();
                if (!(surameTextBox.Text.Equals("") || nameTextBox.Text.Equals("") || loginTextBox.Text.Equals("")))
                 {
                    try
                    {
                        errorLbl.Text = "";

                        newUser.addUser(nameTextBox.Text, surameTextBox.Text, loginTextBox.Text, postTextBox.Text);
                        logDAO.addNotation(user, "Пользователь " + loginTextBox.Text + " был добавлен");
                        MessageBox.Show("Пользователь успешно добавлен");
                        nameTextBox.Text = ""; surameTextBox.Text = ""; loginTextBox.Text = ""; postTextBox.Text = "";
                    }

                    catch (AddException) { errorLbl.Text = "Пользователь с таким логином уже существует"; }
                }
                else
                {
                    errorLbl.Text = "Заполните поля: имя, фамилия, login";

                }
            }
            catch (MySqlException)
            {

                MessageBox.Show("Нет соединения с базой данных");

            }
        }
    }
}
