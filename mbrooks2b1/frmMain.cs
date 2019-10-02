using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrooks2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal AmountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal UsEuro = AmountEuro * rateEuro;
            txtUsEruo.Text = UsEuro.ToString("n2");
            decimal AmountYen = Convert.ToDecimal(txtAmountJapen.Text);
            decimal rateYen = Convert.ToDecimal(txtRateJapen.Text);
            decimal UsYen = AmountYen * rateYen;
            txtUsJapen.Text = UsYen.ToString("n2");
            decimal AmountPeso = Convert.ToDecimal(txtAmountMexico.Text);
            decimal ratePeso = Convert.ToDecimal(txtRateMexico.Text);
            decimal UsPeso = AmountPeso * ratePeso;
            txtUsMexico.Text = UsPeso.ToString("n2");
            decimal AmountPounds = Convert.ToDecimal(txtAmountSudan.Text);
            decimal ratePounds = Convert.ToDecimal(txtRateSudan.Text);
            decimal UsPounds = AmountPounds * ratePounds;
            txtUsSudan.Text = UsPounds.ToString("n2");
            decimal UsTotal = UsPounds + UsPeso + UsYen + UsEuro;
            txtUsDollars.Text = UsTotal.ToString("n2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountEuro.Text = "0.00";
            txtAmountJapen.Text = "0.00";
            txtAmountMexico.Text = "0.00";
            txtAmountSudan.Text = "0.00";
            txtRateEuro.Text = "1.10461";
            txtRateJapen.Text = "0.00931037";
            txtRateMexico.Text = "0.0511162";
            txtRateSudan.Text = "0.0222082";
        }
    }
}
