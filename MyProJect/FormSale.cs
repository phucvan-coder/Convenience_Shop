using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProJect
{
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }

        public bool SIGNAL;
        private int index;
        #region Method
        //Function display Type on combobox
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
        //Function display Type on combobox
        public void ComboboxProduct()
        {
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<Product> product = new List<Product>();
                product = entity.Products.Where(x => x.TypeOfProduct.TypeName == cmbType.Text).ToList();
                product = product.GroupBy(x => x.ProductName).Select(y => y.First()).OrderBy(z => z.ProductName).ToList();
                
                cmbProduct.DataSource = product;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "Id";
            }
        }
        //Function display total cost
        public void DisplayTotalCost()
        {
            double totalCost = 0;
            foreach(DataGridViewRow a in dgvOrderList.Rows)
            {
                totalCost += Convert.ToDouble(a.Cells[6].Value);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalCost.Text = totalCost.ToString("c",culture);
        }
        //Function save Bill onto database
        public void SaveBill(Bill bill)
        {
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Bills.Add(bill);
                entity.SaveChanges();

            }
        }
        //Function save orders onto database
        public int SaveOrder(BillInfo billInfo)
        {
            int result = 0;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.BillInfoes.Add(billInfo);
                entity.SaveChanges();
                result = 1;
            }
            return result;
        }
        //Function check status of product
        public bool CheckStatus(string product, int price)
        {
            bool result = false;
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {

                List<Product> tmp = new List<Product>();
                tmp = entity.Products.Where(x => x.ProductName == cmbProduct.Text && x.Price == price).ToList();
                int amountAll = 0;
                foreach (Product ii in tmp)
                {
                    amountAll += Convert.ToInt32(ii.Amount);
                }
                if (amountAll >= Convert.ToInt32(nmrAmount.Value))
                {
                    result = true;
                }
            }
            return result;
        }
        #endregion

        #region Event
        //Event add
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            List<Product> tmp = new List<Product>();
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                int idx = Convert.ToInt32(cmbType.SelectedValue);
                tmp = entity.Products.Where(x => x.ProductName == cmbProduct.Text && x.TypeID == idx).ToList();
            }
            int amountAll = 0; 
            foreach (Product ii in tmp)
            {
                amountAll += Convert.ToInt32(ii.Amount);
            }

            if (amountAll < Convert.ToInt32(nmrAmount.Value))
            {
                MessageBox.Show("Not Enough Amount! Available is " + amountAll, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nmrAmount.Value = Convert.ToInt32(amountAll);
                return;
            }
            if (cmbType.SelectedIndex == -1 || cmbProduct.SelectedIndex == -1 || nmrAmount.Value == 0)
            {
                return;
            }
            else
            {
                Product pro = new Product();
                using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
                {
                    int idx = Convert.ToInt32(cmbType.SelectedValue);
                    pro = entity.Products.Where(x => x.ProductName == cmbProduct.Text && x.TypeID == idx).FirstOrDefault();
                }
                bool result = CheckStatus(cmbProduct.Text, Convert.ToInt32(pro.Price));
                if (result)
                {
                    using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
                    {
                        var price = Convert.ToDouble(entity.Products.Where(x => x.ProductName == cmbProduct.Text).First().Price);
                        double totalPrice = (Convert.ToInt32(nmrAmount.Value) * price) - (Convert.ToInt32(nmrAmount.Value) * price * Convert.ToInt32(nmrDiscount.Value) / 100);
                        string[] order = new string[] { cmbType.Text, cmbProduct.Text, dtpSaleDate.Value.ToString("dd/MM/yyyy"), nmrAmount.Value.ToString(), price.ToString(), nmrDiscount.Value.ToString(), totalPrice.ToString() };
                        
                        
                        for (int i = 0; i <= dgvOrderList.Rows.Count -1; i++)
                        {
                            DataGridViewRow row = dgvOrderList.Rows[i];
                            if (row.Cells[0].Value != null)
                            {
                                if (amountAll < Convert.ToInt32(nmrAmount.Value) + Convert.ToInt32(row.Cells[3].Value))
                                {
                                    MessageBox.Show("Not Enough Amount! Available is " + ( amountAll - Convert.ToInt32(row.Cells[3].Value)).ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    nmrAmount.Value = (amountAll - Convert.ToInt32(row.Cells[3].Value));
                                    return;
                                }
                                if (row.Cells[1].Value.ToString() == pro.ProductName && row.Cells[0].Value.ToString() == cmbType.Text)
                                {
                                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(nmrAmount.Value);
                                    row.Cells[6].Value = Convert.ToInt32(row.Cells[3].Value)*Convert.ToInt32(row.Cells[4].Value);
                                    row.Cells[6].Value = Convert.ToInt32(row.Cells[6].Value) - Convert.ToInt32(row.Cells[6].Value) * (Convert.ToDouble(row.Cells[5].Value) / 100.0);
                                    FormSale_Load(sender, e);
                                    return;
                                }
                            }
                        }
                        
                        dgvOrderList.Rows.Add(order);
                        FormSale_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Product is not enough!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        //Event delete
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgvOrderList.Rows.Count == 1)
            {
                MessageBox.Show("The list is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvOrderList.Rows.RemoveAt(dgvOrderList.Rows[0].Index);
                    
            }
            FormSale_Load(sender, e);
        }
        //Event update 
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<Product> tmp = new List<Product>();
                int idx = Convert.ToInt32(cmbType.SelectedValue);
                tmp = entity.Products.Where(x => x.ProductName == cmbProduct.Text && x.TypeID == idx).ToList();
                int amountAll = 0;
                foreach (Product ii in tmp)
                {
                    amountAll += Convert.ToInt32(ii.Amount);
                }

                if (amountAll < Convert.ToInt32(nmrAmount.Value))
                {
                    MessageBox.Show("Not Enough Amount! Available is " + amountAll, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nmrAmount.Value = Convert.ToInt32(amountAll);
                    return;
                }

                var price = Convert.ToDouble(entity.Products.Where(x => x.ProductName == cmbProduct.Text).First().Price);
                double totalPrice = (Convert.ToInt32(nmrAmount.Value) * price) - (Convert.ToInt32(nmrAmount.Value) * price * Convert.ToInt32(nmrDiscount.Value) / 100);
                dgvOrderList.Rows[index].Cells[0].Value = cmbType.Text;
                dgvOrderList.Rows[index].Cells[1].Value = cmbProduct.Text;
                dgvOrderList.Rows[index].Cells[2].Value = dtpSaleDate.Value.ToString("dd/MM/yyyy");
                dgvOrderList.Rows[index].Cells[3].Value = nmrAmount.Value;
                dgvOrderList.Rows[index].Cells[4].Value = price;
                dgvOrderList.Rows[index].Cells[5].Value = nmrDiscount.Value;
                dgvOrderList.Rows[index].Cells[6].Value = totalPrice;

                FormSale_Load(sender, e);
            }
        }
        //Event choose cell
        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderList.Focus();
            index = e.RowIndex;
            if (dgvOrderList.Rows[index].Cells[0].Value != null)
            {
                cmbType.Text = dgvOrderList.Rows[index].Cells[0].Value.ToString();
                cmbProduct.Text = dgvOrderList.Rows[index].Cells[1].Value.ToString();
                dtpSaleDate.Value = Convert.ToDateTime(dgvOrderList.Rows[index].Cells[2].Value);
                nmrAmount.Value = Convert.ToInt32(dgvOrderList.Rows[index].Cells[3].Value);
                nmrDiscount.Value = Convert.ToInt32(dgvOrderList.Rows[index].Cells[5].Value);
            }
            
        }
        //Event payment
        private void btnPayment_Click(object sender, EventArgs e)
        {
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                Bill bill = new Bill();
                bill.DateOfSale = dtpSaleDate.Value;
                SaveBill(bill);
                Bill tmp = new Bill();
                tmp = entity.Bills.SqlQuery("Select * from Bill order by Id DESC").FirstOrDefault();

                int idx = tmp.Id;

                int result = 0;

                

                for (int i = 0; i < dgvOrderList.Rows.Count - 1; i++)
                {
                    
                    BillInfo billInfo = new BillInfo();
                    DataGridViewRow row = dgvOrderList.Rows[i];
                    billInfo.BillID = idx;
                    billInfo.TypeID = entity.TypeOfProducts.SqlQuery("Select * from TypeOfProduct where TypeName = N'" + row.Cells[0].Value.ToString() + "'").FirstOrDefault().Id;
                    billInfo.ProductID = entity.Products.SqlQuery("Select * from Product where ProductName = N'" + row.Cells[1].Value.ToString() + "'").FirstOrDefault().Id;
                    billInfo.Amount = Convert.ToInt32(row.Cells[3].Value);
                    billInfo.Discount = Convert.ToInt32(row.Cells[5].Value);
                    billInfo.TotalPrice = Convert.ToInt32(row.Cells[6].Value);
                    result = SaveOrder(billInfo);

                    List<Product> t = new List<Product>();
                    t = entity.Products.SqlQuery("select * from Product where ProductName= N'" + row.Cells[1].Value.ToString() + "' " +
                                                    " and TypeID="+ billInfo.TypeID + " " +
                                                    " and Amount > 0").ToList();
                    foreach (Product ii in t)
                    {
                        if (billInfo.Amount <= ii.Amount)
                        {
                            entity.Database.ExecuteSqlCommand("update Product set Amount="+ (ii.Amount - billInfo.Amount) + " where Id=" + ii.Id);
                            entity.SaveChanges();
                            break;
                        }
                        entity.Database.ExecuteSqlCommand("update Product set Amount= 0 where Id=" + ii.Id);
                        billInfo.Amount -= ii.Amount;
                    }


                }

                if (result == 1)
                {
                    dgvOrderList.Rows.Clear();

                    MessageBox.Show("Pay successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not be paid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                FormSale_Load(sender, e);
            }
        }
        //Event Load Form
        private void FormSale_Load(object sender, EventArgs e)
        {
            ComboboxType();


            SIGNAL = false;
            btnDeleteProduct.Enabled = false;
            btnUpdateProduct.Enabled = false;

            cmbProduct.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            nmrAmount.Value = 0;
            nmrDiscount.Value = 0;
            DisplayTotalCost();
        }
        //Event Load cmbProduct after choosing type
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxProduct();
            cmbProduct.SelectedIndex = -1;
        }

        private void dgvOrderList_Click(object sender, EventArgs e)
        {
            SIGNAL = true;
            btnDeleteProduct.Enabled = true;
            btnUpdateProduct.Enabled = true;

            if (dgvOrderList.SelectedRows.Count > 0)
            {
                if (dgvOrderList.SelectedRows[0].Cells[0].Value != null)
                {
                    cmbType.Text = dgvOrderList.SelectedRows[0].Cells[0].Value.ToString();
                    cmbProduct.Text = dgvOrderList.SelectedRows[0].Cells[1].Value.ToString();
                    dtpSaleDate.Value = Convert.ToDateTime(dgvOrderList.SelectedRows[0].Cells[2].Value);
                    nmrAmount.Value = Convert.ToInt32(dgvOrderList.SelectedRows[0].Cells[3].Value);
                    nmrDiscount.Value = Convert.ToInt32(dgvOrderList.SelectedRows[0].Cells[5].Value);
                }


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

        private void nmrDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormSale_Load(sender, e);
        }
    }
}
