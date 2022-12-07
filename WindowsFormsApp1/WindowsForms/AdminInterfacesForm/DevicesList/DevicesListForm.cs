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

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    public partial class DevicesListForm : Form
    {

       
        DataAccesObject dao = new DataAccesObject();
        AdminInterface parentForm;
        public DevicesListForm(AdminInterface parentForm)
        
        {
            InitializeComponent();
            this.parentForm = parentForm;
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

        }
    }
}
