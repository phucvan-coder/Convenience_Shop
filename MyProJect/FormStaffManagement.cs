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
    public partial class FormStaffManagement : Form
    {
        public FormStaffManagement()
        {
            InitializeComponent();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
        }
        public bool SIGNAL;

        #region Method
        //Function display information of Staff from database to datagridview
        public void DisplayStaff()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<StaffInfo> staffList = new List<StaffInfo>();
                staffList = entity.Staffs.Select(x => new StaffInfo
                {
                    Id = x.Id,
                    Name = x.Name,
                    DateOfBirth = x.DateOfBirth.Value.Day + "/" + x.DateOfBirth.Value.Month + "/" + x.DateOfBirth.Value.Year,
                    Gender = x.Gender,
                    Email = x.Email,
                    Phone = x.Phone,
                    Address = x.Address
                }).ToList();
                dgvStaffList.DataSource = staffList;
            }
        }

        //Function Add Staff onto database
        public bool AddStaff(Staff staff)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Staffs.Add(staff);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //Function Delete Staff From database
        public bool DeleteStaff()
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                Staff a = entity.Staffs.SqlQuery("select * from Staff where Id=" + dgvStaffList.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                entity.Staffs.Remove(a);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormStaffManagement_Load(object sender, EventArgs e)
        {
            DisplayStaff();

            SIGNAL = false;
            btnUpdateStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;

            txtStaffID.Text = "";
            txtSearchStaff.Text = "";
            txtStaffAddress.Text = "";
            txtStaffEmail.Text = "";
            txtStaffName.Text = "";
            txtStaffPhone.Text = "";
            cmbGender.SelectedIndex = -1;
        }
        //Event add Staff onto database
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Name = txtStaffName.Text.Trim();
            staff.DateOfBirth = dtpDateOfBirth.Value;
            staff.Gender = cmbGender.Text;
            staff.Email = txtStaffEmail.Text.Trim();
            staff.Phone = txtStaffPhone.Text.Trim();
            staff.Address = txtStaffAddress.Text.Trim();

            bool result = AddStaff(staff);
            if (result)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormStaffManagement_Load(sender, e);
        }
        //Event delete Staff from database
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want Delete it?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                bool result = DeleteStaff();
                if (result)
                {
                    MessageBox.Show("Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FormStaffManagement_Load(sender, e);
            }
            
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string DOB = dtpDateOfBirth.Value.Day + "/" + dtpDateOfBirth.Value.Month + "/" + dtpDateOfBirth.Value.Year;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update Staff set " +
                    "Name = N'" + txtStaffName.Text + "', " +
                    "Gender = N'" + cmbGender.GetItemText(cmbGender.SelectedItem) + "', " +
                    "Email = N'" + txtStaffEmail.Text + "', " +
                    "Phone = N'" + txtStaffPhone.Text + "', " +
                    "Address = N'" + txtStaffAddress.Text + "', " +
                    "DateOfBirth = N'" + Convert.ToDateTime(DOB) + "' " +
                    " where Id=" + dgvStaffList.SelectedRows[0].Cells[0].Value.ToString());
                entity.SaveChanges();
                MessageBox.Show("Update Successed!");
                FormStaffManagement_Load(sender, e);
            }
        }

        private void dgvStaffList_SelectionChanged(object sender, EventArgs e)
        {
            if (SIGNAL == true)
            {
                if (dgvStaffList.SelectedRows.Count > 0)
                {
                    txtStaffID.Text = dgvStaffList.SelectedRows[0].Cells[0].Value.ToString();
                    txtStaffName.Text = dgvStaffList.SelectedRows[0].Cells[1].Value.ToString();
                    dtpDateOfBirth.Value = Convert.ToDateTime(dgvStaffList.SelectedRows[0].Cells[2].Value.ToString());
                    cmbGender.SelectedItem = dgvStaffList.SelectedRows[0].Cells[3].Value.ToString();
                    txtStaffEmail.Text = dgvStaffList.SelectedRows[0].Cells[4].Value.ToString();
                    txtStaffPhone.Text = dgvStaffList.SelectedRows[0].Cells[5].Value.ToString();
                    txtStaffAddress.Text = dgvStaffList.SelectedRows[0].Cells[6].Value.ToString();

                }
            }
        }

        private void dgvStaffList_Click(object sender, EventArgs e)
        {
            SIGNAL = true;

            btnDeleteStaff.Enabled = true;
            btnUpdateStaff.Enabled = true;

            if (dgvStaffList.SelectedRows.Count > 0)
            {
                txtStaffID.Text = dgvStaffList.SelectedRows[0].Cells[0].Value.ToString();
                txtStaffName.Text = dgvStaffList.SelectedRows[0].Cells[1].Value.ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(dgvStaffList.SelectedRows[0].Cells[2].Value.ToString());
                cmbGender.SelectedItem = dgvStaffList.SelectedRows[0].Cells[3].Value.ToString();
                txtStaffEmail.Text = dgvStaffList.SelectedRows[0].Cells[4].Value.ToString();
                txtStaffPhone.Text = dgvStaffList.SelectedRows[0].Cells[5].Value.ToString();
                txtStaffAddress.Text = dgvStaffList.SelectedRows[0].Cells[6].Value.ToString();

            }

        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string query = txtSearchStaff.Text.Trim().ToLower();
            List<StaffInfo> data = new List<StaffInfo>();

            DisplayStaff();
            foreach (DataGridViewRow a in dgvStaffList.Rows)
            {
                if (a.Cells[0].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[1].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[2].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[3].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[4].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[5].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[6].Value.ToString().ToLower().Contains(query))
                {
                    StaffInfo x = new StaffInfo();
                    x.Id = Convert.ToInt32(a.Cells[0].Value);
                    x.Name = a.Cells[1].Value.ToString();
                    x.DateOfBirth = a.Cells[2].Value.ToString();
                    x.Gender = a.Cells[3].Value.ToString();
                    x.Email = a.Cells[4].Value.ToString();
                    x.Phone = a.Cells[5].Value.ToString();
                    x.Address = a.Cells[6].Value.ToString();

                    data.Add(x);
                }

            }

            dgvStaffList.DataSource = data;
        }

        private void txtStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
