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
        #region Construction
        //Create Construction to pass data from FormLogin to FromMenu
        private bool checkPermission;
        public FormMenu(string accountName, string password)
        {
            InitializeComponent();
            checkPermission = CheckPermission(accountName, password);
        }
        #endregion

        #region Method
        //Check permission of person who are logged in
        public bool CheckPermission(string accountName, string password)
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
            return result;
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
            if (checkPermission)
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
        // của label
        private void lbl_Staff_Click(object sender, EventArgs e)
        {
            if (checkPermission)
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
        // vào phần account form
        // của phần picture box
        private void ptrbx_Account_Click(object sender, EventArgs e)
        {
            if (checkPermission)
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
        // của phần label
        private void lbl_Account_Click(object sender, EventArgs e)
        {
            if (checkPermission)
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

        #region Type product mouse event
        // picture box 
        private void ptrbx_Type_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_Type.Image = Properties.Resources.Typeproduct_HOV;
        }

        private void ptrbx_Type_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_Type.Image = Properties.Resources.typeofpro;
        }
        // label
        private void lbl_Type_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_Type.Image = Properties.Resources.Typeproduct_HOV;
        }
        private void lbl_Type_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_Type.Image = Properties.Resources.typeofpro;
        }
        #endregion

        #region Product mouse event
        // picture box
        private void ptrbx_product_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_product.Image = Properties.Resources.clipboard_HOV;
        }

        private void ptrbx_product_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_product.Image = Properties.Resources.clipboard;
        }
        // label
        private void lbl_Product_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_product.Image = Properties.Resources.clipboard_HOV;
        }
        private void lbl_Product_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_product.Image = Properties.Resources.clipboard;
        }
        #endregion

        #region porudcer mouse event
        // picture box
        private void ptrbx_Producer_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_Producer.Image = Properties.Resources.Producer_HOV;
        }

        private void ptrbx_Producer_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_Producer.Image = Properties.Resources.Producer_IMG;
        }
        // label
        private void lbl_Producer_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_Producer.Image = Properties.Resources.Producer_HOV;
        }
        private void lbl_Producer_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_Producer.Image = Properties.Resources.Producer_IMG;
        }
        #endregion

        #region staff mouse event
        // picture box
        private void ptbx_Staff_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Staff.Image = Properties.Resources.Staff_HOV;
        }
        private void ptbx_Staff_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Staff.Image = Properties.Resources.Staff_IMG;
        }
        // label
        private void lbl_Staff_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Staff.Image = Properties.Resources.Staff_HOV;
        }
        private void lbl_Staff_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Staff.Image = Properties.Resources.Staff_IMG;
        }
        #endregion

        #region account mouse event
        // picturebox
        private void ptrbx_Account_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_Account.Image = Properties.Resources.Account_HOV;
        }

        private void ptrbx_Account_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_Account.Image = Properties.Resources.Account_IMG;
        }
        // label
        private void lbl_Account_MouseEnter(object sender, EventArgs e)
        {
            ptrbx_Account.Image = Properties.Resources.Account_HOV;
        }

        private void lbl_Account_MouseLeave(object sender, EventArgs e)
        {
            ptrbx_Account.Image = Properties.Resources.Account_IMG;
        }
        #endregion

        #region bill mouse event
        // picture box
        private void ptbx_Bill_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Bill.Image = Properties.Resources.Bill_HOV;
        }

        private void ptbx_Bill_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Bill.Image = Properties.Resources.Bill_IMG;
        }
        // label
        private void lbl_Bill_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Bill.Image = Properties.Resources.Bill_HOV;
        }

        private void lbl_Bill_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Bill.Image = Properties.Resources.Bill_IMG;
        }
        #endregion

        #region sale mouse event
        // pivture box
        private void ptbx_Sale_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Sale.Image = Properties.Resources.Cart_HOV;
        }

        private void ptbx_Sale_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Sale.Image = Properties.Resources.Cart_IMG;
        }
        //label
        private void lbl_Sale_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Sale.Image = Properties.Resources.Cart_HOV;
        }

        private void lbl_Sale_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Sale.Image = Properties.Resources.Cart_IMG;
        }
        #endregion

        #region logout mouse event
        // picture box
        private void ptbx_Logout_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Logout.Image = Properties.Resources.Logout_HOV;
        }

        private void ptbx_Logout_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Logout.Image = Properties.Resources.log_out;
        }
        // label
        private void lbl_Logout_MouseEnter(object sender, EventArgs e)
        {
            ptbx_Logout.Image = Properties.Resources.Logout_HOV;
        }

        private void lbl_Logout_MouseLeave(object sender, EventArgs e)
        {
            ptbx_Logout.Image = Properties.Resources.log_out;
        }
        #endregion
    }
}
