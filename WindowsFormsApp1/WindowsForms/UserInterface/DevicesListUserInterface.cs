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

namespace WindowsFormsApp1.WindowsForms.UserInterface
{
    public partial class DevicesListUserInterface : Form
    {
        private User user;
        private DeviceList devicesList = new DeviceList();
        private UserInterfaceForm parentForm;
        public DevicesListUserInterface(UserInterfaceForm parentForm , User user)
        {
            InitializeComponent();
            this.user = user;
            this.parentForm = parentForm;
            
            devicesListGrid.DataSource = devicesList.selectAvailableDevicesFromUser(user.Id);
            devicesListGrid.Update();
            DataTable dataTable = new DataTable();
            dataTable = devicesList.select();

        }

        private void chooseDeviceButton_Click(object sender, EventArgs e)
        {
            
           
            Device device = new Device(devicesList.selectDevice(devicesListGrid.CurrentRow.Cells[0].Value.ToString()));
            parentForm.PanelForm(new DevicesInformationUserInterface(device));
        }
    }
}
