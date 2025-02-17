﻿using MyProJect.Object;
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
                    Status = x.Status,
                    Amount = x.Amount,
                    Date = x.Date.Value.Day + "/" + x.Date.Value.Month + "/" + x.Date.Value.Year
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
            cmbStatus.Items.Add("Còn Hạn");
            cmbStatus.Items.Add("Hết Hạn");
        }

        //Function add product onto database
        public bool AddProduct(Product product)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                Product test = new Product();
                test = entity.Products.Where(x => x.ProductName == product.ProductName && x.TypeID == product.TypeID && x.ProducerID == product.ProducerID).FirstOrDefault();
                if (test != null)
                {
                    entity.Database.ExecuteSqlCommand("update Product set " +
                        " Amount = " + Convert.ToInt32(product.Amount + test.Amount) + ", " +
                        " Price = " + Convert.ToInt32(product.Price) + ", " +
                        " Date = '" + (dtpDate.Value.Year + "/" + dtpDate.Value.Month + "/" + dtpDate.Value.Day) + "' " +
                        " where ProductName= N'" + product.ProductName + "' and " +
                        " TypeID = " + product.TypeID + " and" +
                        " ProducerID =  " + product.ProducerID);

                    entity.Database.ExecuteSqlCommand("update Product set " +
                        " Price = " + (product.Price) + " " +
                        " where ProductName = N'" + product.ProductName + "' and " +
                        " TypeID =" + product.TypeID);

                    entity.SaveChanges();
                    return true;
                }

                test = entity.Products.Where(x => x.ProductName == product.ProductName && x.TypeID == product.TypeID).FirstOrDefault();
                if (test != null)
                {
                    entity.Database.ExecuteSqlCommand("update Product set " +
                        " Price = " + (product.Price) + " " +
                        " where ProductName= N'" + product.ProductName + "' and " +
                        " TypeID = " + product.TypeID);
                    entity.SaveChanges();
                }

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
                    Product a = entity.Products.SqlQuery("select * from Product where Id = " + dgvProductList.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                    List<BillInfo> lstBillInfo = new List<BillInfo>();
                    lstBillInfo = entity.BillInfoes.SqlQuery("select * from BillInfo where ProductID = " + a.Id).ToList();
                    foreach (BillInfo x in lstBillInfo)
                    {
                        entity.BillInfoes.Remove(x);
                        entity.SaveChanges();
                    }
                    entity.Products.Remove(a);
                    entity.SaveChanges();
                    result = true;
                }
                
            }
            return result;
        }

        public void ValidateInput()
        {
            if (txtProductName.Text == string.Empty)
            {
                MessageBox.Show("Please Type Product's Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }


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
            nmrAmount.Value = 0;
            dtpDate.Value = DateTime.Now;
        }
        //Event add product onto database
        private void btnAddProduct_Click(object sender, EventArgs e)
        {   

            Product pro = new Product();
            pro.Price = Convert.ToInt32(txtPrice.Text.Trim());
            pro.ProductName = txtProductName.Text.Trim();
            pro.TypeID = Convert.ToInt32(cmbType.SelectedValue);
            pro.ProducerID = Convert.ToInt32(cmbProducer.SelectedValue);
            pro.Status = cmbStatus.GetItemText(cmbStatus.SelectedItem);
            pro.Amount = Convert.ToInt32(nmrAmount.Value);
            pro.Date = Convert.ToDateTime(dtpDate.Value.Day + "/" + dtpDate.Value.Month + "/" + dtpDate.Value.Year);

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

            DialogResult res = MessageBox.Show("Do you want Delete it?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
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
            
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update Product set " +
                    "TypeID = " + cmbType.SelectedValue + "," +
                    "ProducerID = " + cmbProducer.SelectedValue + "," +
                    "Price = " + txtPrice.Text + ", " +
                    "ProductName = N'" + txtProductName.Text + "'," +
                    " Amount = " + nmrAmount.Value + ", " +
                    " Date = '" + (dtpDate.Value.Year + "/" + dtpDate.Value.Month + "/" + dtpDate.Value.Day) + "', " +
                    "Status = N'" + cmbStatus.GetItemText(cmbStatus.SelectedItem) + "'" +
                    " where Id = " + dgvProductList.SelectedRows[0].Cells[0].Value);

                entity.Database.ExecuteSqlCommand("update Product set " +
                    " Price=" + txtPrice.Text + " " +
                    " where ProductName= N'" + txtProductName.Text + "' and " +
                    " TypeID =" + cmbType.SelectedValue);

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
                    nmrAmount.Value = Convert.ToInt32(dgvProductList.SelectedRows[0].Cells[6].Value.ToString());
                    dtpDate.Value = Convert.ToDateTime(dgvProductList.SelectedRows[0].Cells[7].Value.ToString());

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
                nmrAmount.Value = Convert.ToInt32(dgvProductList.SelectedRows[0].Cells[6].Value.ToString());
                dtpDate.Value = Convert.ToDateTime(dgvProductList.SelectedRows[0].Cells[7].Value.ToString());

            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string query = txtProductSearch.Text.Trim().ToLower();
            List<ProductInfo> data = new List<ProductInfo>();

            DisplayProduct();
            foreach (DataGridViewRow a in dgvProductList.Rows)
            {
                if (a.Cells[0].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[1].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[2].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[4].Value.ToString().ToLower().Contains(query) )
                {
                    ProductInfo x = new ProductInfo();
                    x.Id = Convert.ToInt32(a.Cells[0].Value);
                    x.TypeName = a.Cells[1].Value.ToString();
                    x.ProductName = a.Cells[2].Value.ToString();
                    x.Price = Convert.ToDouble(a.Cells[3].Value);
                    x.ProducerName = a.Cells[4].Value.ToString();
                    x.Status = a.Cells[5].Value.ToString();
                    x.Amount = Convert.ToInt32(a.Cells[5].Value.ToString());
                    x.Date = a.Cells[5].Value.ToString();

                    data.Add(x);
                }

            }

            dgvProductList.DataSource = data;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrice.Text == string.Empty && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (txtPrice.Text.Count(c => c == '.') == 1 && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar < (char)Keys.D0 || e.KeyChar > (char)Keys.D9) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        #endregion

        private void nmrAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormProductManagement_Load(sender, e);
        }
    }
}
