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
        public bool SIGNAL;
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
                    Password = x.Password,
                    Rank = x.Rank
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
                if (dgvAccountList.SelectedRows.Count > 0)
                {
                    Account a = entity.Accounts.SqlQuery("select * from Account where Id = " + dgvAccountList.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                    entity.Accounts.Remove(a);
                    entity.SaveChanges();
                    result = true;
                }
                
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            DisplayAccount();

            SIGNAL = false;
            btnUpdateAccount.Enabled = false;
            btnDeleteAccount.Enabled = false;

            txtAccountID.Text = "";
            txtAccountName.Text = "";
            txtPassword.Text = "";
            cmbRank.Text = "";
        }
        //Event add Account onto database
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.AccountName = txtAccountName.Text.Trim();
            account.Password = txtPassword.Text.Trim();
            account.Rank = cmbRank.Text.Trim();

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
            DialogResult res = MessageBox.Show("Do you want Delete it?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
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
            
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update Account set " +
                    "AccountName = N'" + txtAccountName.Text + "', " +
                    "Password = N'" + txtPassword.Text + "', " +
                    "Rank = N'" + cmbRank.Text + "' " +
                    " where Id = " + dgvAccountList.SelectedRows[0].Cells[0].Value.ToString());
                entity.SaveChanges();
                MessageBox.Show("Update Successed!");
                FormAccountManagement_Load(sender, e);
            }
        }

        private void dgvAccountList_SelectionChanged(object sender, EventArgs e)
        {
            if (SIGNAL == true)
            {
                if (dgvAccountList.SelectedRows.Count > 0)
                {
                    txtAccountID.Text = dgvAccountList.SelectedRows[0].Cells[0].Value.ToString();
                    txtAccountName.Text = dgvAccountList.SelectedRows[0].Cells[1].Value.ToString();
                    txtPassword.Text = dgvAccountList.SelectedRows[0].Cells[2].Value.ToString();
                    cmbRank.Text = dgvAccountList.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
        }

        private void dgvAccountList_Click(object sender, EventArgs e)
        {
            SIGNAL = true;
            btnDeleteAccount.Enabled = true;
            btnUpdateAccount.Enabled = true;


            if (dgvAccountList.SelectedRows.Count > 0)
            {
                txtAccountID.Text = dgvAccountList.SelectedRows[0].Cells[0].Value.ToString();
                txtAccountName.Text = dgvAccountList.SelectedRows[0].Cells[1].Value.ToString();
                txtPassword.Text = dgvAccountList.SelectedRows[0].Cells[2].Value.ToString();
                cmbRank.Text = dgvAccountList.SelectedRows[0].Cells[3].Value.ToString();
            }

        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string query = txtSearchAccount.Text.ToLower().Trim();
            List<AccountInfo> data = new List<AccountInfo>();

            DisplayAccount();
            foreach (DataGridViewRow a in dgvAccountList.Rows)
            {
                if (a.Cells[0].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[1].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[2].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[3].Value.ToString().ToLower().Contains(query))
                {
                    AccountInfo x = new AccountInfo();
                    x.Id = Convert.ToInt32(a.Cells[0].Value);
                    x.AccountName = a.Cells[1].Value.ToString();
                    x.Password = a.Cells[2].Value.ToString();
                    x.Rank = a.Cells[3].Value.ToString();
                    data.Add(x);
                }

            }

            dgvAccountList.DataSource = data;
        }
        #endregion
    }
}
