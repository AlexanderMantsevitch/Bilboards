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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            errorLbl.Text = "";
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
                if (!(surameTextBox.Text.Equals("") || nameTextBox.Text.Equals("") || loginTextBox.Text.Equals("")))
                 {
                    errorLbl.Text = "";
                    DataAccesObject dao = new DataAccesObject();
                    dao.addUsers(nameTextBox.Text, surameTextBox.Text, loginTextBox.Text, postTextBox.Text);
                    MessageBox.Show("Пользователь успешно добавлен");
                    nameTextBox.Text = ""; surameTextBox.Text = ""; loginTextBox.Text = ""; postTextBox.Text = "";
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
