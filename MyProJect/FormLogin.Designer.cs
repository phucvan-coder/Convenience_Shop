﻿namespace MyProJect
{
    partial class FormLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Textpassword = new System.Windows.Forms.TextBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(23, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 50);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(182, 222);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 50);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(23, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 1);
            this.panel1.TabIndex = 24;
            // 
            // TextUser
            // 
            this.TextUser.BackColor = System.Drawing.Color.White;
            this.TextUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.ForeColor = System.Drawing.Color.Black;
            this.TextUser.Location = new System.Drawing.Point(60, 102);
            this.TextUser.Multiline = true;
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(246, 20);
            this.TextUser.TabIndex = 23;
            this.TextUser.Text = "Account name";
            this.TextUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_User_Mouse_Click);
            this.TextUser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_User_Mouse_DoubleClick);
            this.TextUser.MouseEnter += new System.EventHandler(this.txt_User_Mouse_Enter);
            this.TextUser.MouseLeave += new System.EventHandler(this.txt_User_Mouse_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(23, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 1);
            this.panel2.TabIndex = 9;
            // 
            // Textpassword
            // 
            this.Textpassword.BackColor = System.Drawing.Color.White;
            this.Textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textpassword.ForeColor = System.Drawing.Color.Black;
            this.Textpassword.Location = new System.Drawing.Point(60, 163);
            this.Textpassword.Multiline = true;
            this.Textpassword.Name = "Textpassword";
            this.Textpassword.Size = new System.Drawing.Size(246, 20);
            this.Textpassword.TabIndex = 8;
            this.Textpassword.Text = "Password";
            this.Textpassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Password_Mouse_Click);
            this.Textpassword.TextChanged += new System.EventHandler(this.Textpassword_TextChanged);
            this.Textpassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_Password_Mouse_DoubleClick);
            this.Textpassword.MouseEnter += new System.EventHandler(this.txt_Password_Mouse_Enter);
            this.Textpassword.MouseLeave += new System.EventHandler(this.txt_Password_Mouse_Leave);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::MyProJect.Properties.Resources.unlock_1;
            this.pictureBoxPassword.Location = new System.Drawing.Point(24, 159);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.TabIndex = 7;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Image = global::MyProJect.Properties.Resources.user_2;
            this.pictureBox_User.Location = new System.Drawing.Point(24, 98);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_User.TabIndex = 22;
            this.pictureBox_User.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProJect.Properties.Resources.paper_plane;
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Textpassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Textpassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
    }
}