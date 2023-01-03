namespace WindowsFormsApp1.WindowsForms
{
    partial class UserInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserSurnameLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.devicesListButton = new System.Windows.Forms.Button();
            this.exportVideoButton = new System.Windows.Forms.Button();
            this.userInterfacePanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.panel3);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Controls.Add(this.logOutButton);
            this.menuPanel.Controls.Add(this.statsButton);
            this.menuPanel.Controls.Add(this.devicesListButton);
            this.menuPanel.Controls.Add(this.exportVideoButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(214, 401);
            this.menuPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 87);
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
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.SystemColors.Control;
            this.statsButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.statsButton.FlatAppearance.BorderSize = 0;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsButton.Location = new System.Drawing.Point(0, 188);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(214, 42);
            this.statsButton.TabIndex = 3;
            this.statsButton.Text = "Статистика";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // devicesListButton
            // 
            this.devicesListButton.BackColor = System.Drawing.SystemColors.Control;
            this.devicesListButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.devicesListButton.FlatAppearance.BorderSize = 0;
            this.devicesListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesListButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devicesListButton.Location = new System.Drawing.Point(0, 150);
            this.devicesListButton.Name = "devicesListButton";
            this.devicesListButton.Size = new System.Drawing.Size(214, 42);
            this.devicesListButton.TabIndex = 2;
            this.devicesListButton.Text = "Список устройств";
            this.devicesListButton.UseVisualStyleBackColor = false;
            this.devicesListButton.Click += new System.EventHandler(this.devicesListButton_Click);
            // 
            // exportVideoButton
            // 
            this.exportVideoButton.BackColor = System.Drawing.SystemColors.Control;
            this.exportVideoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.exportVideoButton.FlatAppearance.BorderSize = 0;
            this.exportVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportVideoButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportVideoButton.Location = new System.Drawing.Point(0, 220);
            this.exportVideoButton.Name = "exportVideoButton";
            this.exportVideoButton.Size = new System.Drawing.Size(214, 51);
            this.exportVideoButton.TabIndex = 1;
            this.exportVideoButton.Text = "Загрузить видеоролик";
            this.exportVideoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exportVideoButton.UseVisualStyleBackColor = false;
            this.exportVideoButton.Click += new System.EventHandler(this.importVideoButton_Click);
            // 
            // userInterfacePanel
            // 
            this.userInterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInterfacePanel.Location = new System.Drawing.Point(214, 0);
            this.userInterfacePanel.Name = "userInterfacePanel";
            this.userInterfacePanel.Size = new System.Drawing.Size(510, 401);
            this.userInterfacePanel.TabIndex = 2;
            // 
            // UserInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 401);
            this.Controls.Add(this.userInterfacePanel);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(740, 440);
            this.Name = "UserInterfaceForm";
            this.Text = "UserInterfaceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserInterfaceForm_FormClosed);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserSurnameLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button devicesListButton;
        private System.Windows.Forms.Button exportVideoButton;
        private System.Windows.Forms.Panel userInterfacePanel;
    }
}