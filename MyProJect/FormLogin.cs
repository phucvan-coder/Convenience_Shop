using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProJect
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Method
        public bool Login()
        {
            bool result = false;
            try
            {
                using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
                {
                   
                    var check = entity.Accounts.Where(x => x.AccountName == txtUser.Text && x.Password == txtPassword.Text).FirstOrDefault();
                    if (check != null)
                    {
                        result = true;
                    }
                }
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            return result;
        }
        #endregion

        #region Event
        //// set vi tri con tro
        private void Form2_Load(object sender, EventArgs e)
        {
            int vitri = txtUser.Text.Length;
            int vitri2 = txtPassword.Text.Length;
            txtUser.SelectionStart = (vitri + 1);
            txtPassword.SelectionStart = (vitri2 + 1);
        }
        // login button
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            bool result = Login();

            if (result)
            {
                MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMenu menu = new FormMenu(txtUser.Text, txtPassword.Text);
                //pass data
                menu.ShowDialog();

                this.Show();
            }
            // nếu sai thông tin đăng nhập thì báo cmn lỗi luôn
            else
            {
                MessageBox.Show("Information not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // về menu chính
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //// thuộc tính hover -> Enter + Leave khi chuột ra vào form 
        //Action enter
        private void txt_User_Mouse_Enter(object sender, EventArgs e)
        {
            txtUser.Focus();
            // thay ảnh cho txt user
            pictureBox_User.Image = Properties.Resources.user_1;
            // text USer
            txtUser.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            // text password
            txtPassword.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
        }
        private void txt_Password_Mouse_Enter(object sender, EventArgs e)
        {
            txtPassword.Focus();
            // thay ảnh cho txt password
            pictureBoxPassword.Image = Properties.Resources.unlock_2;
            // text password
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            // text user
            txtUser.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
        }
        //Action Leave
        private void txt_Password_Mouse_Leave(object sender, EventArgs e)
        {
            pictureBoxPassword.Image = Properties.Resources.unlock_1;
            //text password -> color white smoke
            txtPassword.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
        }
        private void txt_User_Mouse_Leave(object sender, EventArgs e)
        {
            pictureBox_User.Image = Properties.Resources.user_2;
            //text user -> color white smoke but đồng đội éo thích
            txtUser.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
        }
        //Ask before closing
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion

        
    }
}
