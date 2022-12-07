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

        public AddDeviceForm()
        {
            InitializeComponent();

            
            typeComboBox.Items.Add("Bilboard");
            typeComboBox.Items.Add("TV");
            DataTable dataTable = new DataTable();
           
            dataTable = userDAO.select("users", "login");


            foreach (DataRow dataRow in dataTable.Rows)
            {
                usersComboBox.Items.Add(dataRow["login"].ToString());

            }
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            if (!(typeComboBox.Text.Equals("") || nameTextBox.Text.Equals("")))
            {
                if (deviceDAO.selectDataDevice(typeComboBox.Text).Rows.Count == 0)
                {
                    User user = new User(userDAO.selectDataUser(usersComboBox.Text).Rows[0]);
                    deviceDAO.addDevice(nameTextBox.Text, typeComboBox.Text, user.Id);
                }
                else errorLbl.Text = "Устройство с таким названием уже существует";
            }
            else errorLbl.Text = "Заполните поля: название и тип";

        }
    }
}
