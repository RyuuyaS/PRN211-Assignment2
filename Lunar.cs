using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Lunar : Form
    {
        public Lunar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Exit from the programm", "Alert", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbCalendar_Enter(object sender, EventArgs e)
        {
            tbCalendar.BackColor = Color.Pink;
        }

        private void tbCalendar_Leave(object sender, EventArgs e)
        {
            tbCalendar.BackColor = Color.White;
        }

        private void tbLunar_Enter(object sender, EventArgs e)
        {
            tbLunar.BackColor = Color.Pink;
        }

        private void tbLunar_Leave(object sender, EventArgs e)
        {
            tbLunar.BackColor = Color.White;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // int day = 0, month = 0, year = 0;
            string[] input = tbCalendar.Text.Split("/");
            if (input.Length < 3)
            {
                tbLunar.Text = "Please enter a valid date. Ex: 10/10/2003";
                return;
            }
            ChineseLunisolarCalendar time = new ChineseLunisolarCalendar();
            DateTime t = DateTime.Parse(tbCalendar.Text);
            // day = time.GetDayOfMonth(t);
            // month = time.GetMonth(t);
            // year = time.GetYear(t);
            tbLunar.Text = $"{time.GetDayOfMonth(t)}/{time.GetMonth(t)}/{time.GetYear(t)}";
        }
    }
}
