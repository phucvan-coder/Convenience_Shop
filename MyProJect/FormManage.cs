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
    }
}
