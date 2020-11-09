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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            filter = "All";
        }

        public class Prod
        {
            public int id;
            public int typeID;
            public int? amount;
            public double? price;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            string query = "";
            if (filter == "All")
            {
                query = "";
            }
            else if (filter == "This Year")
            {
                query = DateTime.Now.Year.ToString();
            }else if (filter == "This Month")
            {
                query = DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            else
            {
                query = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            List<Prod> lst = new List<Prod>();
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {   
                List<Product> lstPro = new List<Product>();
                lstPro = entity.Products.ToList();
                foreach (Product p in lstPro)
                {
                    
                    List<BillInfo> bill = new List<BillInfo>();
                    bill = entity.BillInfoes.Where(x => x.ProductID == p.Id && x.TypeID == p.TypeID && 
                                                    (x.Bill.DateOfSale.Value.Day + "/" + x.Bill.DateOfSale.Value.Month + "/" + x.Bill.DateOfSale.Value.Year).Contains(query)).ToList();
                    int? totalAmount = 0;
                    double? totalPrice = 0;
                    foreach (BillInfo ii in bill)
                    {
                        totalAmount += ii.Amount;
                        totalPrice += ii.TotalPrice;
                    }
                    Prod tmp = new Prod();
                    tmp.id = p.Id;
                    tmp.typeID = p.TypeID;
                    tmp.amount = totalAmount;
                    tmp.price = totalPrice;
                    lst.Add(tmp);
                }

            }

            
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                lst.OrderBy(x => x.amount);
                Product p = new Product();
                p = entity.Products.SqlQuery("Select * from Product where Id = " + lst[0].id + " and TypeID=" + lst[0].typeID).FirstOrDefault();
                lblLeastPro.Text = p.ProductName.ToString();
                lblLeastProAmount.Text = Convert.ToDouble(lst[0].amount).ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE"));

                lblMostPro.Text = entity.Products.SqlQuery("Select * from Product where Id = " + lst[lst.Count() - 1].id + " and TypeID=" + lst[lst.Count() - 1].typeID).FirstOrDefault().ProductName;
                lblMostProAmount.Text = Convert.ToDouble(lst[lst.Count()-1].amount).ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE"));

                int? totalAmount = 0;
                double? totalPrice = 0; 
                foreach (Prod i in lst)
                {
                    totalAmount += i.amount;
                    totalPrice += i.price;
                }

                lblAmount.Text = Convert.ToDouble(totalAmount).ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE"));
                
                lblTotalPrice.Text = Convert.ToDouble(totalPrice).ToString("N", CultureInfo.CreateSpecificCulture("sv-SE"));


            }


        }

        public string filter;
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = cmbFilter.GetItemText(cmbFilter.SelectedItem);
            FormReport_Load(sender, e);
        }
    }
}
