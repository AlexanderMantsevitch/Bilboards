namespace WindowsFormsApp1
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserSurnameLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.viewingLogsButton = new System.Windows.Forms.Button();
            this.devicesListButton = new System.Windows.Forms.Button();
            this.usersListButton = new System.Windows.Forms.Button();
            this.adminInterfacePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.viewingLogsButton);
            this.panel1.Controls.Add(this.devicesListButton);
            this.panel1.Controls.Add(this.usersListButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 401);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UserNameLabel);
            this.panel3.Location = new System.Drawing.Point(0, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 34);
            this.panel3.TabIndex = 8;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(213, 34);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "UserName";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserSurnameLabel);
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 31);
            this.panel2.TabIndex = 7;
            // 
            // UserSurnameLabel
            // 
            this.UserSurnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSurnameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSurnameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserSurnameLabel.Name = "UserSurnameLabel";
            this.UserSurnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserSurnameLabel.Size = new System.Drawing.Size(213, 31);
            this.UserSurnameLabel.TabIndex = 6;
            this.UserSurnameLabel.Text = "UserSurName";
            this.UserSurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.Location = new System.Drawing.Point(-1, 264);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(214, 42);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // viewingLogsButton
            // 
            this.viewingLogsButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewingLogsButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.viewingLogsButton.FlatAppearance.BorderSize = 0;
            this.viewingLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewingLogsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewingLogsButton.Location = new System.Drawing.Point(0, 226);
            this.viewingLogsButton.Name = "viewingLogsButton";
            this.viewingLogsButton.Size = new System.Drawing.Size(214, 42);
            this.viewingLogsButton.TabIndex = 3;
            this.viewingLogsButton.Text = "Просмотр логов";
            this.viewingLogsButton.UseVisualStyleBackColor = false;
            // 
            // devicesListButton
            // 
            this.devicesListButton.BackColor = System.Drawing.SystemColors.Control;
            this.devicesListButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.devicesListButton.FlatAppearance.BorderSize = 0;
            this.devicesListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesListButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devicesListButton.Location = new System.Drawing.Point(-1, 187);
            this.devicesListButton.Name = "devicesListButton";
            this.devicesListButton.Size = new System.Drawing.Size(214, 42);
            this.devicesListButton.TabIndex = 2;
            this.devicesListButton.Text = "Список устройств";
            this.devicesListButton.UseVisualStyleBackColor = false;
            this.devicesListButton.Click += new System.EventHandler(this.devicesListButton_Click);
            // 
            // usersListButton
            // 
            this.usersListButton.BackColor = System.Drawing.SystemColors.Control;
            this.usersListButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.usersListButton.FlatAppearance.BorderSize = 0;
            this.usersListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersListButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListButton.Location = new System.Drawing.Point(-1, 139);
            this.usersListButton.Name = "usersListButton";
            this.usersListButton.Size = new System.Drawing.Size(214, 51);
            this.usersListButton.TabIndex = 1;
            this.usersListButton.Text = "Список пользователей";
            this.usersListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.usersListButton.UseVisualStyleBackColor = false;
            this.usersListButton.Click += new System.EventHandler(this.usersListButton_Click);
            // 
            // adminInterfacePanel
            // 
            this.adminInterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminInterfacePanel.Location = new System.Drawing.Point(214, 0);
            this.adminInterfacePanel.Name = "adminInterfacePanel";
            this.adminInterfacePanel.Size = new System.Drawing.Size(540, 401);
            this.adminInterfacePanel.TabIndex = 1;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 401);
            this.Controls.Add(this.adminInterfacePanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(740, 440);
            this.Name = "AdminInterface";
            this.Text = "Система управления билбордами";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminInterface_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usersListButton;
        private System.Windows.Forms.Button devicesListButton;
        private System.Windows.Forms.Button viewingLogsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label UserSurnameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel adminInterfacePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}