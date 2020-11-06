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
        #region Delegate
        //Create delegate to pass data from FormLogin to FromMenu
        public delegate void PassData(string accountName, string password);
        public PassData passData;
        #endregion

        #region Method
        //Check permission of person who are logged in
        public void CheckStaffManagementPermission(string accountName, string password)
        {
            bool result = false;
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                string check = entity.Accounts.Where(x => x.AccountName == accountName && x.Password == password).FirstOrDefault().Rank;
                if(check == "Quản Lý")
                {
                    result = true;
                }
            }
            if (result)
            {
                this.Hide();
                FormStaffManagement formStaff = new FormStaffManagement();
                formStaff.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Access is not allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CheckAccountManagementPermission(string accountName, string password)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                string check = entity.Accounts.Where(x => x.AccountName == accountName && x.Password == password).FirstOrDefault().Rank;
                if (check == "Quản Lý")
                {
                    result = true;
                }
            }
            if (result)
            {
                this.Hide();
                FormAccountManagement formAccount = new FormAccountManagement();
                formAccount.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Access is not allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Event
        // vào loại sp type manage
        // phần của picture box
        private void ptrbx_Type_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTypeManagement formType = new FormTypeManagement();
            formType.ShowDialog();
            this.Show();
        }
        // phần của label
        private void lbl_Type_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTypeManagement formType = new FormTypeManagement();
            formType.ShowDialog();
            this.Show();
        }
        // vào product manage
        // của picture box
        private void ptrbx_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement formProduct = new FormProductManagement();
            formProduct.ShowDialog();
            this.Show();
        }
        // của label 
        private void lbl_Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement formProduct = new FormProductManagement();
            formProduct.ShowDialog();
            this.Show();
        }
        // vào form producer
        // của phần picture box
        private void ptrbx_Producer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProducerManagement formProducer = new FormProducerManagement();
            formProducer.ShowDialog();
            this.Show();
        }
        // của label
        private void lbl_Producer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProducerManagement formProducer = new FormProducerManagement();
            formProducer.ShowDialog();
            this.Show();
        }
        // vào form staff manage
        // của picture box
        private void ptbx_Staff_Click(object sender, EventArgs e)
        {
            passData = new PassData(CheckStaffManagementPermission);
        }
        // của label
        private void lbl_Staff_Click(object sender, EventArgs e)
        {
            passData = new PassData(CheckStaffManagementPermission);
        }
        // vào phần account form
        // của phần picture box
        private void ptrbx_Account_Click(object sender, EventArgs e)
        {
            passData = new PassData(CheckAccountManagementPermission);
        }
        // của phần label
        private void lbl_Account_Click(object sender, EventArgs e)
        {
            passData = new PassData(CheckAccountManagementPermission);
        }
        // vào form bill manage
        // cảu picture box
        private void ptbx_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBillManagement formBill = new FormBillManagement();
            formBill.ShowDialog();
            this.Show();
        }
        // của label
        private void lbl_Bill_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBillManagement formBill = new FormBillManagement();
            formBill.ShowDialog();
            this.Show();
        }
        // vào form sale 
        // của phần picture box
        private void ptbx_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSale sale = new FormSale();
            sale.ShowDialog();
            this.Show();
        }
        // của label
        private void lbl_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSale sale = new FormSale();
            sale.ShowDialog();
            this.Show();
        }
        // logout ra cmn ngoài
        //từ picture box
        private void ptbx_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // từ label
        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // action close form
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
