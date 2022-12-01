namespace WindowsFormsApp1
{
    partial class Login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorAuthorizathionLbl = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AutorithationLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 371);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SignInButton);
            this.panel3.Controls.Add(this.errorAuthorizathionLbl);
            this.panel3.Controls.Add(this.loginLabel);
            this.panel3.Controls.Add(this.PasswordtextBox);
            this.panel3.Controls.Add(this.LogintextBox);
            this.panel3.Controls.Add(this.passwordLabel);
            this.panel3.Location = new System.Drawing.Point(0, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 161);
            this.panel3.TabIndex = 5;
            // 
            // errorAuthorizathionLbl
            // 
            this.errorAuthorizathionLbl.AutoSize = true;
            this.errorAuthorizathionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorAuthorizathionLbl.Location = new System.Drawing.Point(138, 61);
            this.errorAuthorizathionLbl.Name = "errorAuthorizathionLbl";
            this.errorAuthorizathionLbl.Size = new System.Drawing.Size(0, 13);
            this.errorAuthorizathionLbl.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(94, 13);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 19);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(141, 37);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(169, 20);
            this.PasswordtextBox.TabIndex = 4;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(141, 11);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(169, 20);
            this.LogintextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(63, 36);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 19);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AutorithationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 141);
            this.panel2.TabIndex = 0;
            // 
            // AutorithationLabel
            // 
            this.AutorithationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutorithationLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorithationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AutorithationLabel.Location = new System.Drawing.Point(0, 0);
            this.AutorithationLabel.Name = "AutorithationLabel";
            this.AutorithationLabel.Size = new System.Drawing.Size(404, 141);
            this.AutorithationLabel.TabIndex = 0;
            this.AutorithationLabel.Text = "Авторизация";
            this.AutorithationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(182, 79);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Войти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(404, 371);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 410);
            this.MinimumSize = new System.Drawing.Size(420, 410);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AutorithationLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label errorAuthorizathionLbl;
        private System.Windows.Forms.Button SignInButton;
    }
}