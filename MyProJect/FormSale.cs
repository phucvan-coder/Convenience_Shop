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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }
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
                cmbProduct.DataSource = product;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "Id";
            }
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
        public bool SaveOrder(BillInfo billInfo)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.BillInfoes.Add(billInfo);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event add
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                double? price = 0;
                price = Convert.ToDouble(entity.Products.Where(x => x.ProductName.Equals(cmbProduct.Text)).Select(x => x.Price));
                double? totalPrice = Convert.ToInt32(nmrAmount.Value) * price * Convert.ToInt32(nmrDiscount.Value)/100;
                string[] order = new string[] { cmbType.Text, cmbProduct.Text, dtpSaleDate.Text, nmrAmount.Value.ToString(), price.ToString(), nmrDiscount.Value.ToString(), totalPrice.ToString()};
                dgvOrderList.Rows.Add(order);
            }
        }
        //Event delete
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgvOrderList.Rows.Count == 0)
            {
                dgvOrderList.Rows.RemoveAt(dgvOrderList.Rows[0].Index);
            }
            else
            {
                MessageBox.Show("The list is empty!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        //Event update 
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                double? price = 0;
                price = Convert.ToDouble(entity.Products.Where(x => x.ProductName == cmbProduct.Text).Select(x => x.Price));
                double? totalPrice = Convert.ToInt32(nmrAmount.Value) * price * Convert.ToInt32(nmrDiscount.Value) / 100;
                dgvOrderList.Rows[index].Cells[0].Value = cmbType.Text;
                dgvOrderList.Rows[index].Cells[1].Value = cmbProduct.Text;
                dgvOrderList.Rows[index].Cells[2].Value = dtpSaleDate.Value;
                dgvOrderList.Rows[index].Cells[3].Value = nmrAmount.Value;
                dgvOrderList.Rows[index].Cells[0].Value = cmbType.Text;
                dgvOrderList.Rows[index].Cells[5].Value = nmrDiscount.Value;
                dgvOrderList.Rows[index].Cells[6].Value = totalPrice;
            }
        }
        //Event choose cell
        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderList.Focus();
            index = e.RowIndex;
            cmbType.Text = dgvOrderList.Rows[index].Cells[0].Value.ToString();
            cmbProduct.Text = dgvOrderList.Rows[index].Cells[1].Value.ToString();
            dtpSaleDate.Value = Convert.ToDateTime(dgvOrderList.Rows[index].Cells[2].Value);
            nmrAmount.Value = Convert.ToInt32(dgvOrderList.Rows[index].Cells[3].Value);
            nmrDiscount.Value = Convert.ToInt32(dgvOrderList.Rows[index].Cells[5].Value);
        }
        //Event payment
        private void btnPayment_Click(object sender, EventArgs e)
        {
            /*using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                Bill bill = new Bill();
                bill.DateOfSale = dtpSaleDate.Value;
                SaveBill(bill);
                BillInfo billInfo = new BillInfo();
                billInfo.BillID = entity.Bills.Where(x => x.Bill)

                 bool result = SaveOrder(billInfo);
                if (result)
                {
                    MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
        //Event Load Form
        private void FormSale_Load(object sender, EventArgs e)
        {
            ComboboxType();
            
        }
        //Event Load cmbProduct after choosing type
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxProduct();
        }
        //Event closed form 
        private void FormSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }


        #endregion

        
    }
}
