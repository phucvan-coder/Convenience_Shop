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
    public partial class FormTypeManagement : Form
    {
        public FormTypeManagement()
        {
            InitializeComponent();
        }

        public bool SIGNAL;

        #region Method
        //Function display information of product type from database to datagridview
        public void DisplayType()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<TypeInfo> typeList = new List<TypeInfo>();
                typeList = entity.TypeOfProducts.Select(x => new TypeInfo
                {
                    Id = x.Id,
                    TypeName = x.TypeName
                }).ToList();
                dgvTypeList.DataSource = typeList;
            }
        }

        //Function Add Type onto database
        public bool AddType(TypeOfProduct typeOfProduct)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.TypeOfProducts.Add(typeOfProduct);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //Function Delete Type From database
        public bool DeleteType()
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                
                TypeOfProduct a = entity.TypeOfProducts.SqlQuery("select * from TypeOfProduct where Id=" + dgvTypeList.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                List<Product> lstProduct = new List<Product>();
                lstProduct = entity.Products.SqlQuery("select * from Product where TypeID=" + dgvTypeList.SelectedRows[0].Cells[0].Value.ToString()).ToList();
                foreach (Product x in lstProduct)
                {
                    List<BillInfo> lstBillInfo = new List<BillInfo>();
                    lstBillInfo = entity.BillInfoes.SqlQuery("select * from BillInfo where ProductID=" + x.Id).ToList();
                    foreach (BillInfo bill in lstBillInfo)
                    {
                        entity.BillInfoes.Remove(bill);
                        entity.SaveChanges();
                    }
                    entity.Products.Remove(x);
                    entity.SaveChanges();
                }
                entity.TypeOfProducts.Remove(a);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormTypeManagement_Load(object sender, EventArgs e)
        {
            DisplayType();

            SIGNAL = false;

            btnUpdateType.Enabled = false;
            btnDeleteType.Enabled = false;

            txtTypeID.Text = "";
            txtTypeName.Text = "";
        }
        //Event Add type onto database
        private void btnAddType_Click(object sender, EventArgs e)
        {
            TypeOfProduct typeOfProduct = new TypeOfProduct();
            typeOfProduct.TypeName = txtTypeName.Text.Trim();

            bool result = AddType(typeOfProduct);
            if (result)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormTypeManagement_Load(sender, e);
        }

        //Event delete Type from database
        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Do you want Delete it?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                bool result = DeleteType();
                if (result)
                {
                    MessageBox.Show("Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FormTypeManagement_Load(sender, e);
            }
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update TypeOfProduct set " +
                    "TypeName = N'" + txtTypeName.Text + "' " +
                    " where Id=" + dgvTypeList.SelectedRows[0].Cells[0].Value.ToString());
                entity.SaveChanges();
                MessageBox.Show("Update Successed!");
                FormTypeManagement_Load(sender, e);
            }
        }

        private void dgvTypeList_SelectionChanged(object sender, EventArgs e)
        {
            if (SIGNAL == true)
            {
                if (dgvTypeList.SelectedRows.Count > 0)
                {
                    if (dgvTypeList.SelectedRows[0].Cells[0].Value != null)
                    {
                        txtTypeID.Text = dgvTypeList.SelectedRows[0].Cells[0].Value.ToString();
                        txtTypeName.Text = dgvTypeList.SelectedRows[0].Cells[1].Value.ToString();
                    }


                }
            }
        }

        private void dgvTypeList_Click(object sender, EventArgs e)
        {
            SIGNAL = true;
            btnDeleteType.Enabled = true;
            btnUpdateType.Enabled = true;

            if (dgvTypeList.SelectedRows.Count > 0)
            {
                if (dgvTypeList.SelectedRows[0].Cells[0].Value != null)
                {
                    txtTypeID.Text = dgvTypeList.SelectedRows[0].Cells[0].Value.ToString();
                    txtTypeName.Text = dgvTypeList.SelectedRows[0].Cells[1].Value.ToString();
                }
            }

        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            string query = txtSearchType.Text.Trim().ToLower();
            List<TypeOfProduct> data = new List<TypeOfProduct>();

            DisplayType();
            foreach (DataGridViewRow a in dgvTypeList.Rows)
            {
                if (a.Cells[0].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[1].Value.ToString().ToLower().Contains(query))
                {
                    TypeOfProduct x = new TypeOfProduct();
                    x.Id = Convert.ToInt32(a.Cells[0].Value);
                    x.TypeName = a.Cells[1].Value.ToString();

                    data.Add(x);
                }

            }

            dgvTypeList.DataSource = data;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormTypeManagement_Load(sender, e);
        }
        #endregion


    }
}
