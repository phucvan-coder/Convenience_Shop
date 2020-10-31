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
        }

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
                    DateOfBirth = x.DateOfBirth,
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
                var a = entity.Staffs.FirstOrDefault();
                entity.Staffs.Remove(a);
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
        }
        //Event add Staff onto database
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Name = txtStaffName.Text;
            staff.DateOfBirth = dtpDateOfBirth.Value;
            staff.Gender = cmbGender.Text;
            staff.Email = txtStaffEmail.Text;
            staff.Phone = txtStaffPhone.Text;
            staff.Address = txtStaffAddress.Text;

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
        #endregion

        private void FormStaffManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }
    }
}
