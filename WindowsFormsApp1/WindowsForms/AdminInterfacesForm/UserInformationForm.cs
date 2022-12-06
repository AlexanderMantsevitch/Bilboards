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
        private DataAccesObject dao = new DataAccesObject();
        private AdminInterface parentForm;
        private User user;
        public UserInformationForm(User user, AdminInterface parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            formName.Text = "Пользователь: " + user.Login;
            idLabel.Text = "Id: " + user.Id;
            namUserLabel.Text = "Имя: " + user.Name;
            surnameLabel.Text = "Фамилия: " + user.Surname;
            roleLabel.Text = "Роль в системе: " + user.Role;
            postLabel.Text = "Должность: " + user.Post;

            devicesListGried.DataSource = dao.selectAvailableDevices(user.Id);
            devicesListGried.Update();
            this.user = user;
            chooseDeviceComboBox.Items.Clear();
            DataTable dataTable = new DataTable();
            dataTable = dao.select("devices", "*");


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
                dataTable = dao.selectDataDevice(chooseDeviceComboBox.Text);
                Device device = new Device(dataTable.Rows[0]);
                
                if (device.Owner_id == 0)
                {
                    
                    dao.addDeviceToUser(chooseDeviceComboBox.Text, user.Id);
                    devicesListGried.DataSource = dao.selectAvailableDevices(user.Id);
                    devicesListGried.Update();

                }
                else
                {

                    
                    DialogResult dialogResult = MessageBox.Show("Вы хотите поменять владельца " +
                        new User(dao.selectDataUser(device.Owner_id).Rows[0]).Login + " на " + user.Login, " " , MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dao.addDeviceToUser(chooseDeviceComboBox.Text, user.Id);
                        devicesListGried.DataSource = dao.selectAvailableDevices(user.Id);
                        devicesListGried.Update();
                    }
                    

                }

            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить выбранного пользователя?", " ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                dao.deleteUserinDevices("devices", "owner_id", 0, user.Id);
                dao.deleteRows("users", user.Id);
                parentForm.PanelForm(new UsersList(parentForm));

            }
        }
    }
}
