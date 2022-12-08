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
    public partial class LogsForm : Form
    {
       private User user;
       private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        private UserDataAccesObject userDAO = new UserDataAccesObject(); 
        private bool defaultDateFlag = true;
        public LogsForm(User user)
        {
            InitializeComponent();
            this.user = user;


            resetLabel.Text = "";
            logsListGrid.DataSource = logDAO.selectLogs(); ;
            logsListGrid.Update();


            DataTable dataTable = new DataTable();
            dataTable = userDAO.selectDataUsers();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                userComboBox.Items.Add(dataRow["login"].ToString());

            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
           
            
            if ( defaultDateFlag || !(userComboBox.Text.Equals ("")))
            {


                if (defaultDateFlag) 
                {
                    if (userComboBox.Text.Equals("")) logsListGrid.DataSource = logDAO.filterLogs(fromDateTimePicker.Value, toDateTimePicker.Value);
                    else logsListGrid.DataSource = logDAO.filterLogs(fromDateTimePicker.Value, toDateTimePicker.Value, userComboBox.Text);
                }
                else logsListGrid.DataSource = logDAO.filterLogs(userComboBox.Text);
                logsListGrid.Update();

            }
        }

        private void fromDateTimePicker_MouseUp(object sender, MouseEventArgs e)
        {
            defaultDateFlag = true;
            resetLabel.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            defaultDateFlag = false;
            resetLabel.Text = "Фильтр сброшен";
            fromDateTimePicker.Value = DateTime.Now;
            toDateTimePicker.Value = DateTime.Now;
        }
    }
}
