using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.WindowsForms.LoginForm
{
    public partial class NewPassword : Form
    {
        int id;
        private Form parentForm;
        public NewPassword(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

       public void set_id (int id)
        {
            this.id = id;

        }

        private void NewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
