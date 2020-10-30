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
    public partial class FormTypeManagement : Form
    {
        public FormTypeManagement()
        {
            InitializeComponent();
        }

        #region Method
        //Function display information of product type from database to datagridview
        public void DisplayType()
        {
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
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
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
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
            using (ConvenienceShopEntities entity = new ConvenienceShopEntities())
            {
                var a = entity.TypeOfProducts.FirstOrDefault();
                entity.TypeOfProducts.Remove(a);
                result = true;
            }
            return result;
        }
        #endregion

        #region Event
        //Event Load Form
        private void FormTypeManagement_Load(object sender, EventArgs e)
        {
            DisplayType();
        }
        //Event Add type onto database
        private void btnAddType_Click(object sender, EventArgs e)
        {
            TypeOfProduct typeOfProduct = new TypeOfProduct();
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
            FormTypeManagement_Load(sender, e);
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
            FormTypeManagement_Load(sender, e);
        }

        #endregion

        
    }
}
