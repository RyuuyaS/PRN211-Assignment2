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
    public partial class EXERCISE2 : Form
    {
        public EXERCISE2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "0";
        }
        private void btnSharp_Click(object sender, EventArgs e)
        {
            string result = txtSecurityCode.Text;
            string role;
            DecideRole(result, out role);
            DateTime time = DateTime.Now;
            lbxAcessLog.Items.Add($"{time}\t{role}\n");
            txtSecurityCode.Text = "";
        }

        private void DecideRole(string result, out string role)
        {
            role = "";
            switch (result)
            {
                case "1645":
                case "1689":
                    role = "Technicians";
                    break;
                case "8345":
                    role = "Custodians";
                    break;
                case "9998":
                case "1006":
                // case "1007":
                case "1008":
                    role = "Scientist";
                    break;
                default:
                    role = "Restricted Access!";
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
    }
}
