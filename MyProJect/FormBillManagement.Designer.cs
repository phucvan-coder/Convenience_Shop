namespace MyProJect
{
    partial class FormBillManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoneyStatistics = new System.Windows.Forms.TextBox();
            this.dgvBillList = new System.Windows.Forms.DataGridView();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefreshBill = new System.Windows.Forms.Button();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMoneyStatistics);
            this.groupBox1.Controls.Add(this.dgvBillList);
            this.groupBox1.Controls.Add(this.btnSearchBill);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.btnRefreshBill);
            this.groupBox1.Controls.Add(this.txtSearchBill);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill satistics List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Money Statistics";
            // 
            // txtMoneyStatistics
            // 
            this.txtMoneyStatistics.Location = new System.Drawing.Point(146, 273);
            this.txtMoneyStatistics.Name = "txtMoneyStatistics";
            this.txtMoneyStatistics.ReadOnly = true;
            this.txtMoneyStatistics.Size = new System.Drawing.Size(225, 20);
            this.txtMoneyStatistics.TabIndex = 5;
            // 
            // dgvBillList
            // 
            this.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillList.Location = new System.Drawing.Point(6, 48);
            this.dgvBillList.Name = "dgvBillList";
            this.dgvBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillList.Size = new System.Drawing.Size(670, 212);
            this.dgvBillList.TabIndex = 4;
            this.dgvBillList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillList_CellContentClick);
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Location = new System.Drawing.Point(601, 20);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBill.TabIndex = 3;
            this.btnSearchBill.Text = "Search";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(87, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRefreshBill
            // 
            this.btnRefreshBill.Location = new System.Drawing.Point(6, 19);
            this.btnRefreshBill.Name = "btnRefreshBill";
            this.btnRefreshBill.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshBill.TabIndex = 1;
            this.btnRefreshBill.Text = "Refresh";
            this.btnRefreshBill.UseVisualStyleBackColor = true;
            this.btnRefreshBill.Click += new System.EventHandler(this.btnRefreshBill_Click);
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.Location = new System.Drawing.Point(440, 22);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(155, 20);
            this.txtSearchBill.TabIndex = 0;
            // 
            // FormBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormBillManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Management";
            this.Load += new System.EventHandler(this.FormBillManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBillList;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefreshBill;
        private System.Windows.Forms.TextBox txtSearchBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneyStatistics;
    }
}