using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrooks1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFrance.BackgroundImage = picFrance.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnSudan.BackgroundImage = picSudanDim.Image;
            txtRate.Text = "1.10664";
            txtTotal.Text = "0.00";
            txtUsDollar.Text = "0.00";
            txtAmount.Focus();
        }

        private void BtnFrance_Click(object sender, EventArgs e)
        {
            btnFrance.BackgroundImage = picFrance.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnSudan.BackgroundImage = picSudanDim.Image;
            txtName.Text = "Euro";
            txtRate.Text = "1.10664";
            txtUsDollar.Text = (
                Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
            txtAmount.Focus();
        }

        private void BtnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnSudan.BackgroundImage = picSudanDim.Image;
            txtName.Text = "Yen";
            txtRate.Text = "0.00924016";
            txtUsDollar.Text = (
                Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
            txtAmount.Focus();
        }

        private void BtnMexico_Click(object sender, EventArgs e)
        {
            btnMexico.BackgroundImage = picMexico.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnSudan.BackgroundImage = picSudanDim.Image;
            txtName.Text = "Peso";
            txtRate.Text = "0.0516115";
            txtUsDollar.Text = (
                Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
            txtAmount.Focus();
        }

        private void BtnSudan_Click(object sender, EventArgs e)
        {
            btnSudan.BackgroundImage = picSudan.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            txtName.Text = "Pounds";
            txtRate.Text = "0.0221607";
            txtUsDollar.Text = (
                Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
            txtAmount.Focus();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUsDollar.Text = (
                Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
                }

        private void TxtAmount_Enter(object sender, EventArgs e)
        {
            txtAmount.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (
                Convert.ToDecimal(txtUsDollar.Text) + Convert.ToDecimal(txtTotal.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUsDollar.Text;
            txtAmount.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnFrance.BackgroundImage = picFrance.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            btnSudan.BackgroundImage = picSudanDim.Image;
            txtRate.Text = "1.10664";
            txtTotal.Text = "0.00";
            txtUsDollar.Text = "0.00";
            txtName.Text = "Euro";
            lblEquation.Text = "";
            txtAmount.Text = "0.00";
            txtAmount.Focus();
        }
    }
}
