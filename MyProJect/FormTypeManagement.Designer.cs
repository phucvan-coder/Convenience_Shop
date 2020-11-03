namespace MyProJect
{
    partial class FormTypeManagement
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
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnUpdateType = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.dgvTypeList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteType);
            this.groupBox1.Controls.Add(this.btnUpdateType);
            this.groupBox1.Controls.Add(this.txtTypeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.txtTypeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Details";
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(327, 60);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteType.TabIndex = 7;
            this.btnDeleteType.Text = "Delete";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnUpdateType
            // 
            this.btnUpdateType.Location = new System.Drawing.Point(327, 89);
            this.btnUpdateType.Name = "btnUpdateType";
            this.btnUpdateType.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateType.TabIndex = 6;
            this.btnUpdateType.Text = "Update";
            this.btnUpdateType.UseVisualStyleBackColor = true;
            this.btnUpdateType.Click += new System.EventHandler(this.btnUpdateType_Click);
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(138, 40);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(156, 20);
            this.txtTypeID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of type";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(327, 31);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 23);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(138, 89);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(156, 20);
            this.txtTypeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchType);
            this.groupBox2.Controls.Add(this.btnSearchType);
            this.groupBox2.Controls.Add(this.dgvTypeList);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type List";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(121, 35);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(156, 20);
            this.txtSearchType.TabIndex = 8;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Location = new System.Drawing.Point(283, 33);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(75, 23);
            this.btnSearchType.TabIndex = 8;
            this.btnSearchType.Text = "Search";
            this.btnSearchType.UseVisualStyleBackColor = true;
            // 
            // dgvTypeList
            // 
            this.dgvTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeList.Location = new System.Drawing.Point(80, 68);
            this.dgvTypeList.Name = "dgvTypeList";
            this.dgvTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeList.Size = new System.Drawing.Size(278, 159);
            this.dgvTypeList.TabIndex = 0;
            this.dgvTypeList.SelectionChanged += new System.EventHandler(this.dgvTypeList_SelectionChanged);
            this.dgvTypeList.Click += new System.EventHandler(this.dgvTypeList_Click);
            // 
            // FormTypeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormTypeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type Management";
            this.Load += new System.EventHandler(this.FormTypeManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTypeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnUpdateType;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.TextBox txtSearchType;
    }
}