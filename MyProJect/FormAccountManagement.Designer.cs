namespace MyProJect
{
    partial class FormAccountManagement
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
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccountList = new System.Windows.Forms.DataGridView();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateAccount);
            this.groupBox1.Controls.Add(this.btnDeleteAccount);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Controls.Add(this.txtAccountID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(346, 106);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAccount.TabIndex = 11;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(346, 67);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 10;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(346, 28);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 9;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(131, 70);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(149, 20);
            this.txtAccountName.TabIndex = 7;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(131, 31);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(149, 20);
            this.txtAccountID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccountList);
            this.groupBox2.Controls.Add(this.btnSearchAccount);
            this.groupBox2.Controls.Add(this.txtSearchAccount);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account List";
            // 
            // dgvAccountList
            // 
            this.dgvAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountList.Location = new System.Drawing.Point(6, 45);
            this.dgvAccountList.Name = "dgvAccountList";
            this.dgvAccountList.Size = new System.Drawing.Size(460, 157);
            this.dgvAccountList.TabIndex = 13;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(391, 16);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAccount.TabIndex = 12;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Location = new System.Drawing.Point(236, 16);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(149, 20);
            this.txtSearchAccount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Management";
            // 
            // FormAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAccountManagement";
            this.Text = "Account Management";
            this.Load += new System.EventHandler(this.FormAccountManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.DataGridView dgvAccountList;
    }
}