using System.Windows.Forms;

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    partial class DevicesInformation:Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.translationPictureBox = new System.Windows.Forms.PictureBox();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.scheduleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scheduleLinkLabel);
            this.panel1.Controls.Add(this.scheduleLabel);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.ownerLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.deviceNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 450);
            this.panel1.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(21, 140);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 19);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Статус: status";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(21, 111);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(69, 19);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Тип: type";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.Location = new System.Drawing.Point(21, 82);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(112, 19);
            this.ownerLabel.TabIndex = 2;
            this.ownerLabel.Text = "Владелец: user";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(21, 52);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(41, 19);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Id: id";
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.AutoSize = true;
            this.deviceNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceNameLabel.Location = new System.Drawing.Point(21, 9);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(203, 23);
            this.deviceNameLabel.TabIndex = 0;
            this.deviceNameLabel.Text = "Устройство: DeviceName";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 32);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(268, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 216);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(628, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 202);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.translationPictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(268, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 202);
            this.panel5.TabIndex = 4;
            // 
            // translationPictureBox
            // 
            this.translationPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.translationPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("translationPictureBox.Image")));
            this.translationPictureBox.Location = new System.Drawing.Point(0, 0);
            this.translationPictureBox.Name = "translationPictureBox";
            this.translationPictureBox.Size = new System.Drawing.Size(291, 202);
            this.translationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.translationPictureBox.TabIndex = 0;
            this.translationPictureBox.TabStop = false;
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleLabel.Location = new System.Drawing.Point(21, 169);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(155, 19);
            this.scheduleLabel.TabIndex = 5;
            this.scheduleLabel.Text = "Текущее расписание:";
            // 
            // scheduleLinkLabel
            // 
            this.scheduleLinkLabel.AutoSize = true;
            this.scheduleLinkLabel.Location = new System.Drawing.Point(182, 173);
            this.scheduleLinkLabel.Name = "scheduleLinkLabel";
            this.scheduleLinkLabel.Size = new System.Drawing.Size(78, 13);
            this.scheduleLinkLabel.TabIndex = 6;
            this.scheduleLinkLabel.TabStop = true;
            this.scheduleLinkLabel.Text = "nameSchedule";
            this.scheduleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.scheduleLinkLabel_LinkClicked);
            // 
            // DevicesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevicesInformation";
            this.Text = "DevicesInformation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.translationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label deviceNameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox translationPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private LinkLabel scheduleLinkLabel;
        private Label scheduleLabel;
    }
}