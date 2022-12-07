namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    partial class AddDeviceForm
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
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.addDeviceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.typeComboBox);
            this.panelAddUser.Controls.Add(this.usersComboBox);
            this.panelAddUser.Controls.Add(this.errorLbl);
            this.panelAddUser.Controls.Add(this.addDeviceLabel);
            this.panelAddUser.Controls.Add(this.nameLabel);
            this.panelAddUser.Controls.Add(this.addDeviceButton);
            this.panelAddUser.Controls.Add(this.typeLabel);
            this.panelAddUser.Controls.Add(this.nameTextBox);
            this.panelAddUser.Controls.Add(this.ownerLabel);
            this.panelAddUser.Location = new System.Drawing.Point(220, 93);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(360, 264);
            this.panelAddUser.TabIndex = 16;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLbl.Location = new System.Drawing.Point(103, 155);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(171, 13);
            this.errorLbl.TabIndex = 15;
            this.errorLbl.Text = "Заполните поля: название и тип";
            // 
            // addDeviceLabel
            // 
            this.addDeviceLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDeviceLabel.Location = new System.Drawing.Point(54, 15);
            this.addDeviceLabel.Name = "addDeviceLabel";
            this.addDeviceLabel.Size = new System.Drawing.Size(277, 30);
            this.addDeviceLabel.TabIndex = 0;
            this.addDeviceLabel.Text = "Добавить устройство";
            this.addDeviceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(28, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 19);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Название:";
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(143, 181);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(82, 26);
            this.addDeviceButton.TabIndex = 14;
            this.addDeviceButton.Text = "Добавить";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(61, 97);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 19);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Тип:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(106, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.Location = new System.Drawing.Point(28, 132);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(76, 19);
            this.ownerLabel.TabIndex = 12;
            this.ownerLabel.Text = "Владелец:";
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(106, 131);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(176, 21);
            this.usersComboBox.TabIndex = 16;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(106, 94);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(176, 21);
            this.typeComboBox.TabIndex = 17;
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeviceForm";
            this.Text = "AddDeviceForm";
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label addDeviceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox usersComboBox;
    }
}