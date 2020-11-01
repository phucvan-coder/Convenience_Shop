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
        //// set vi tri con tro
        private void Form2_Load(object sender, EventArgs e)
        {
            int vitri = TextUser.Text.Length;
            int vitri2 = Textpassword.Text.Length;
            TextUser.SelectionStart = (vitri + 1);
            Textpassword.SelectionStart = (vitri2 + 1);
        }
        // login button
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // thêm tài khoản tạm thời
            string username = TextUser.Text;
            string password = Textpassword.Text;
            string user1 = "Admin1";
            string user2 = "Admin2";
            // kiểm tra ragn2 buộc của thông tin nếu trống -> thông báo lỗi 
            if (username == string.Empty || password == string.Empty)
                MessageBox.Show("Your information must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // độ dài mật khẩu phải >6
            else if (password.Length <= 6)
                MessageBox.Show("Password must be more than 6 words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // kiểm tra dữ liệu nếu đúng thì đăng nhập thành công nếu sai thì thành thụ :v
            else if ((string.Compare(username, user1, false) == 0 && password.Length > 6) || (string.Compare(username, user2, false) == 0 && password.Length > 6))
            {
                MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
            // nếu sai thông tin đăng nhập thì báo cmn lỗi luôn
            else if (string.Compare(username, user1, false) != 0 || string.Compare(username, user2, false) == 0)
                MessageBox.Show("Information not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // về menu chính
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // password char s-> set sup ký tự mật khẩu cho giống mấy ông FB, Insta đồ
        private void Textpassword_TextChanged(object sender, EventArgs e)
        {
            Textpassword.PasswordChar = '•';
        }
        // action on Double-Click thêm cho vui thôi sau này tính tiếp
        private void txt_User_Mouse_DoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void txt_Password_Mouse_DoubleClick(object sender, MouseEventArgs e)
        {

        }
        //// thuộc tính hover -> Enter + Leave khi chuột ra vào form 
        //Action enter
        private void txt_User_Mouse_Enter(object sender, EventArgs e)
        {
            TextUser.Focus();
            // thay ảnh cho txt user
            pictureBox_User.Image = Properties.Resources.user_1;
            // text USer
            TextUser.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            // text password
            Textpassword.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
        }
        private void txt_Password_Mouse_Enter(object sender, EventArgs e)
        {
            Textpassword.Focus();
            // thay ảnh cho txt password
            pictureBoxPassword.Image = Properties.Resources.unlock_2;
            // text password
            Textpassword.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            // text user
            TextUser.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
        }
        //Action Leave
        private void txt_Password_Mouse_Leave(object sender, EventArgs e)
        {
            pictureBoxPassword.Image = Properties.Resources.unlock_1;
            //text password -> color white smoke
            Textpassword.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
        }
        private void txt_User_Mouse_Leave(object sender, EventArgs e)
        {
            pictureBox_User.Image = Properties.Resources.user_2;
            //text user -> color white smoke but đồng đội éo thích
            TextUser.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
        }
        // action khi click 1 cú ở đây >>>>>>>>>>.
        // mouse click user 
        private void txt_User_Mouse_Click(object sender, MouseEventArgs e)
        {
            TextUser.Clear();
        }
        // mouse click password
        private void txt_Password_Mouse_Click(object sender, MouseEventArgs e)
        {
            Textpassword.Clear();
        }
        //Ask before closing
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
