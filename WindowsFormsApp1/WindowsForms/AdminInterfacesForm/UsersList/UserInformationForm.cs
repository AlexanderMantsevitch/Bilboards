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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    public partial class UserInformationForm : Form
    {
        private UserDataAccesObject userDAO = new UserDataAccesObject();
        private DeviceDataAccesObject deviceDAO = new DeviceDataAccesObject();
        private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        private AdminInterface parentForm;
        private User currentUser;
        private User user;

        public UserInformationForm(User currentUser, AdminInterface parentForm, User user)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            formName.Text = "Пользователь: " + currentUser.Login;
            idLabel.Text = "Id: " + currentUser.Id;
            namUserLabel.Text = "Имя: " + currentUser.Name;
            surnameLabel.Text = "Фамилия: " + currentUser.Surname;
            roleLabel.Text = "Роль в системе: " + currentUser.Role;
            postLabel.Text = "Должность: " + currentUser.Post;

            this.user = user;
            devicesListGried.DataSource = deviceDAO.selectAvailableDevices(currentUser.Id);
            devicesListGried.Update();
            this.currentUser = currentUser;
            chooseDeviceComboBox.Items.Clear();
            DataTable dataTable = new DataTable();
            dataTable = deviceDAO.select("devices", "*");


            foreach (DataRow dataRow in dataTable.Rows)
            {
                chooseDeviceComboBox.Items.Add(dataRow["name"].ToString());
               
            }


        }

        private void addDeviceUser_Click(object sender, EventArgs e)
        {
           
            if (!chooseDeviceComboBox.Text.Equals("Выберите устройство"))
            {
                DataTable dataTable = new DataTable();
                dataTable = deviceDAO.selectDataDevice(chooseDeviceComboBox.Text);
                Device device = new Device(dataTable.Rows[0]);
                
                if (device.Owner_id == 0)
                {
                    
                    deviceDAO.addDeviceToUser(chooseDeviceComboBox.Text, currentUser.Id);
                    devicesListGried.DataSource = deviceDAO.selectAvailableDevices(currentUser.Id);
                    devicesListGried.Update();
                    logDAO.addNotation(user, "Пользователю " + currentUser.Login + " назначено устройство " + device.Name);

                }
                else
                {

                    
                    DialogResult dialogResult = MessageBox.Show("Вы хотите поменять владельца " +
                        new User(userDAO.selectDataUser(device.Owner_id).Rows[0]).Login + " на " + currentUser.Login, " " , MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deviceDAO.addDeviceToUser(chooseDeviceComboBox.Text, currentUser.Id);
                        devicesListGried.DataSource = deviceDAO.selectAvailableDevices(currentUser.Id);
                        devicesListGried.Update();
                        logDAO.addNotation(user, "Пользователю " + currentUser.Login + " назначено устройство " + device.Name);
                    }
                    

                }

            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить выбранного пользователя?", " ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                deviceDAO.updateCell("devices", "owner_id", 0, currentUser.Id);
                deviceDAO.deleteRows("users", currentUser.Id);
                logDAO.addNotation(user, "Пользователь " + currentUser.Login + " был удален");
                parentForm.PanelForm(new UsersList(parentForm,user));


            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            parentForm.PanelForm(new editUserForm(currentUser, parentForm, user));
        }
    }
}
