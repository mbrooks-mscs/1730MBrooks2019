using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrooks1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

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

        private void TxtAmountEuro_TextChanged(object sender, EventArgs e)
        {
            txtUsEruo.Text = (
              Convert.ToDecimal (txtAmountEuro.Text) *Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00"); 
        }

        private void TxtAmountJapen_TextChanged(object sender, EventArgs e)
        {
            txtUsJapen.Text = (
                Convert.ToDecimal(txtAmountJapen.Text) * Convert.ToDecimal(txtRateJapen.Text)
                ).ToString("0.00");
        }

        private void TxtAmountMexico_TextChanged(object sender, EventArgs e)
        {
            txtUsMexico.Text = (
                Convert.ToDecimal(txtAmountMexico.Text) * Convert.ToDecimal(txtRateMexico.Text)
                ).ToString("0.00");
        }

        private void TxtAmountSudan_TextChanged(object sender, EventArgs e)
        {
            txtUsSudan.Text = (
                  Convert.ToDecimal(txtAmountSudan.Text) * Convert.ToDecimal(txtRateSudan.Text)
                ).ToString("0.00");
        }

        private void TxtUsDollars_TextChanged(object sender, EventArgs e)
        {
            txtUsDollars.Text = (
                Convert.ToDecimal(txtUsSudan.Text) + (Convert.ToDecimal(txtUsMexico.Text)) + (Convert.ToDecimal(txtUsJapen.Text)) + (Convert.ToDecimal(txtUsEruo.Text))
                ).ToString("0.00");
        }
    }
}
