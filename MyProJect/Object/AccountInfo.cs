using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.Object
{
    public class AccountInfo
    {
        private int id;
        private string accountName;
        private string password;
        private string rank;

        public int Id { get => id; set => id = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string Password { get => password; set => password = value; }
        public string Rank { get => rank; set => rank = value; }
    }
}
