namespace WindowsFormsApp1.WindowsForms.AdminInterfacesForm.DevicesList
{
    partial class DevicesListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chooseDeviceButton = new System.Windows.Forms.Button();
            this.removeDeviceButton = new System.Windows.Forms.Button();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.devicesListGrid = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(798, 88);
            this.panel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chooseDeviceButton);
            this.panel3.Controls.Add(this.removeDeviceButton);
            this.panel3.Controls.Add(this.addDeviceButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(232, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 47);
            this.panel3.TabIndex = 3;
            // 
            // chooseDeviceButton
            // 
            this.chooseDeviceButton.Location = new System.Drawing.Point(35, 11);
            this.chooseDeviceButton.Name = "chooseDeviceButton";
            this.chooseDeviceButton.Size = new System.Drawing.Size(180, 30);
            this.chooseDeviceButton.TabIndex = 2;
            this.chooseDeviceButton.Text = "Выбрать устройство";
            this.chooseDeviceButton.UseVisualStyleBackColor = true;
            // 
            // removeDeviceButton
            // 
            this.removeDeviceButton.Location = new System.Drawing.Point(221, 11);
            this.removeDeviceButton.Name = "removeDeviceButton";
            this.removeDeviceButton.Size = new System.Drawing.Size(163, 30);
            this.removeDeviceButton.TabIndex = 1;
            this.removeDeviceButton.Text = "Удалить устройство";
            this.removeDeviceButton.UseVisualStyleBackColor = true;
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(390, 11);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(163, 30);
            this.addDeviceButton.TabIndex = 0;
            this.addDeviceButton.Text = "Добавить устройство";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 39);
            this.panel2.TabIndex = 2;
            // 
            // devicesListGrid
            // 
            this.devicesListGrid.AllowUserToAddRows = false;
            this.devicesListGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.devicesListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.devicesListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicesListGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.devicesListGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.devicesListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesListGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.devicesListGrid.Location = new System.Drawing.Point(0, 0);
            this.devicesListGrid.MinimumSize = new System.Drawing.Size(495, 270);
            this.devicesListGrid.Name = "devicesListGrid";
            this.devicesListGrid.ReadOnly = true;
            this.devicesListGrid.RowHeadersWidth = 40;
            this.devicesListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devicesListGrid.Size = new System.Drawing.Size(798, 340);
            this.devicesListGrid.TabIndex = 7;
            // 
            // DevicesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 428);
            this.Controls.Add(this.devicesListGrid);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevicesListForm";
            this.Text = "DevicesListForm";
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devicesListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button chooseDeviceButton;
        private System.Windows.Forms.Button removeDeviceButton;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView devicesListGrid;
    }
}