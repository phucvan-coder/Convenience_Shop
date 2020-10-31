using MyProJect.Object;
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
    public partial class FormBillManagement : Form
    {
        public FormBillManagement()
        {
            InitializeComponent();
        }

        #region Method
        //Function Display Bill onto database
        public void DisplayBill()
        {
            //using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            //{
            //    List < BillInfo_Class> billList = new List<BillInfo_Class>();
            //    billList = entity.BillInfoes.Select(x => new BillInfo_Class
            //    {
            //        Id = x.Id,
            //        BillID = x.BillID,
            //        SaleDate = x.Bill.DateOfSale,
            //        Type = x.TypeOfProduct.TypeName,
            //        Product = x.Product.ProductName,
            //        Price = x.Product.Price,
            //        Amount = x.Amount,
            //        Discount = x.Discount,
            //        TotalPrice = x.TotalPrice
            //    }).ToList();
            //    dgvBillList.DataSource = billList;
            //}
        }
        //Function moneyStatistics
        private double moneyStatistics;
        public void MoneyStatistics()
        {
            foreach (DataGridView a in dgvBillList.Rows)
            {
                moneyStatistics += Convert.ToDouble(a.Columns[8]);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtMoneyStatistics.Text = moneyStatistics.ToString("c", culture);
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormBillManagement_Load(object sender, EventArgs e)
        {
            DisplayBill();
            MoneyStatistics();
        }

        #endregion

        private void FormBillManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }
    }
}
