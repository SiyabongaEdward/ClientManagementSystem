namespace ClientManagementSystem
{
    partial class ClientMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWorkAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPostalAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ethnicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cboEthnicity = new System.Windows.Forms.ComboBox();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(83, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(274, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ethnicity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Merital Status";
            // 
            // txtCellNo
            // 
            this.txtCellNo.Location = new System.Drawing.Point(83, 136);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(100, 20);
            this.txtCellNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cell No.";
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.Location = new System.Drawing.Point(274, 135);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(100, 20);
            this.txtWorkTel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Work tel.";
            // 
            // txtResAddress
            // 
            this.txtResAddress.Location = new System.Drawing.Point(83, 164);
            this.txtResAddress.Name = "txtResAddress";
            this.txtResAddress.Size = new System.Drawing.Size(100, 20);
            this.txtResAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Res Address";
            // 
            // txtWorkAddress
            // 
            this.txtWorkAddress.Location = new System.Drawing.Point(274, 164);
            this.txtWorkAddress.Name = "txtWorkAddress";
            this.txtWorkAddress.Size = new System.Drawing.Size(100, 20);
            this.txtWorkAddress.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Work Address";
            // 
            // txtPostalAddress
            // 
            this.txtPostalAddress.Location = new System.Drawing.Point(468, 164);
            this.txtPostalAddress.Name = "txtPostalAddress";
            this.txtPostalAddress.Size = new System.Drawing.Size(100, 20);
            this.txtPostalAddress.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Postal Address";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Ethnicity,
            this.MaritalStatus});
            this.dgvClients.Location = new System.Drawing.Point(15, 234);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(644, 170);
            this.dgvClients.TabIndex = 20;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "Client ID";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Ethnicity
            // 
            this.Ethnicity.DataPropertyName = "Ethnicity";
            this.Ethnicity.HeaderText = "Ethnicity";
            this.Ethnicity.Name = "Ethnicity";
            this.Ethnicity.ReadOnly = true;
            // 
            // MaritalStatus
            // 
            this.MaritalStatus.DataPropertyName = "MaritalStatus";
            this.MaritalStatus.HeaderText = "Marital Status";
            this.MaritalStatus.Name = "MaritalStatus";
            this.MaritalStatus.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(641, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(722, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(83, 12);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(69, 20);
            this.txtClientID.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Client ID";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(83, 93);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 21);
            this.cboGender.TabIndex = 25;
            // 
            // cboMaritalStatus
            // 
            this.cboMaritalStatus.FormattingEnabled = true;
            this.cboMaritalStatus.Items.AddRange(new object[] {
            "M",
            "S"});
            this.cboMaritalStatus.Location = new System.Drawing.Point(274, 90);
            this.cboMaritalStatus.Name = "cboMaritalStatus";
            this.cboMaritalStatus.Size = new System.Drawing.Size(100, 21);
            this.cboMaritalStatus.TabIndex = 26;
            // 
            // cboEthnicity
            // 
            this.cboEthnicity.FormattingEnabled = true;
            this.cboEthnicity.Items.AddRange(new object[] {
            "African",
            "White",
            "Asian",
            "Other"});
            this.cboEthnicity.Location = new System.Drawing.Point(83, 64);
            this.cboEthnicity.Name = "cboEthnicity";
            this.cboEthnicity.Size = new System.Drawing.Size(100, 21);
            this.cboEthnicity.TabIndex = 27;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(15, 420);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(102, 23);
            this.btnExportToCSV.TabIndex = 28;
            this.btnExportToCSV.Text = "Export to File";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // ClientMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.cboEthnicity);
            this.Controls.Add(this.cboMaritalStatus);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.txtPostalAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWorkAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtResAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWorkTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCellNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "ClientMS";
            this.Text = "Client Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWorkAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPostalAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ethnicity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaritalStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboMaritalStatus;
        private System.Windows.Forms.ComboBox cboEthnicity;
        private System.Windows.Forms.Button btnExportToCSV;
    }
}

