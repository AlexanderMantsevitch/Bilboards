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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    public partial class DevicesListForm : Form
    {

       
        private DeviceDataAccesObject dao = new DeviceDataAccesObject();
        private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        private AdminInterface parentForm;
        private User user;
        public DevicesListForm(AdminInterface parentForm, User user)
        
        {
            InitializeComponent();
          
            this.parentForm = parentForm;
            this.user = user;
            try
            {
               
                this.devicesListGrid.DataSource = dao.selectDataDevice();

                devicesListGrid.Update();

            }
            catch (MySqlException )
            {
                MessageBox.Show("Нет соединения с базой данных");
            }


        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            parentForm.PanelForm(new AddDeviceForm(user));

        }

        private void removeDeviceButton_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить выбранное устройство?", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    logDAO.addNotation(user, "Устройство " + devicesListGrid.CurrentRow.Cells["name"].Value + " было удалено");
                    dao.deleteRows("devices", Convert.ToInt32(devicesListGrid.CurrentRow.Cells[0].Value));
                    devicesListGrid.DataSource = dao.selectDataDevice();
                    devicesListGrid.Update();

                }


            }
            catch (MySqlException)
            {
                MessageBox.Show(" Нет соединения с базой данных");

            }
        }

        private void chooseDeviceButton_Click(object sender, EventArgs e)
        {

            Console.WriteLine(devicesListGrid.CurrentRow.Cells[0].Value);
            Device device = new Device(dao.selectDataDevice(Convert.ToInt32(devicesListGrid.CurrentRow.Cells[0].Value)).Rows[0]);
            parentForm.PanelForm(new DevicesInformation(device));
        }
    }
}
