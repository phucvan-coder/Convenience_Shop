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
        }

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
                var a = entity.Products.FirstOrDefault();
                entity.Products.Remove(a);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            DisplayProduct();
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
    }
}
