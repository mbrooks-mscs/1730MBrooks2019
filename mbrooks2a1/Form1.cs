using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrooks2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal Discountpercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal DiscountAmount = Subtotal * Discountpercent / 100;
            txtDiscountAmount.Text = DiscountAmount.ToString("n2");
            decimal Total = Subtotal - DiscountAmount;
            txtTotal.Text = Total.ToString("n2");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
