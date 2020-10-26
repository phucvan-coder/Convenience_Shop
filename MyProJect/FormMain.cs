using System;
using System.Windows.Forms;
using MyProJect;

namespace MyProJect
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // nút login
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //gọi form 2 xuất hiện
            FormLogin f2 = new FormLogin();
            f2.Show();
        }
        // nút Sign up
        private void button2_Click(object sender, EventArgs e)
        {
            // ẩn 1 lần nữa để có form 3 form đy kắng
            this.Hide();
            FormSignUp f3 = new FormSignUp();
            // show form 3 -> kêu form 3 hiện hồn 
            f3.Show();
        }
        // phần này lỡ bấm lộn mà đã bấm lộn bấm lại thì lại cũng lại lại bấm lộn
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        // hỏi han tình hình khi form nó đang đóng 
        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            // hỏi có chắc cchắn muốn đóng ko
            string message = "Are you sure want to close this?";
            string title = "Close";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon question = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, question);
            // nếu có thì thoát khỏi môi trường hiện tại để bảo vệ môi trường
            if (result == DialogResult.Yes)
                System.Environment.Exit(1);
            // nếu ko thì quay về form hiện tại
            else
                e.Cancel = true;

        }
    }
}
