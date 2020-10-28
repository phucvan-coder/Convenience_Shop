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
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }
        // form closing
        private void FormManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure want to close sign out";
            string title = "Notification";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormMain main = new FormMain();
                main.Show();
            }
            else
                e.Cancel = true;
        }
        // form closed
        private void FormManage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        //Event Load Form
        private void FormManage_Load(object sender, EventArgs e)
        {
            DisplayType();
            DisplayProducer();
            DisplayProduct();
        }
        //Type of product management
        #region Type of product management

        #region Method
        //Function display information of product type from database to datagridview
        public void DisplayType()
        {
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<TypeInfo> typeList = new List<TypeInfo>();
                typeList = entity.TypeOfProducts.Select(x => new TypeInfo
                {
                    Id = x.Id,
                    TypeName = x.TypeName
                }).ToList();
                dgvTypeList.DataSource = typeList;
            }
        }

        //Function Add Type onto database
        public bool AddType(TypeOfProduct typeOfProduct)
        {
            bool result = false;
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                entity.TypeOfProducts.Add(typeOfProduct);
                entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //Function Delete Type From database
        public bool DeleteType()
        {
            bool result = false;
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                var a = entity.TypeOfProducts.FirstOrDefault();
                entity.TypeOfProducts.Remove(a);
                result = true;
            }
            return result;
        }

        #endregion

        #region Event
        //Event Add type onto database
        private void btnAddType_Click(object sender, EventArgs e)
        {
            TypeOfProduct typeOfProduct = new TypeOfProduct();
            typeOfProduct.Id = Int32.Parse(txtTypeID.Text);
            typeOfProduct.TypeName = txtTypeName.Text;

            bool result = AddType(typeOfProduct);
            if (result)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormManage_Load(sender, e);
        }

        //Event delete Type from database
        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            bool result = DeleteType();
            if (result)
            {
                MessageBox.Show("Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can not be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormManage_Load(sender, e);
        }

        #endregion

        #endregion

        //Producer management
        #region Producer management

        #region Method
        //Function display information of producer onto datagridview
        public void DisplayProducer()
        {
            using(ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<ProducerInfo> producerList = new List<ProducerInfo>();
                producerList = entity.Producers.Select(x => new ProducerInfo
                {
                    Id = x.Id,
                    ProducerName=x.ProducerName,
                    Address=x.Address,
                    Phone=x.Phone
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
        //Event Add producer onto database
        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.Id = Int32.Parse(txtTypeID.Text);
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
            FormManage_Load(sender, e);
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
            FormManage_Load(sender, e);
        }


        #endregion

        #endregion

        //Product management
        #region Product management

        #region Method
        //Function display product onto datagridview
        public void DisplayProduct()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                List<Product> productList = new List<Product>();
                productList = entity.Products.Select(x => new ProductInfo
                {
                    Id = x.Id,
                    TypeName = x.TypeOfProduct.TypeName,
                    ProductName = x.ProductName,
                    Price = x.Price,
                    ProducerName = x.Producer.ProducerName,
                    Status = x.Status
                });
                dgvProductList.DataSource = productList;
            }
        }
        #endregion

        #region Event
        #endregion

        #endregion
    }
}
