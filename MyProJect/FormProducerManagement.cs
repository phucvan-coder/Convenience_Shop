using MyProJect.Object;
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
    public partial class FormProducerManagement : Form
    {
        public FormProducerManagement()
        {
            InitializeComponent();
        }

        public bool SIGNAL;
        #region Method
        //Function display information of producer onto datagridview
        public void DisplayProducer()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<ProducerInfo> producerList = new List<ProducerInfo>();
                producerList = entity.Producers.Select(x => new ProducerInfo
                {
                    Id = x.Id,
                    ProducerName = x.ProducerName,
                    Address = x.Address,
                    Phone = x.Phone
                }).ToList();
                dgvProducerList.DataSource = producerList;
            }
        }
        //Function add producer onto database
        public bool AddProducer(Producer producer)
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Producers.Add(producer);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //Function delete producer from database
        public bool DeleteProducer()
        {
            bool result = false;
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                if (dgvProducerList.SelectedRows.Count > 0)
                {
                    Producer a = entity.Producers.SqlQuery("select * from Producer where Id = " + dgvProducerList.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                    List<Product> lstProduct = new List<Product>();
                    lstProduct = entity.Products.SqlQuery("select * from Product where ProducerID = " + dgvProducerList.SelectedRows[0].Cells[0].Value.ToString()).ToList();
                    foreach(Product x in lstProduct)
                    {
                        List<BillInfo> lstBillInfo = new List<BillInfo>();
                        lstBillInfo = entity.BillInfoes.SqlQuery("select * from BillInfo where ProductID = " + x.Id).ToList();
                        foreach (BillInfo bill in lstBillInfo)
                        {
                            entity.BillInfoes.Remove(bill);
                            entity.SaveChanges();
                        }
                        entity.Products.Remove(x);
                        entity.SaveChanges();
                    }
                    entity.Producers.Remove(a);
                    entity.SaveChanges();
                    result = true;
                }
                
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormProducerManagement_Load(object sender, EventArgs e)
        {
            DisplayProducer();
            SIGNAL = false;

            txtProducerAddress.Text = "";
            txtProducerID.Text = "";
            txtProducerName.Text = "";
            txtProducerPhone.Text = "";

            btnDeleteProducer.Enabled = false;
            btnUpdateProducer.Enabled = false;
        }

        //Event Add producer onto database
        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.ProducerName = txtProducerName.Text.Trim();
            producer.Address = txtProducerAddress.Text.Trim();
            producer.Phone = txtProducerPhone.Text.Trim();

            bool result = AddProducer(producer);
            if (result)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormProducerManagement_Load(sender, e);
        }

        //Event Delete producer from database
        private void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want Delete it?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                bool result = DeleteProducer();
                if (result)
                {
                    MessageBox.Show("Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FormProducerManagement_Load(sender, e);
            }

            
        }

        private void btnUpdateProducer_Click(object sender, EventArgs e)
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.Database.ExecuteSqlCommand("update Producer set " +
                    "Phone = '" + txtProducerPhone.Text + "', " +
                    "ProducerName = N'" + txtProducerName.Text + "', " +
                    "Address = N'" + txtProducerAddress.Text + "'" +
                    " where Id = " + dgvProducerList.SelectedRows[0].Cells[0].Value);
                entity.SaveChanges();
                MessageBox.Show("Update Successed!");
                FormProducerManagement_Load(sender, e);
            }
        }

        private void dgvProducerList_SelectionChanged(object sender, EventArgs e)
        {
            if (SIGNAL == true)
            {
                if (dgvProducerList.SelectedRows.Count > 0)
                {
                    txtProducerID.Text = dgvProducerList.SelectedRows[0].Cells[0].Value.ToString();
                    txtProducerName.Text = dgvProducerList.SelectedRows[0].Cells[1].Value.ToString();
                    txtProducerAddress.Text = dgvProducerList.SelectedRows[0].Cells[2].Value.ToString();
                    txtProducerPhone.Text = dgvProducerList.SelectedRows[0].Cells[3].Value.ToString();

                }
            }

        }

        private void dgvProducerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducerList_Click(object sender, EventArgs e)
        {
            SIGNAL = true;
            btnDeleteProducer.Enabled = true;
            btnUpdateProducer.Enabled = true;

            if (dgvProducerList.SelectedRows.Count > 0)
            {
                txtProducerID.Text = dgvProducerList.SelectedRows[0].Cells[0].Value.ToString();
                txtProducerName.Text = dgvProducerList.SelectedRows[0].Cells[1].Value.ToString();
                txtProducerAddress.Text = dgvProducerList.SelectedRows[0].Cells[2].Value.ToString();
                txtProducerPhone.Text = dgvProducerList.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void btnSearchProducer_Click(object sender, EventArgs e)
        {
            string query = txtSearchProducer.Text.Trim().ToLower();
            List<ProducerInfo> data = new List<ProducerInfo>();

            DisplayProducer();
            foreach (DataGridViewRow a in dgvProducerList.Rows)
            {
                if (a.Cells[0].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[1].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[2].Value.ToString().ToLower().Contains(query) ||
                    a.Cells[3].Value.ToString().ToLower().Contains(query))
                {
                    ProducerInfo x = new ProducerInfo();
                    x.Id = Convert.ToInt32(a.Cells[0].Value);
                    x.ProducerName = a.Cells[1].Value.ToString();
                    x.Address = a.Cells[2].Value.ToString();
                    x.Phone = a.Cells[3].Value.ToString();

                    data.Add(x);
                }

            }

            dgvProducerList.DataSource = data;
        }

        private void txtProducerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
