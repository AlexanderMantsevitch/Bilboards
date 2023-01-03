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


        }

        private void chooseDeviceButton_Click(object sender, EventArgs e)
        {
            
           
            Device device = new Device(devicesList.selectDevice(devicesListGrid.CurrentRow.Cells[0].Value.ToString()));
            parentForm.PanelForm(new DevicesInformationUserInterface(device, user));
        }

        private void onDeviceButton_Click(object sender, EventArgs e)
        {
            if (devicesList.selectDevice(devicesListGrid.CurrentRow.Cells[0].Value.ToString()).Status.Equals("off"))
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
                devicesListGrid.DataSource = devicesList.selectAvailableDevicesFromUser(user.Id);
                devicesListGrid.Update();

            }
        }

        private void upDateButton_Click(object sender, EventArgs e)
        {
            devicesListGrid.DataSource = devicesList.selectAvailableDevicesFromUser(user.Id);
            devicesListGrid.Update();
        }

        private void DevicesListUserInterface_Load(object sender, EventArgs e)
        {
            Thread checkChanges = new Thread(() =>

            {

                Action action = () =>
                {
                    try
                    {

                        while (true)
                        {
                            Thread.Sleep(60000);

                            DataTable newdata = new DataTable();
                            newdata = devicesList.selectAvailableDevicesFromUser(user.Id);
                            int n = 0;
                            if (newdata.Rows.Count < devicesListGrid.Rows.Count) n = newdata.Rows.Count;
                            else n = devicesListGrid.Rows.Count;
                            for (int i = 0; i < n; i++)
                            {

                                if (newdata.Rows[i]["status"].ToString().Equals(devicesListGrid.Rows[i].Cells[2].Value.ToString()))
                                {

                                    devicesList.selectDevice(devicesListGrid.Rows[i].Cells["name"].Value.ToString()).upDateStatus("off");

                                }

                            }

                            devicesListGrid.Invoke(new Action(() => { devicesListGrid.DataSource = newdata; devicesListGrid.Update(); }));

                        }
                    }
                    catch
                    {
                        Thread.CurrentThread.Abort();

                    }
                };

                action();
            }


             );
            checkChanges.Start();
        }
    }
}
