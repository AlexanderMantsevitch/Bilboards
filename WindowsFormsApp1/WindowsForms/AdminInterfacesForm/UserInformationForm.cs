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
    public partial class UserInformationForm : Form
    {
        private DataAccesObject dao = new DataAccesObject();
        private AdminInterface parentForm;
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

            DataTable dataTable = new DataTable();
            dataTable = dao.select("devices", "*");


            foreach (DataRow dataRow in dataTable.Rows)
            {
                chooseDeviceComboBox.Items.Add(dataRow["name"].ToString());
               
            }


        }

        private void addDeviceUser_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {

                dao.addDevice("Bilboard#" + i);

            }
        }


    }
}
