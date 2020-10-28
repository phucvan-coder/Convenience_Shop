using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.Object
{
    public class ProductInfo
    {
        private int id;
        private string typeName;
        private string productName;
        private Double? price;
        private string producerName;
        private string status;

        public int Id { get => id; set => id = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public string ProductName { get => productName; set => productName = value; }
        public Double? Price { get => price; set => price = value; }
        public string ProducerName { get => producerName; set => producerName = value; }
        public string Status { get => status; set => status = value; }
    }
}
