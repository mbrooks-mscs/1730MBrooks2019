using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesampler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //txtCornDogsSubtotal.Text = (
            //      4.0m * Convert.ToDecimal(txtCornDogs.Text)
            //  ).ToString("0.00");

            int CornDogs = Convert.ToInt32(txtCornDogs.Text);
            decimal CornDogPrice = 4.0m;
            decimal CornDogSubtotal = CornDogs * CornDogPrice;
            txtCornDogsSubtotal.Text = CornDogSubtotal.ToString("n2");

            //txtCheeseburgersSubtotal.Text = (
            //        5.0m * Convert.ToDecimal(txtCheeseBurgers.Text)
            //    ).ToString("0.00");

            int CheeseBurgers = Convert.ToInt32(txtCheeseBurgers.Text);
            decimal CheeseburgerPrice = 5.0m;
            decimal CheeseburgerSubtotal = CheeseBurgers * CheeseburgerPrice;
            txtCheeseburgersSubtotal.Text = CheeseburgerSubtotal.ToString("n2");

            //txtPretaxTotal.Text = (
            //  Convert.ToDecimal(txtCornDogsSubtotal.Text) + (Convert.ToDecimal(txtCheeseburgersSubtotal.Text))
            //       ).ToString("0.00");

            decimal Pretaxtotal = CheeseburgerSubtotal + CornDogSubtotal;
            txtPretaxTotal.Text = Pretaxtotal.ToString("n2");

            ////txtTax.Text = (
            ////    .094m * Convert.ToDecimal(txtPretaxTotal.Text)
            ////    ).ToString("0.00");

            decimal Tax = .094m * Pretaxtotal;
            txtTax.Text = Tax.ToString("n2");

            //txtTotal.Text = (
            //    Convert.ToDecimal(txtPretaxTotal.Text) + (Convert.ToDecimal(txtTax.Text))
            //    ).ToString("0.00");

            decimal Total = Tax + Pretaxtotal;
            txtTotal.Text = Total.ToString("n2");
            btnClear.Focus();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
