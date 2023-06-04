using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            pgbLoad.Minimum = 0;
            pgbLoad.Maximum = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbLoad.Value < pgbLoad.Maximum)
            {
                pgbLoad.Value += 1;
            }
            else
            {
                timer1.Stop();
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
        }
    }
}
