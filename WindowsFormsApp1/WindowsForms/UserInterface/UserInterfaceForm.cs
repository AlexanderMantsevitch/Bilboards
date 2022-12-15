using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.Exception;

namespace WindowsFormsApp1.WindowsForms
{
    public partial class UserInterfaceForm : Form
    {
        private User user;
        private Form activeForm;
        private const int countButton = 3;
        private Button[] arrayButton = new Button[countButton];
        private Form parentForm;
        bool flagLogout = false;
        UserDataAccesObject userDAO = new UserDataAccesObject();


        public UserInterfaceForm(User user, Form parentForm)
        {
            InitializeComponent();
            this.user = user;
            this.parentForm = parentForm;
            UserSurnameLabel.Text = user.Surname;
            UserNameLabel.Text = user.Name;


            arrayButton[0] = devicesListButton;
            arrayButton[1] = statsButton;
            arrayButton[2] = exportVideoButton;

        }


        public void PanelForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            for (int i = 0; i < countButton; i++)
            {

                arrayButton[i].BackColor = SystemColors.Control;

            }
            activeForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.userInterfacePanel.Controls.Add(form);
            this.userInterfacePanel.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void devicesListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = "Лист Excel (*.xlsx)|*.xlsx";
          

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                Schedule schedule = new Schedule();
                schedule.downloadSchedule(saveFileDialog.FileName);
               
                

            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            flagLogout = true;
            userDAO.upDateStatus(user.Id, "offline");
            parentForm.Show();
            this.Close();
        }

        private void UserInterfaceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flagLogout)
            {
                userDAO.upDateStatus(user.Id, "offline");
                Application.Exit();

            }
        }

        private void exportVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 (*.mp4)|*.mp4";
            try
            {
                


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Videotape video = new Videotape();
                    video.createNewVideo(filePath);


                }
            }
            catch (AddException)
            {
                DialogResult dialogResult = MessageBox.Show("Файл с таким именем уже существует. Вы хотите его заменить?", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    try
                    {
                        Videotape.deleteVideo(Path.GetFileName(openFileDialog.FileName));
                        Videotape video = new Videotape();
                        video.createNewVideo(openFileDialog.FileName);
                    }
                    catch (System.IO.IOException)
                    {

                        MessageBox.Show("Вы не можете загрузить этот файл");

                    }
                }

            }
        }
    }
}
