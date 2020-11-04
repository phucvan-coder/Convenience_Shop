using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProJect
{
    public partial class FormBillFilter : Form
    {
        public FormBillFilter()
        {
            InitializeComponent();
        }
        public delegate void PassData(string fromDate, string toDate);
        public PassData passData;

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (passData != null)
            {
                string from = dtpFrom.Value.Day.ToString() + "/" + dtpFrom.Value.Month.ToString() + "/" + dtpFrom.Value.Year.ToString();
                string to = dtpTo.Value.Day.ToString() + "/" + dtpTo.Value.Month.ToString() + "/" + dtpTo.Value.Year.ToString();
                passData(from, to);
            }
            this.Hide();
        }
    }
}
