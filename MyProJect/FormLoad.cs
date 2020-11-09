using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MyProJect
{
    public partial class FormLoad : Form
    {
        // loading form and start 
        public FormLoad()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRound(0, 0, Width, Height, 25, 25));
            timer_Load.Start();
            ProgressBarload.Value = 0;
            ProgressBarload.PerformStep();
        }
        // loadtick event
        private void timer_Load_Tick(object sender, EventArgs e)
        {
            ProgressBarload.Value += 5;
            ProgressBarload.Text = ProgressBarload.Value.ToString() + "%";
            if (ProgressBarload.Value == 100)
            {
                timer_Load.Enabled = false;
                timer_Load.Stop();
                ProgressBarload.Increment(1);
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
