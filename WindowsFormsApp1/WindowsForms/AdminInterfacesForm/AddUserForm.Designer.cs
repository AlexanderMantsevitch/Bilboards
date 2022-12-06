using System.Drawing;

namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm
{
    partial class AddUserForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.surameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.panelForm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 400);
            this.panel5.TabIndex = 4;
            // 
            // panelForm
            // 
            this.panelForm.AutoSize = true;
            this.panelForm.Controls.Add(this.panelAddUser);
            this.panelForm.Controls.Add(this.panel3);
            this.panelForm.Controls.Add(this.panel2);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(500, 400);
            this.panelForm.TabIndex = 15;
            this.panelForm.Resize += new System.EventHandler(this.panelForm_Resize);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.errorLbl);
            this.panelAddUser.Controls.Add(this.addUserLabel);
            this.panelAddUser.Controls.Add(this.nameLabel);
            this.panelAddUser.Controls.Add(this.postTextBox);
            this.panelAddUser.Controls.Add(this.addUserButton);
            this.panelAddUser.Controls.Add(this.surnameLabel);
            this.panelAddUser.Controls.Add(this.nameTextBox);
            this.panelAddUser.Controls.Add(this.loginTextBox);
            this.panelAddUser.Controls.Add(this.loginLabel);
            this.panelAddUser.Controls.Add(this.postLabel);
            this.panelAddUser.Controls.Add(this.surameTextBox);
            this.panelAddUser.Location = new System.Drawing.Point(103, 72);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(302, 264);
            this.panelAddUser.TabIndex = 15;
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
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(143, 213);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(82, 26);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(500, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 400);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 400);
            this.panel2.TabIndex = 16;
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
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Text = "AddUserFrom";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox surameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorLbl;
    }
}