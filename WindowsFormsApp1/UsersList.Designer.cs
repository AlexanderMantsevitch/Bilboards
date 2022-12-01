namespace WindowsFormsApp1
{
    partial class UsersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserSurnameLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.viewingLogsButton = new System.Windows.Forms.Button();
            this.devicesListButton = new System.Windows.Forms.Button();
            this.usersListButton = new System.Windows.Forms.Button();
            this.usersListGrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersListGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.viewingLogsButton);
            this.panel1.Controls.Add(this.devicesListButton);
            this.panel1.Controls.Add(this.usersListButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UserNameLabel);
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 23);
            this.panel3.TabIndex = 8;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(213, 23);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "UserName";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserSurnameLabel);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 23);
            this.panel2.TabIndex = 7;
            // 
            // UserSurnameLabel
            // 
            this.UserSurnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSurnameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSurnameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserSurnameLabel.Name = "UserSurnameLabel";
            this.UserSurnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserSurnameLabel.Size = new System.Drawing.Size(213, 23);
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
            this.logOutButton.Location = new System.Drawing.Point(-1, 283);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(214, 42);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = false;
            // 
            // viewingLogsButton
            // 
            this.viewingLogsButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewingLogsButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.viewingLogsButton.FlatAppearance.BorderSize = 0;
            this.viewingLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewingLogsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewingLogsButton.Location = new System.Drawing.Point(-1, 235);
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
            // 
            // usersListButton
            // 
            this.usersListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.usersListButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.usersListButton.FlatAppearance.BorderSize = 0;
            this.usersListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersListButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListButton.Location = new System.Drawing.Point(-1, 139);
            this.usersListButton.Name = "usersListButton";
            this.usersListButton.Size = new System.Drawing.Size(214, 42);
            this.usersListButton.TabIndex = 1;
            this.usersListButton.Text = "Список пользователей";
            this.usersListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.usersListButton.UseVisualStyleBackColor = false;
            // 
            // usersListGrid
            // 
            this.usersListGrid.AllowUserToAddRows = false;
            this.usersListGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.usersListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.usersListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersListGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.usersListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersListGrid.Location = new System.Drawing.Point(0, 0);
            this.usersListGrid.MaximumSize = new System.Drawing.Size(900, 900);
            this.usersListGrid.MinimumSize = new System.Drawing.Size(495, 270);
            this.usersListGrid.Name = "usersListGrid";
            this.usersListGrid.RowHeadersWidth = 40;
            this.usersListGrid.Size = new System.Drawing.Size(586, 450);
            this.usersListGrid.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.usersListGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(214, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 450);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(214, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(586, 88);
            this.panel5.TabIndex = 5;
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UsersList";
            this.Text = "UsersList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersList_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersListGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserSurnameLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button viewingLogsButton;
        private System.Windows.Forms.Button devicesListButton;
        private System.Windows.Forms.Button usersListButton;
        private System.Windows.Forms.DataGridView usersListGrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}