using MyProJect.Object;
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
    public partial class FormAccountManagement : Form
    {
        public FormAccountManagement()
        {
            InitializeComponent();
        }

        #region Method
        //Function display information of Account from database to datagridview
        public void DisplayAccount()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<AccountInfo> accountList = new List<AccountInfo>();
                accountList = entity.Accounts.Select(x => new AccountInfo
                {
                    Id = x.Id,
                    AccountName = x.AccountName,
                    Password = x.Password
                }).ToList();
                dgvAccountList.DataSource = accountList;
            }
        }

        //Function Add Account onto database
        public bool AddAccount(Account account)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Accounts.Add(account);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //Function Delete Account From database
        public bool DeleteAccount()
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                var a = entity.Accounts.FirstOrDefault();
                entity.Accounts.Remove(a);
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            DisplayAccount();
        }
        //Event add Account onto database
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.AccountName = txtAccountName.Text;
            account.Password = txtPassword.Text;

            bool result = AddAccount(account);
            if (result)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormAccountManagement_Load(sender, e);
        }
        //Event delete Account from database
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            bool result = DeleteAccount();
            if (result)
            {
                MessageBox.Show("Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormAccountManagement_Load(sender, e);
        }

        #endregion

        private void FormAccountManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }
    }
}
