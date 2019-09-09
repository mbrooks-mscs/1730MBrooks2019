using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrooks1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtCornDogsSubtotal.Text = (
                    4.0m * Convert.ToDecimal(txtCornDogs.Text)
                ).ToString("0.00");
            txtCheeseburgersSubtotal.Text = (
                    5.0m * Convert.ToDecimal(txtCheeseBurgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (
              Convert.ToDecimal(txtCornDogsSubtotal.Text) + (Convert.ToDecimal(txtCheeseburgersSubtotal.Text))
                   ).ToString("0.00");
            txtTax.Text = (
                .094m * Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");
            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) + (Convert.ToDecimal(txtTax.Text))
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void FrmFoodTruck_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCornDogs.Text = "0";
            txtCheeseBurgers.Text = "0";
            txtCheeseburgersSubtotal.Text = "";
            txtCornDogsSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtCheeseBurgers.Focus();
        }
    }
}