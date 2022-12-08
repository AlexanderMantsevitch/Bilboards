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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    public partial class AddDeviceForm : Form
    {
       
        DeviceDataAccesObject deviceDAO = new DeviceDataAccesObject();
        UserDataAccesObject userDAO = new UserDataAccesObject();
        LogsDataAccesObject logDAO = new LogsDataAccesObject();
        User user;

        public AddDeviceForm(User user)
        {
            InitializeComponent();

            this.user = user;
            
            typeComboBox.Items.Add("Bilboard");
            typeComboBox.Items.Add("TV");
            DataTable dataTable = new DataTable();
           
            dataTable = userDAO.select("users", "login");
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
                if (deviceDAO.selectDataDevice(nameTextBox.Text).Rows.Count == 0)
                {
                    Console.WriteLine(deviceDAO.selectDataDevice(typeComboBox.Text).Rows.Count);
                    if (!usersComboBox.Text.Equals(""))
                    {
                        User user = new User(userDAO.selectDataUser(usersComboBox.Text).Rows[0]);
                        deviceDAO.addDevice(nameTextBox.Text, typeComboBox.Text, user.Id);
                    }
                    else
                    {
                        deviceDAO.addDevice(nameTextBox.Text, typeComboBox.Text, 0);

                    }
                    logDAO.addNotation(user, "Устройство " + nameTextBox.Text + " было добавлено");
                    MessageBox.Show("Устройство успешно добавлено");
                    typeComboBox.Text = ""; nameTextBox.Text = ""; usersComboBox.Text = ""; 
                }
                else errorLbl.Text = "Устройство с таким названием уже существует";
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
