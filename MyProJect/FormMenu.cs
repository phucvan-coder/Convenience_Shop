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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        // vào loại sp type manage
        // phần của picture box
        private void ptrbx_Type_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTypeManagement formType = new FormTypeManagement();
            formType.Show();
        }
        // phần của label
        private void lbl_Type_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormTypeManagement formType = new FormTypeManagement();
            formType.Show();
        }
        // vào product manage
        // của picture box
        private void ptrbx_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement formProduct = new FormProductManagement();
            formProduct.Show();
        }
        // của label 
        private void lbl_Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement formProduct = new FormProductManagement();
            formProduct.Show();
        }
        // vào form producer
        // của phần picture box
        private void ptrbx_Producer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProducerManagement formProducer = new FormProducerManagement();
            formProducer.Show();
        }
        // của label
        private void lbl_Producer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProducerManagement formProducer = new FormProducerManagement();
            formProducer.Show();
        }
        // vào form staff manage
        // của picture box
        private void ptbx_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaffManagement formStaff = new FormStaffManagement();
            formStaff.Show();
        }
        // của label
        private void lbl_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaffManagement formStaff = new FormStaffManagement();
            formStaff.Show();
        }
        // vào phần account form
        // của phần picture box
        private void ptrbx_Account_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccountManagement formAccount = new FormAccountManagement();
            formAccount.Show();
        }
        // của phần label
        private void lbl_Account_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccountManagement formAccount = new FormAccountManagement();
            formAccount.Show();
        }
        // vào form bill manage
        // cảu picture box
        private void ptbx_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBillManagement formBill = new FormBillManagement();
            formBill.Show();
        }
        // của label
        private void lbl_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBillManagement formBill = new FormBillManagement();
            formBill.Show();
        }
        // vào form sale 
        // của phần picture box
        private void ptbx_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSale sale = new FormSale();
            sale.Show();
        }
        // của label
        private void lbl_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSale sale = new FormSale();
            sale.Show();
        }
        // logout ra cmn ngoài
        //từ picture box
        private void ptbx_Logout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to logout?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon boxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, boxIcon);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormMain main = new FormMain();
                main.Show();
            }
        }
        // từ label
        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to logout?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon boxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, boxIcon);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormMain main = new FormMain();
                main.Show();
            }
        }
        // action close form
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure want to logout?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon boxIcon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, boxIcon);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormMain main = new FormMain();
                main.Show();
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
