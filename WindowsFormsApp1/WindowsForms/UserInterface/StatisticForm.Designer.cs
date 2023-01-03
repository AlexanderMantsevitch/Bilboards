namespace WindowsFormsApp1.WindowsForms.UserInterface
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VideostatisticGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.myVideoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VideostatisticGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideostatisticGrid
            // 
            this.VideostatisticGrid.AllowUserToAddRows = false;
            this.VideostatisticGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.VideostatisticGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VideostatisticGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VideostatisticGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.VideostatisticGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VideostatisticGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideostatisticGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideostatisticGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.VideostatisticGrid.Location = new System.Drawing.Point(0, 0);
            this.VideostatisticGrid.MinimumSize = new System.Drawing.Size(495, 270);
            this.VideostatisticGrid.Name = "VideostatisticGrid";
            this.VideostatisticGrid.ReadOnly = true;
            this.VideostatisticGrid.RowHeadersWidth = 40;
            this.VideostatisticGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VideostatisticGrid.Size = new System.Drawing.Size(800, 368);
            this.VideostatisticGrid.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 368);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 82);
            this.panel5.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DateButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.fromDateTimePicker);
            this.panel3.Controls.Add(this.myVideoButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 41);
            this.panel3.TabIndex = 3;
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(113, 12);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(75, 23);
            this.DateButton.TabIndex = 13;
            this.DateButton.Text = "Применить";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выбрать дату";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Checked = false;
            this.fromDateTimePicker.Location = new System.Drawing.Point(197, 15);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.fromDateTimePicker.TabIndex = 11;
            // 
            // myVideoButton
            // 
            this.myVideoButton.Location = new System.Drawing.Point(381, 12);
            this.myVideoButton.Name = "myVideoButton";
            this.myVideoButton.Size = new System.Drawing.Size(180, 23);
            this.myVideoButton.TabIndex = 2;
            this.myVideoButton.Text = "Мои видео";
            this.myVideoButton.UseVisualStyleBackColor = true;
            this.myVideoButton.Click += new System.EventHandler(this.myVideoButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 39);
            this.panel2.TabIndex = 2;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VideostatisticGrid);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)(this.VideostatisticGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VideostatisticGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button myVideoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
    }
}