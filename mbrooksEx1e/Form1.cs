﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbrooksEx1e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                (Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest3.Text) + Convert.ToDecimal(txtTest2.Text)) / 3
                ).ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAverage.Text = "";
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
