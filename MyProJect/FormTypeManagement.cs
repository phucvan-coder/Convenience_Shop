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
            typeOfProduct.TypeName = txtTypeName.Text;

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


        #endregion

        private void FormTypeManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update TypeOfProduct set " +
                    "TypeName='" + txtTypeName.Text + "' " +
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
                    txtTypeID.Text = dgvTypeList.SelectedRows[0].Cells[0].Value.ToString();
                    txtTypeName.Text = dgvTypeList.SelectedRows[0].Cells[1].Value.ToString();

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
                txtTypeID.Text = dgvTypeList.SelectedRows[0].Cells[0].Value.ToString();
                txtTypeName.Text = dgvTypeList.SelectedRows[0].Cells[1].Value.ToString();

            }

        }
    }
}
