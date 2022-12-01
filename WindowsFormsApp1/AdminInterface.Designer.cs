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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.viewingLogsButton = new System.Windows.Forms.Button();
            this.devicesListButton = new System.Windows.Forms.Button();
            this.usersListButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.usersListButton.BackColor = System.Drawing.SystemColors.Control;
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
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 401);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(740, 440);
            this.Name = "AdminInterface";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminInterface_FormClosed);
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usersListButton;
        private System.Windows.Forms.Button devicesListButton;
        private System.Windows.Forms.Button viewingLogsButton;
        private System.Windows.Forms.Button logOutButton;
    }
}