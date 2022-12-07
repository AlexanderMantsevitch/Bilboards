namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    partial class editUserForm
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
            this.editUserPanel = new System.Windows.Forms.Panel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.surameTextBox = new System.Windows.Forms.TextBox();
            this.editUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editUserPanel
            // 
            this.editUserPanel.Controls.Add(this.errorLbl);
            this.editUserPanel.Controls.Add(this.addUserLabel);
            this.editUserPanel.Controls.Add(this.nameLabel);
            this.editUserPanel.Controls.Add(this.postTextBox);
            this.editUserPanel.Controls.Add(this.saveUserButton);
            this.editUserPanel.Controls.Add(this.surnameLabel);
            this.editUserPanel.Controls.Add(this.nameTextBox);
            this.editUserPanel.Controls.Add(this.loginTextBox);
            this.editUserPanel.Controls.Add(this.loginLabel);
            this.editUserPanel.Controls.Add(this.postLabel);
            this.editUserPanel.Controls.Add(this.surameTextBox);
            this.editUserPanel.Location = new System.Drawing.Point(249, 93);
            this.editUserPanel.Name = "editUserPanel";
            this.editUserPanel.Size = new System.Drawing.Size(302, 264);
            this.editUserPanel.TabIndex = 16;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLbl.Location = new System.Drawing.Point(103, 193);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(194, 13);
            this.errorLbl.TabIndex = 15;
            this.errorLbl.Text = "Заполните поля: имя, фамилия, login";
            // 
            // addUserLabel
            // 
            this.addUserLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserLabel.Location = new System.Drawing.Point(20, 15);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(277, 30);
            this.addUserLabel.TabIndex = 0;
            this.addUserLabel.Text = "Добавить пользователя";
            this.addUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(63, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 19);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Имя:";
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(106, 170);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(176, 20);
            this.postTextBox.TabIndex = 9;
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(143, 213);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(82, 26);
            this.saveUserButton.TabIndex = 14;
            this.saveUserButton.Text = "Сохранить";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(28, 97);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(75, 19);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(106, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(106, 132);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(176, 20);
            this.loginTextBox.TabIndex = 8;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(54, 133);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(46, 19);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Login:";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postLabel.Location = new System.Drawing.Point(12, 170);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(88, 19);
            this.postLabel.TabIndex = 13;
            this.postLabel.Text = "Должность:";
            // 
            // surameTextBox
            // 
            this.surameTextBox.Location = new System.Drawing.Point(106, 96);
            this.surameTextBox.Name = "surameTextBox";
            this.surameTextBox.Size = new System.Drawing.Size(176, 20);
            this.surameTextBox.TabIndex = 7;
            // 
            // editUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editUserForm";
            this.Text = "editUser";
            this.Resize += new System.EventHandler(this.editUserForm_Resize);
            this.editUserPanel.ResumeLayout(false);
            this.editUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editUserPanel;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.TextBox surameTextBox;
    }
}