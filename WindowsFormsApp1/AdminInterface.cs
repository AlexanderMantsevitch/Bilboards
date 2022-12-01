using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }

        private void AdminInterface_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
