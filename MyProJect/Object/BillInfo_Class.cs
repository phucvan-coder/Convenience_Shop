using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.Object
{
    class BillInfo_Class
    {
        private int id;
        private int? billID;
        private DateTime? saleDate;
        private string type;
        private string product;
        private double? price;
        private int? amount;
        private int? discount;
        private double? totalPrice;

        public int Id { get => id; set => id = value; }
        public int? BillID { get => billID; set => billID = value; }
        public DateTime? SaleDate { get => saleDate; set => saleDate = value; }
        public string Type { get => type; set => type = value; }
        public string Product { get => product; set => product = value; }
        public double? Price { get => price; set => price = value; }
        public int? Amount { get => amount; set => amount = value; }
        public int? Discount { get => discount; set => discount = value; }
        public double? TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
