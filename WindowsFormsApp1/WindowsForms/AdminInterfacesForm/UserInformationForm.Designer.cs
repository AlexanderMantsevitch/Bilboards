﻿namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    partial class UserInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formName = new System.Windows.Forms.Label();
            this.namUserLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.devicesListGried = new System.Windows.Forms.DataGridView();
            this.availableDevicesLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addDeviceUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chooseDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesListGried)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // formName
            // 
            this.formName.Dock = System.Windows.Forms.DockStyle.Top;
            this.formName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formName.Location = new System.Drawing.Point(0, 0);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(500, 33);
            this.formName.TabIndex = 0;
            this.formName.Text = "Пользователь: NickName";
            this.formName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // namUserLabel
            // 
            this.namUserLabel.AutoSize = true;
            this.namUserLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namUserLabel.Location = new System.Drawing.Point(156, 82);
            this.namUserLabel.Name = "namUserLabel";
            this.namUserLabel.Size = new System.Drawing.Size(84, 19);
            this.namUserLabel.TabIndex = 1;
            this.namUserLabel.Text = "Имя: Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(156, 106);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(137, 19);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Фамилия: Surname";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postLabel.Location = new System.Drawing.Point(156, 132);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(120, 19);
            this.postLabel.TabIndex = 3;
            this.postLabel.Text = "Должность: post";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.Location = new System.Drawing.Point(156, 157);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(150, 19);
            this.roleLabel.TabIndex = 4;
            this.roleLabel.Text = "Роль в системе: Role";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(156, 58);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 19);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "ID: id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.availableDevicesLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.formName);
            this.panel1.Controls.Add(this.namUserLabel);
            this.panel1.Controls.Add(this.roleLabel);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.postLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 215);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(24, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.devicesListGried);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 185);
            this.panel2.TabIndex = 7;
            // 
            // devicesListGried
            // 
            this.devicesListGried.AllowUserToAddRows = false;
            this.devicesListGried.AllowUserToDeleteRows = false;
            this.devicesListGried.AllowUserToResizeColumns = false;
            this.devicesListGried.AllowUserToResizeRows = false;
            this.devicesListGried.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicesListGried.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.devicesListGried.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devicesListGried.DefaultCellStyle = dataGridViewCellStyle1;
            this.devicesListGried.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesListGried.Location = new System.Drawing.Point(0, 0);
            this.devicesListGried.Name = "devicesListGried";
            this.devicesListGried.ReadOnly = true;
            this.devicesListGried.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devicesListGried.Size = new System.Drawing.Size(500, 132);
            this.devicesListGried.TabIndex = 0;
            // 
            // availableDevicesLabel
            // 
            this.availableDevicesLabel.AutoSize = true;
            this.availableDevicesLabel.Location = new System.Drawing.Point(3, 199);
            this.availableDevicesLabel.Name = "availableDevicesLabel";
            this.availableDevicesLabel.Size = new System.Drawing.Size(203, 13);
            this.availableDevicesLabel.TabIndex = 7;
            this.availableDevicesLabel.Text = "Доступные пользователю устройства:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 53);
            this.panel3.TabIndex = 1;
            // 
            // addDeviceUser
            // 
            this.addDeviceUser.Location = new System.Drawing.Point(24, 15);
            this.addDeviceUser.Name = "addDeviceUser";
            this.addDeviceUser.Size = new System.Drawing.Size(164, 21);
            this.addDeviceUser.TabIndex = 0;
            this.addDeviceUser.Text = "Добавить устройство";
            this.addDeviceUser.UseVisualStyleBackColor = true;
            this.addDeviceUser.Click += new System.EventHandler(this.addDeviceUser_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chooseDeviceComboBox);
            this.panel4.Controls.Add(this.addDeviceUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(88, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 53);
            this.panel4.TabIndex = 1;
            // 
            // chooseDeviceComboBox
            // 
            this.chooseDeviceComboBox.FormattingEnabled = true;
            this.chooseDeviceComboBox.Location = new System.Drawing.Point(194, 15);
            this.chooseDeviceComboBox.Name = "chooseDeviceComboBox";
            this.chooseDeviceComboBox.Size = new System.Drawing.Size(206, 21);
            this.chooseDeviceComboBox.TabIndex = 1;
            this.chooseDeviceComboBox.Text = "Выберите устройство";
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInformationForm";
            this.Text = "UserInformationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devicesListGried)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Label namUserLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView devicesListGried;
        private System.Windows.Forms.Label availableDevicesLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addDeviceUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox chooseDeviceComboBox;
    }
}