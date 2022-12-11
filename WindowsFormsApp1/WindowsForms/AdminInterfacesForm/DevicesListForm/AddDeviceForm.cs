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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesListForm
{
    public partial class AddDeviceForm : Form
    {

        Device device = new Device();
        UsersList userDAO = new UsersList();
        LogsDataAccesObject logDAO = new LogsDataAccesObject();
        User user;

        public AddDeviceForm(User user)
        {
            InitializeComponent();

            this.user = user;
            
            typeComboBox.Items.Add("Bilboard");
            typeComboBox.Items.Add("TV");
            DataTable dataTable = new DataTable();
           
            dataTable = userDAO.select();
            errorLbl.Text = "";

            foreach (DataRow dataRow in dataTable.Rows)
            {
                usersComboBox.Items.Add(dataRow["login"].ToString());

            }
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            if (!(typeComboBox.Text.Equals("") || nameTextBox.Text.Equals("")))
            {
                try
                {
                    
                    if (!usersComboBox.Text.Equals(""))
                    {
                        User user = new User(userDAO.selectDataUser(usersComboBox.Text));
                        device.addDevice(nameTextBox.Text, typeComboBox.Text, user.Id);
                    }
                    else
                    {
                        device.addDevice(nameTextBox.Text, typeComboBox.Text, 0);

                    }
                    logDAO.addNotation(user, "Устройство " + nameTextBox.Text + " было добавлено");
                    MessageBox.Show("Устройство успешно добавлено");
                    typeComboBox.Text = ""; nameTextBox.Text = ""; usersComboBox.Text = "";
                }
                catch (AddException) { errorLbl.Text = "Устройство с таким названием уже существует"; }
            }
            else errorLbl.Text = "Заполните поля: название и тип";

        }

        private void AddDeviceForm_Resize(object sender, EventArgs e)
        {
            
                panelAddDevice.Location = new Point(((this.Width - panelAddDevice.Width) / 2) - 8,
                   ((this.Height - panelAddDevice.Height) / 2) - 19);

            
        }
    }
}
