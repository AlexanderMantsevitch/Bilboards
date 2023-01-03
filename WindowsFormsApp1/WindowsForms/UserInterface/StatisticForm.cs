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
    public partial class StatisticForm : Form
    {
        private bool flagMyVideoButton = false;
       
        private User user = new User();
        public StatisticForm(User user)
        {
            InitializeComponent();
            this.user = user;
            VideoTapeList videoTapeList = new VideoTapeList();
            VideostatisticGrid.DataSource = videoTapeList.selectStatistic();
            VideostatisticGrid.Update();
        }

        private void myVideoButton_Click(object sender, EventArgs e)
        {
            VideoTapeList videoTapeList = new VideoTapeList();

            if (!myVideoButton.Text.Equals("Сбросить фильтр"))
            {
                if (flagMyVideoButton)
                {
                    myVideoButton.Text = "Мои видео";

                    VideostatisticGrid.DataSource = videoTapeList.selectStatistic();
                    VideostatisticGrid.Update();
                    flagMyVideoButton = false;

                }
                else
                {
                    myVideoButton.Text = "Все видео";
                    VideostatisticGrid.DataSource = videoTapeList.selectUserStatistic(user.Id);
                    VideostatisticGrid.Update();
                    flagMyVideoButton = true;


                }
            }
            else
            {
                if (flagMyVideoButton)
                {
                    myVideoButton.Text = "Мои видео";

                    VideostatisticGrid.DataSource = videoTapeList.selectStatistic();
                    VideostatisticGrid.Update();
                   

                }
                else
                {
                    myVideoButton.Text = "Все видео";
                    VideostatisticGrid.DataSource = videoTapeList.selectUserStatistic(user.Id);
                    VideostatisticGrid.Update();
                   


                }


            }
        }

        private void DateButton_Click(object sender, EventArgs e)
        {
            VideoTapeList videoTapeList = new VideoTapeList();
            if (flagMyVideoButton)
            {
                myVideoButton.Text = "Сбросить фильтр";

                VideostatisticGrid.DataSource = videoTapeList.selectStatistic(fromDateTimePicker.Value);
                VideostatisticGrid.Update();
                
               

            }
            else
            {
                myVideoButton.Text = "Сбросить фильтр";
                VideostatisticGrid.DataSource = videoTapeList.selectUserStatistic(user.Id, fromDateTimePicker.Value);
                VideostatisticGrid.Update();
              


            }


        }
    }
}
