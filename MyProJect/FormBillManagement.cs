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
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<BillInfo_Class> billList = new List<BillInfo_Class>();
                billList = entity.BillInfoes.Select(x => new BillInfo_Class
                {
                    Id = x.Id,
                    BillID = x.BillID,
                    SaleDate = x.Bill.DateOfSale.Value.Day + "/" + x.Bill.DateOfSale.Value.Month + "/" + x.Bill.DateOfSale.Value.Year,
                    Type = x.TypeOfProduct.TypeName,
                    Product = x.Product.ProductName,
                    Price = x.Product.Price,
                    Amount = x.Amount,
                    Discount = x.Discount,
                    TotalPrice = x.TotalPrice
                }).ToList();
                billList.Reverse();
                dgvBillList.DataSource = billList;
            }
        }
        //Function moneyStatistics
        public void MoneyStatistics()
        {
            double moneyStatistics = 0;
            foreach (DataGridViewRow a in dgvBillList.Rows)
            {
                moneyStatistics += Convert.ToDouble(a.Cells[8].Value);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtMoneyStatistics.Text = moneyStatistics.ToString("c", culture);
        }

        public void Filter(string f, string t)
        {
            DateTime from = Convert.ToDateTime(f);
            DateTime to = Convert.ToDateTime(t);

            DisplayBill();
            List<BillInfo_Class> lst = new List<BillInfo_Class>();
            foreach (DataGridViewRow a in dgvBillList.Rows)
            {
                if (from <= Convert.ToDateTime(a.Cells[2].Value.ToString()) && Convert.ToDateTime(a.Cells[2].Value.ToString()) <= to )
                {
                    BillInfo_Class n = new BillInfo_Class();
                    n.Id = Convert.ToInt32(a.Cells[0].Value.ToString());
                    n.BillID = Convert.ToInt32(a.Cells[1].Value.ToString());
                    n.SaleDate = a.Cells[2].Value.ToString();
                    n.Type = a.Cells[3].Value.ToString();
                    n.Product = a.Cells[4].Value.ToString();
                    n.Price = Convert.ToDouble(a.Cells[5].Value.ToString());
                    n.Amount = Convert.ToInt32(a.Cells[6].Value.ToString());
                    n.Discount = Convert.ToInt32(a.Cells[7].Value.ToString());
                    n.TotalPrice = Convert.ToDouble(a.Cells[8].Value.ToString());

                    lst.Add(n);

                }
            }

            dgvBillList.DataSource = lst;
            MoneyStatistics();
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormBillManagement_Load(object sender, EventArgs e)
        {
            DisplayBill();
            MoneyStatistics();
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            string query = txtSearchBill.Text.ToLower().Trim();
            DisplayBill();
            List<BillInfo_Class> lst = new List<BillInfo_Class>();
            foreach (DataGridViewRow a in dgvBillList.Rows)
            {
                if (a.Cells[1].Value.ToString().ToLower() == query ||
                    a.Cells[3].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[4].Value.ToString().ToLower().Contains(query))
                {
                    BillInfo_Class n = new BillInfo_Class();
                    n.Id = Convert.ToInt32(a.Cells[0].Value.ToString());
                    n.BillID = Convert.ToInt32(a.Cells[1].Value.ToString());
                    n.SaleDate = a.Cells[2].Value.ToString();
                    n.Type = a.Cells[3].Value.ToString();
                    n.Product = a.Cells[4].Value.ToString();
                    n.Price = Convert.ToDouble(a.Cells[5].Value.ToString());
                    n.Amount = Convert.ToInt32(a.Cells[6].Value.ToString());
                    n.Discount = Convert.ToInt32(a.Cells[7].Value.ToString());
                    n.TotalPrice = Convert.ToDouble(a.Cells[8].Value.ToString());

                    lst.Add(n);

                }
            }

            dgvBillList.DataSource = lst;
            MoneyStatistics();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FormBillFilter frm = new FormBillFilter();

            frm.passData = new FormBillFilter.PassData(Filter);

            frm.ShowDialog();
        }

        private void dgvBillList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefreshBill_Click(object sender, EventArgs e)
        {
            FormBillManagement_Load(sender, e);
        }




        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport frm = new FormReport();
            frm.Show();
        }
    }
}
