﻿namespace WindowsFormsApp1.WindowsForms.LoginForm
{
    partial class NewPassword
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
            this.newPasswordButton = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.dublicatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.dublicatePasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorAuthorizathionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.Location = new System.Drawing.Point(172, 210);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.newPasswordButton.TabIndex = 0;
            this.newPasswordButton.Text = "Ok";
            this.newPasswordButton.UseVisualStyleBackColor = true;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(172, 129);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(169, 20);
            this.PasswordtextBox.TabIndex = 8;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(107, 128);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 19);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "пароль:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dublicatePasswordTextBox
            // 
            this.dublicatePasswordTextBox.Location = new System.Drawing.Point(172, 155);
            this.dublicatePasswordTextBox.Name = "dublicatePasswordTextBox";
            this.dublicatePasswordTextBox.Size = new System.Drawing.Size(169, 20);
            this.dublicatePasswordTextBox.TabIndex = 10;
            this.dublicatePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // dublicatePasswordLabel
            // 
            this.dublicatePasswordLabel.AutoSize = true;
            this.dublicatePasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dublicatePasswordLabel.Location = new System.Drawing.Point(32, 154);
            this.dublicatePasswordLabel.Name = "dublicatePasswordLabel";
            this.dublicatePasswordLabel.Size = new System.Drawing.Size(134, 19);
            this.dublicatePasswordLabel.TabIndex = 9;
            this.dublicatePasswordLabel.Text = "повторите пароль:";
            this.dublicatePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите новый пароль";
            // 
            // errorAuthorizathionLbl
            // 
            this.errorAuthorizathionLbl.AutoSize = true;
            this.errorAuthorizathionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorAuthorizathionLbl.Location = new System.Drawing.Point(169, 178);
            this.errorAuthorizathionLbl.Name = "errorAuthorizathionLbl";
            this.errorAuthorizathionLbl.Size = new System.Drawing.Size(118, 13);
            this.errorAuthorizathionLbl.TabIndex = 12;
            this.errorAuthorizathionLbl.Text = "Пароли не совпадают";
            // 
            // NewPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.errorAuthorizathionLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dublicatePasswordTextBox);
            this.Controls.Add(this.dublicatePasswordLabel);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.newPasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 300);
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newPasswordButton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox dublicatePasswordTextBox;
        private System.Windows.Forms.Label dublicatePasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorAuthorizathionLbl;
    }
}