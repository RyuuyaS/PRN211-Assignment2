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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void rbLion_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.lion;
        }

        private void rbFullham_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.fullham;
        }

        private void rbArsenal_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.Arsenal_FC;
        }

        private void rbTottenham_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.Tottenham_Hotspur_svg;
        }

        private void rbMu_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.MU;
        }

        private void rbAleticoMadrid_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.Atletico_Madridpng;
        }

        private void rbRealMandrid_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.download;
        }

        private void rbBarcenola_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.FC_Barcelonapng;
        }

        private void rbInterMilan_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.InterMilan;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want move to Lunar App", "Lunar", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Lunar l = new Lunar();
                l.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }
    }
}
