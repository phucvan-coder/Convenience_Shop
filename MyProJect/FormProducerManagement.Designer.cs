namespace MyProJect
{
    partial class FormProducerManagement
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
            this.btnUpdateProducer = new System.Windows.Forms.Button();
            this.btnDeleteProducer = new System.Windows.Forms.Button();
            this.btnAddProducer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducerPhone = new System.Windows.Forms.TextBox();
            this.txtProducerAddress = new System.Windows.Forms.TextBox();
            this.txtProducerName = new System.Windows.Forms.TextBox();
            this.txtProducerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProducerList = new System.Windows.Forms.DataGridView();
            this.btnSearchProducer = new System.Windows.Forms.Button();
            this.txtSearchProducer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducerList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnUpdateProducer);
            this.groupBox1.Controls.Add(this.btnDeleteProducer);
            this.groupBox1.Controls.Add(this.btnAddProducer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProducerPhone);
            this.groupBox1.Controls.Add(this.txtProducerAddress);
            this.groupBox1.Controls.Add(this.txtProducerName);
            this.groupBox1.Controls.Add(this.txtProducerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producer Details";
            // 
            // btnUpdateProducer
            // 
            this.btnUpdateProducer.Location = new System.Drawing.Point(640, 79);
            this.btnUpdateProducer.Name = "btnUpdateProducer";
            this.btnUpdateProducer.Size = new System.Drawing.Size(74, 23);
            this.btnUpdateProducer.TabIndex = 16;
            this.btnUpdateProducer.Text = "Update";
            this.btnUpdateProducer.UseVisualStyleBackColor = true;
            this.btnUpdateProducer.Click += new System.EventHandler(this.btnUpdateProducer_Click);
            // 
            // btnDeleteProducer
            // 
            this.btnDeleteProducer.Location = new System.Drawing.Point(560, 80);
            this.btnDeleteProducer.Name = "btnDeleteProducer";
            this.btnDeleteProducer.Size = new System.Drawing.Size(74, 23);
            this.btnDeleteProducer.TabIndex = 15;
            this.btnDeleteProducer.Text = "Delete";
            this.btnDeleteProducer.UseVisualStyleBackColor = true;
            this.btnDeleteProducer.Click += new System.EventHandler(this.btnDeleteProducer_Click);
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Location = new System.Drawing.Point(480, 80);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.Size = new System.Drawing.Size(74, 23);
            this.btnAddProducer.TabIndex = 14;
            this.btnAddProducer.Text = "Add";
            this.btnAddProducer.UseVisualStyleBackColor = true;
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Producer name";
            // 
            // txtProducerPhone
            // 
            this.txtProducerPhone.Location = new System.Drawing.Point(556, 28);
            this.txtProducerPhone.Name = "txtProducerPhone";
            this.txtProducerPhone.Size = new System.Drawing.Size(158, 20);
            this.txtProducerPhone.TabIndex = 10;
            this.txtProducerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducerPhone_KeyPress);
            // 
            // txtProducerAddress
            // 
            this.txtProducerAddress.Location = new System.Drawing.Point(148, 134);
            this.txtProducerAddress.Name = "txtProducerAddress";
            this.txtProducerAddress.Size = new System.Drawing.Size(158, 20);
            this.txtProducerAddress.TabIndex = 9;
            // 
            // txtProducerName
            // 
            this.txtProducerName.Location = new System.Drawing.Point(148, 81);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.Size = new System.Drawing.Size(158, 20);
            this.txtProducerName.TabIndex = 8;
            // 
            // txtProducerID
            // 
            this.txtProducerID.Location = new System.Drawing.Point(148, 30);
            this.txtProducerID.Name = "txtProducerID";
            this.txtProducerID.ReadOnly = true;
            this.txtProducerID.Size = new System.Drawing.Size(158, 20);
            this.txtProducerID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProducerList);
            this.groupBox2.Controls.Add(this.btnSearchProducer);
            this.groupBox2.Controls.Add(this.txtSearchProducer);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producer List";
            // 
            // dgvProducerList
            // 
            this.dgvProducerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducerList.Location = new System.Drawing.Point(6, 47);
            this.dgvProducerList.Name = "dgvProducerList";
            this.dgvProducerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducerList.Size = new System.Drawing.Size(719, 150);
            this.dgvProducerList.TabIndex = 18;
            this.dgvProducerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducerList_CellContentClick);
            this.dgvProducerList.SelectionChanged += new System.EventHandler(this.dgvProducerList_SelectionChanged);
            this.dgvProducerList.Click += new System.EventHandler(this.dgvProducerList_Click);
            // 
            // btnSearchProducer
            // 
            this.btnSearchProducer.Location = new System.Drawing.Point(640, 16);
            this.btnSearchProducer.Name = "btnSearchProducer";
            this.btnSearchProducer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProducer.TabIndex = 17;
            this.btnSearchProducer.Text = "Search";
            this.btnSearchProducer.UseVisualStyleBackColor = true;
            this.btnSearchProducer.Click += new System.EventHandler(this.btnSearchProducer_Click);
            // 
            // txtSearchProducer
            // 
            this.txtSearchProducer.Location = new System.Drawing.Point(480, 19);
            this.txtSearchProducer.Name = "txtSearchProducer";
            this.txtSearchProducer.Size = new System.Drawing.Size(150, 20);
            this.txtSearchProducer.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producer Management";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(640, 134);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormProducerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProducerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producer Management";
            this.Load += new System.EventHandler(this.FormProducerManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProducerPhone;
        private System.Windows.Forms.TextBox txtProducerAddress;
        private System.Windows.Forms.TextBox txtProducerName;
        private System.Windows.Forms.TextBox txtProducerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchProducer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateProducer;
        private System.Windows.Forms.Button btnDeleteProducer;
        private System.Windows.Forms.Button btnAddProducer;
        private System.Windows.Forms.Button btnSearchProducer;
        private System.Windows.Forms.DataGridView dgvProducerList;
        private System.Windows.Forms.Button btnRefresh;
    }
}