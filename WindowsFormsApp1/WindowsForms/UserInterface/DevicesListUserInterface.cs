using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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


            DataTable data = new DataTable();
            data = devicesList.select();
            Thread chechChanges = new Thread(() =>

            {
                
                Action action = () =>
                {
                    Thread.Sleep(5000);

                    DataTable newdata = new DataTable();
                    data = devicesList.select();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {

                        if (!data.Rows[i]["status"].ToString().Equals(devicesListGrid.Rows[i].Cells["status"].Value.ToString()))
                        {
                            devicesList.selectDevice(devicesListGrid.Rows[i].Cells["name"].Value.ToString()).upDateStatus("off");

                        }

                    }

                };
               

            }


              );
            chechChanges.Start();


        }

        private void chooseDeviceButton_Click(object sender, EventArgs e)
        {
            
           
            Device device = new Device(devicesList.selectDevice(devicesListGrid.CurrentRow.Cells[0].Value.ToString()));
            parentForm.PanelForm(new DevicesInformationUserInterface(device, user));
        }

        private void onDeviceButton_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() =>

           {
               Action actionCreate = () =>
               {

                   TranslationsForm translationsForm = new TranslationsForm(devicesList.selectDevice(devicesListGrid.CurrentRow.Cells[0].Value.ToString()).Id);
                   Application.Run(translationsForm);
                   

               };
               actionCreate();

           }
            );
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            
        }

        private void upDateButton_Click(object sender, EventArgs e)
        {
            devicesListGrid.DataSource = devicesList.selectAvailableDevicesFromUser(user.Id);
            devicesListGrid.Update();
        }
    }
}
