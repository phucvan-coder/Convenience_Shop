using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.Object
{
    public class ProducerInfo
    {
        private int id;
        private string producerName;
        private string address;
        private string phone;

        public int Id { get => id; set => id = value; }
        public string ProducerName { get => producerName; set => producerName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
