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
    public partial class FormProductManagement : Form
    {
        public FormProductManagement()
        {
            InitializeComponent();
            ComboboxStatus();
        }
        public int SIGNAL;

        #region Method
        //Function display product onto datagridview
        public void DisplayProduct()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<ProductInfo> productList = new List<ProductInfo>();
                productList = entity.Products.Select(x => new ProductInfo
                {
                    Id = x.Id,
                    TypeName = x.TypeOfProduct.TypeName,
                    ProductName = x.ProductName,
                    Price = x.Price,
                    ProducerName = x.Producer.ProducerName,
                    Status = x.Status
                }).ToList();
                dgvProductList.DataSource = productList;
            }
        }

        public void ComboboxType()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<TypeOfProduct> type = new List<TypeOfProduct>();
                type = entity.TypeOfProducts.ToList();
                cmbType.DataSource = type;
                cmbType.DisplayMember = "TypeName";
                cmbType.ValueMember = "Id";
            }
        }

        public void ComboboxProducer()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<Producer> producer = new List<Producer>();
                producer = entity.Producers.ToList();
                cmbProducer.DataSource = producer;
                cmbProducer.DisplayMember = "ProducerName";
                cmbProducer.ValueMember = "Id";
            }
        }

        public void ComboboxStatus()
        {
            cmbStatus.Items.Add("Status1");
            cmbStatus.Items.Add("Status2");
        }

        //Function add product onto database
        public bool AddProduct(Product product)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Products.Add(product);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //Function delete product from database
        public bool DeleteProduct()
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                if (dgvProductList.SelectedRows.Count > 0)
                {
                    Product a = entity.Products.SqlQuery("select * from Product where Id=" + dgvProductList.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                    entity.Products.Remove(a);
                    entity.SaveChanges();
                    result = true;
                }
                
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            ComboboxProducer();
            ComboboxType();
            SIGNAL = 0;
            btnDeleteProduct.Enabled = false;
            btnUpdateProduct.Enabled = false;

            txtPrice.Text = "";
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductSearch.Text = "";
            cmbProducer.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
        }
        //Event add product onto database
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Price = Convert.ToInt32(txtPrice.Text);
            pro.ProductName = txtProductName.Text;
            pro.TypeID = Convert.ToInt32(cmbType.SelectedValue);
            pro.ProducerID = Convert.ToInt32(cmbProducer.SelectedValue);
            pro.Status = cmbStatus.GetItemText(cmbStatus.SelectedItem);

            bool result = AddProduct(pro); 
            if (result)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormProductManagement_Load(sender, e);
        }
        //Event Delete Product from database
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            bool result = DeleteProduct();
            if (result)
            {
                MessageBox.Show("Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormProductManagement_Load(sender, e);
        }
        #endregion

        private void FormProductManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update Product set " +
                    "TypeID=" + cmbType.SelectedValue + "," +
                    "ProducerID=" + cmbProducer.SelectedValue + "," +
                    "Price=" + txtPrice.Text + ", " +
                    "ProductName='" + txtProductName.Text + "'," +
                    "Status='" + cmbStatus.GetItemText(cmbStatus.SelectedItem) + "'" +
                    " where Id=" + dgvProductList.SelectedRows[0].Cells[0].Value);
                entity.SaveChanges();
                MessageBox.Show("Update Successed!");
                FormProductManagement_Load(sender, e);
            }
        }

        private void dgvProductList_SelectionChanged(object sender, EventArgs e)
        {
            if (SIGNAL == 1)
            {
                if (dgvProductList.SelectedRows.Count > 0)
                {
                    txtProductID.Text = dgvProductList.SelectedRows[0].Cells[0].Value.ToString();
                    cmbType.SelectedIndex = cmbType.FindStringExact(dgvProductList.SelectedRows[0].Cells[1].Value.ToString());
                    txtProductName.Text = dgvProductList.SelectedRows[0].Cells[2].Value.ToString();
                    txtPrice.Text = dgvProductList.SelectedRows[0].Cells[3].Value.ToString();
                    cmbProducer.SelectedIndex = cmbProducer.FindStringExact(dgvProductList.SelectedRows[0].Cells[4].Value.ToString());
                    cmbStatus.SelectedItem = dgvProductList.SelectedRows[0].Cells[5].Value.ToString();

                }
            }
            

        }

        private void dgvProductList_Click(object sender, EventArgs e)
        {
            SIGNAL = 1;
            btnDeleteProduct.Enabled = true;
            btnUpdateProduct.Enabled = true;

            if (dgvProductList.SelectedRows.Count > 0)
            {
                txtProductID.Text = dgvProductList.SelectedRows[0].Cells[0].Value.ToString();
                cmbType.SelectedIndex = cmbType.FindStringExact(dgvProductList.SelectedRows[0].Cells[1].Value.ToString());
                txtProductName.Text = dgvProductList.SelectedRows[0].Cells[2].Value.ToString();
                txtPrice.Text = dgvProductList.SelectedRows[0].Cells[3].Value.ToString();
                cmbProducer.SelectedIndex = cmbProducer.FindStringExact(dgvProductList.SelectedRows[0].Cells[4].Value.ToString());
                cmbStatus.SelectedItem = dgvProductList.SelectedRows[0].Cells[5].Value.ToString();

            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string query = txtProductSearch.Text.ToLower();
            List<ProductInfo> data = new List<ProductInfo>();

            DisplayProduct();
            foreach (DataGridViewRow a in dgvProductList.Rows)
            {
                if (a.Cells[0].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[1].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[2].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[3].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[4].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[5].Value.ToString().ToLower().Contains(query))
                {
                    ProductInfo x = new ProductInfo();
                    x.Id = Convert.ToInt32(a.Cells[0].Value);
                    x.TypeName = a.Cells[1].Value.ToString();
                    x.ProductName = a.Cells[2].Value.ToString();
                    x.Price = Convert.ToDouble(a.Cells[3].Value);
                    x.ProducerName = a.Cells[4].Value.ToString();
                    x.Status = a.Cells[5].Value.ToString();

                    data.Add(x);
                }
                
            }

            dgvProductList.DataSource = data;
        }
    }
}
