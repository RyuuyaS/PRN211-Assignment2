namespace Assignment2
{
    public partial class EXERCISE1 : Form
    {
        private int CLEAN_COST = 100000;
        private int WHITENING_COST = 1200000;
        private int XRAY_COST = 200000;
        private int FILL_COST = 80000;
        private bool isClean = false;
        private bool isWhitening = false;
        private bool isXray = false;
        public EXERCISE1()
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void chkClean_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClean.Checked)
            {
                isClean = true;
            }
            else
            {
                isClean = false;
            }
        }

        private void chkWhitening_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhitening.Checked)
            {
                isWhitening = true;
            }
            else
            {
                isWhitening = false;
            }
        }

        private void chkXRay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXRay.Checked)
            {
                isXray = true;
            }
            else
            {
                isXray = false;
            }
        }

        private void GetPay()
        {
            int sum = 0;
            if (txtName.Text == "")
            {
                MessageBox.Show("You haven't enter your customer name", "Alert", MessageBoxButtons.OK);
                return;
            }

            if (isClean)
            {
                sum += CLEAN_COST;
            }

            if (isWhitening)
            {
                sum += WHITENING_COST;
            }

            if (isXray)
            {
                sum += XRAY_COST;
            }
            sum += Convert.ToInt32(numFilling.Text) * FILL_COST;
            txtTotal.Text = sum.ToString();
        }
    }
}