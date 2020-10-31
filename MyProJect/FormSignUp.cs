using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Net;

namespace MyProJect
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        // click button action
        // nút signup
        private void button1_Click(object sender, EventArgs e)
        {
            // tên tài khoản
            string name = txtAccountName.Text;
            // địa chỉ email
            string email = txtEmail.Text;
            // số đt
            string phonenumber = txtPhone.Text;
            // password
            string password = txtPassword.Text;
            // nhập lại password 
            string confirm = txtConfirm.Text;
            // kiểm tra dữ liệu không được phép trống
            if (name == string.Empty || email == string.Empty || phonenumber == string.Empty || password == string.Empty || confirm == string.Empty)
                MessageBox.Show("You must not leave any information blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // kiểm tra độ dài password
            else if (password.Length <= 6)
                MessageBox.Show("Password must be more than 6 words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // kiểm tra bằng cách so sánh chuỗi có phân biệt hoa thường
            else if (string.Compare(password, confirm, false) != 0)
                MessageBox.Show("Password and confirm aren't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // kiểm tra toàn bộ nếu đúng thì đăng ký thành công ngược lại thì thanh thụ
            else if (password.Length > 6 && string.Compare(password, confirm, false) == 0)
            {
                MessageBox.Show("Sign up success press 'ok' to continue", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
        }
        // nút back
        private void button2_Click(object sender, EventArgs e)
        {
            //ẩn form hiện tại
            this.Hide();
            // gọi hồn form 1
            FormMain f1 = new FormMain();
            f1.Show();
        }
        // tên tk
        private void MouseENter_account(object sender, EventArgs e)
        {
            // focus mode
            //textBox1.Focus();
            // chỉnh màu cho cái email
            ptBAccname.Image = Properties.Resources.user_1;
            // textbox email
            txtAccountName.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            // còn lại thì để màu mặc định
            // text box tk
            txtEmail.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
            // text box SDT
            txtPhone.ForeColor = Color.Black;
            panel3.BackColor = Color.Black;
            // text box password
            txtPassword.ForeColor = Color.Black;
            panel4.BackColor = Color.Black;
            // text box nhập lại pass
            txtConfirm.ForeColor = Color.Black;
            panel5.BackColor = Color.Black;
        }
        // email
        private void MouseEnter_2(object sender, EventArgs e)
        {
            // focus mode
            //textBox2.Focus();
            // chỉnh màu cho cái email
            ptBEmail.Image = Properties.Resources.email_1;
            // textbox email
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            // còn lại thì để màu mặc định
            // text box tk
            txtAccountName.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
            // text box SDT
            txtPhone.ForeColor = Color.Black;
            panel3.BackColor = Color.Black;
            // text box password
            txtPassword.ForeColor = Color.Black;
            panel4.BackColor = Color.Black;
            // text box nhập lại pass
            txtConfirm.ForeColor = Color.Black;
            panel5.BackColor = Color.Black;
        }
        // số DT
        private void MouseEnter_3(object sender, EventArgs e)
        {
            // focus mode
            //textBox3.Focus();
            // chỉnh màu cho cái tên tk 
            ptBPhone.Image = Properties.Resources.telephone_1;
            // textbox số phone
            txtPhone.ForeColor = Color.FromArgb(78, 184, 206);
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            // còn lại thì để màu mặc định
            // text box email
            txtEmail.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
            // text box tk
            txtAccountName.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
            // text box password
            txtPassword.ForeColor = Color.Black;
            panel4.BackColor = Color.Black;
            // text box nhập lại pass
            txtConfirm.ForeColor = Color.Black;
            panel5.BackColor = Color.Black;
        }
        // password =>>>>>>>
        private void MouseEnter_4(object sender, EventArgs e)
        {
            // focus mode
            //textBox4.Focus();
            // chỉnh màu cho cái tên tk 
            ptBPassWord.Image = Properties.Resources.unlock_2;
            // textbox tên tk
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            // còn lại thì để màu mặc định
            // text box email
            txtEmail.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
            // text box SDT
            txtPhone.ForeColor = Color.Black;
            panel3.BackColor = Color.Black;
            // text box tk
            txtAccountName.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
            // text box nhập lại pass
            txtConfirm.ForeColor = Color.Black;
            panel5.BackColor = Color.Black;
        }
        // confirm
        private void MouseEnter_5(object sender, EventArgs e)
        {
            // focus mode
            //textBox5.Focus();
            // chỉnh màu cho cái tên tk 
            ptBConFirm.Image = Properties.Resources.log_in_1;
            // textbox tên tk
            txtConfirm.ForeColor = Color.FromArgb(78, 184, 206);
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            // còn lại thì để màu mặc định
            // text box email
            txtEmail.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
            // text box SDT
            txtPhone.ForeColor = Color.Black;
            panel3.BackColor = Color.Black;
            // text box password
            txtPassword.ForeColor = Color.Black;
            panel4.BackColor = Color.Black;
            // text box tk
            txtAccountName.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
        }
        //MouseButtons leave
        // leave tex 1
        private void MouseLeave_1(object sender, EventArgs e)
        {
            // text tk
            ptBAccname.Image = Properties.Resources.user_2;
            txtAccountName.ForeColor = Color.Black;
            panel1.BackColor = Color.Black;
        }
        // mouse leave text 2
        private void MouseLeave_2(object sender, EventArgs e)
        {
            //text email
            ptBEmail.Image = Properties.Resources.email_2;
            txtEmail.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;
        }
        // text 3 leave
        private void MouseLeave_3(object sender, EventArgs e)
        {
            //text phone
            ptBPhone.Image = Properties.Resources.telephone_2;
            txtPhone.ForeColor = Color.Black;
            panel3.BackColor = Color.Black;
        }
        // text 4 leave
        private void MouseLeave_4(object sender, EventArgs e)
        {
            //text password
            ptBPassWord.Image = Properties.Resources.unlock_1;
            txtPassword.ForeColor = Color.Black;
            panel4.BackColor = Color.Black;
        }
        // text 5 leave
        private void MouseLeave_5(object sender, EventArgs e)
        {
            //text confirm bitch
            ptBConFirm.Image = Properties.Resources.log_in_2;
            txtConfirm.ForeColor = Color.Black;
            panel5.BackColor = Color.Black;
        }
        // action click khi click 1 cú xóa toàn bộ text trong textbox 
        private void MouseClick_1(object sender, MouseEventArgs e)
        {
            txtAccountName.Clear();
        }
        private void MouseClick_2(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }
        private void MousClick_3(object sender, MouseEventArgs e)
        {
            txtPhone.Clear();
        }
        private void MouseClick_4(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }
        private void MouseClick_5(object sender, MouseEventArgs e)
        {
            txtConfirm.Clear();
        }
        // action khi bạn click cmn 2 cú bật chế độ focus 
        private void Mouse_Doubleclicked_1(object sender, MouseEventArgs e)
        {
            txtAccountName.Focus();
        }
        private void Mouse_Doubleclicked_2(object sender, MouseEventArgs e)
        {
            txtEmail.Focus();
        }
        private void Mouse_Doubleclicked_3(object sender, MouseEventArgs e)
        {
            txtPhone.Focus();
        }
        private void Mouse_Doubleclicked_4(object sender, MouseEventArgs e)
        {
            txtPassword.Focus();
        }
        private void Mouse_Doubleclicked_5(object sender, MouseEventArgs e)
        {
            txtConfirm.Focus();
        }
        private void Text_Change_PassWord(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }
        private void Text_Changed_Confirm(object sender, EventArgs e)
        {
            txtConfirm.PasswordChar = '•';
        }
        // khi form chay -> tu dong chuyen con tro sang vi tri cuoi cua text ma khong bi focus text
        private void Form3_Load(object sender, EventArgs e)
        {
            int pos1 = txtAccountName.Text.Length;
            txtAccountName.SelectionStart = (pos1 + 1);
        }
    }
}
