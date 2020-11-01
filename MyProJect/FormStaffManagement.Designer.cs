namespace MyProJect
{
    partial class FormStaffManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.btnUpdateStaff);
            this.groupBox1.Controls.Add(this.btnDeleteStaff);
            this.groupBox1.Controls.Add(this.btnAddStaff);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtStaffAddress);
            this.groupBox1.Controls.Add(this.txtStaffPhone);
            this.groupBox1.Controls.Add(this.txtStaffEmail);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Details";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(129, 103);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(164, 20);
            this.dtpDateOfBirth.TabIndex = 21;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(668, 140);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStaff.TabIndex = 20;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(579, 141);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 19;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(486, 142);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 18;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(129, 140);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(164, 21);
            this.cmbGender.TabIndex = 17;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(579, 107);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(164, 20);
            this.txtStaffAddress.TabIndex = 15;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(579, 63);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(164, 20);
            this.txtStaffPhone.TabIndex = 13;
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Location = new System.Drawing.Point(579, 19);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(164, 20);
            this.txtStaffEmail.TabIndex = 12;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(129, 63);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(164, 20);
            this.txtStaffName.TabIndex = 11;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(129, 19);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(164, 20);
            this.txtStaffID.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStaffList);
            this.groupBox2.Controls.Add(this.btnSearchStaff);
            this.groupBox2.Controls.Add(this.txtSearchStaff);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff List";
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.Location = new System.Drawing.Point(6, 38);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffList.Size = new System.Drawing.Size(764, 169);
            this.dgvStaffList.TabIndex = 22;
            this.dgvStaffList.SelectionChanged += new System.EventHandler(this.dgvStaffList_SelectionChanged);
            this.dgvStaffList.Click += new System.EventHandler(this.dgvStaffList_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(695, 12);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStaff.TabIndex = 21;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Location = new System.Drawing.Point(525, 12);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(164, 20);
            this.txtSearchStaff.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Management";
            // 
            // FormStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStaffManagement_FormClosed);
            this.Load += new System.EventHandler(this.FormStaffManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}