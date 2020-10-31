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
                var a = entity.Producers.FirstOrDefault();
                entity.Producers.Remove(a);
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormProducerManagement_Load(object sender, EventArgs e)
        {
            DisplayProducer();
        }

        //Event Add producer onto database
        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.ProducerName = txtProducerName.Text;
            producer.Address = txtProducerAddress.Text;
            producer.Phone = txtProducerPhone.Text;

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

        #endregion

        private void FormProducerManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }
    }
}
