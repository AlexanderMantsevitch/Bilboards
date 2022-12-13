using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    public partial class LogsForm : Form
    {
       private User user;
       private LogsDataAccesObject logDAO = new LogsDataAccesObject();
        private UsersList usersList = new UsersList();
        private DataTable dataTableLogs;
        private bool defaultDateFlag = true;
        public LogsForm(User user)
        {
            InitializeComponent();
            this.user = user;


            resetLabel.Text = "";
            dataTableLogs = logDAO.selectLogs();
            logsListGrid.DataSource = dataTableLogs;
            logsListGrid.Update();


            DataTable dataTable = new DataTable();
            dataTable = usersList.select();

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
                    if (userComboBox.Text.Equals("")) dataTableLogs = logDAO.filterLogs(fromDateTimePicker.Value, toDateTimePicker.Value);
                    else  dataTableLogs= logDAO.filterLogs(fromDateTimePicker.Value, toDateTimePicker.Value, userComboBox.Text);
                }
                else dataTableLogs = logDAO.filterLogs(userComboBox.Text);
                logsListGrid.DataSource = dataTableLogs;
                logsListGrid.Update();

            }
            else
            {
                logDAO.selectLogs();
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

        private void saveExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Лист Excel (*.xlsx)|*.xlsx";
            saveFileDialog.DefaultExt = "xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
              
                ConvertToExcel convert = new ConvertToExcel();
                    convert.ConvertDataTable(dataTableLogs, fileName);

            }
        }
    }
}
