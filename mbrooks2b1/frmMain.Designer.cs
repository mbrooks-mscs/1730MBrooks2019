﻿namespace mbrooks2b1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsSudan = new System.Windows.Forms.TextBox();
            this.txtUsMexico = new System.Windows.Forms.TextBox();
            this.txtUsJapen = new System.Windows.Forms.TextBox();
            this.txtUsEruo = new System.Windows.Forms.TextBox();
            this.txtRateSudan = new System.Windows.Forms.TextBox();
            this.txtRateMexico = new System.Windows.Forms.TextBox();
            this.txtRateJapen = new System.Windows.Forms.TextBox();
            this.txtRateEuro = new System.Windows.Forms.TextBox();
            this.txtUsDollars = new System.Windows.Forms.TextBox();
            this.txtAmountSudan = new System.Windows.Forms.TextBox();
            this.txtAmountMexico = new System.Windows.Forms.TextBox();
            this.txtAmountJapen = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(28, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "$US";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(290, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(175, 198);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(11, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(23, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Rate:";
            // 
            // txtUsSudan
            // 
            this.txtUsSudan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsSudan.Location = new System.Drawing.Point(406, 172);
            this.txtUsSudan.Name = "txtUsSudan";
            this.txtUsSudan.ReadOnly = true;
            this.txtUsSudan.Size = new System.Drawing.Size(100, 20);
            this.txtUsSudan.TabIndex = 50;
            this.txtUsSudan.TabStop = false;
            this.txtUsSudan.Text = "0.00";
            this.txtUsSudan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUsMexico
            // 
            this.txtUsMexico.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsMexico.Location = new System.Drawing.Point(290, 172);
            this.txtUsMexico.Name = "txtUsMexico";
            this.txtUsMexico.ReadOnly = true;
            this.txtUsMexico.Size = new System.Drawing.Size(100, 20);
            this.txtUsMexico.TabIndex = 49;
            this.txtUsMexico.TabStop = false;
            this.txtUsMexico.Text = "0.00";
            this.txtUsMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUsJapen
            // 
            this.txtUsJapen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsJapen.Location = new System.Drawing.Point(175, 172);
            this.txtUsJapen.Name = "txtUsJapen";
            this.txtUsJapen.ReadOnly = true;
            this.txtUsJapen.Size = new System.Drawing.Size(100, 20);
            this.txtUsJapen.TabIndex = 48;
            this.txtUsJapen.TabStop = false;
            this.txtUsJapen.Text = "0.00";
            this.txtUsJapen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUsEruo
            // 
            this.txtUsEruo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsEruo.Location = new System.Drawing.Point(58, 172);
            this.txtUsEruo.Name = "txtUsEruo";
            this.txtUsEruo.ReadOnly = true;
            this.txtUsEruo.Size = new System.Drawing.Size(100, 20);
            this.txtUsEruo.TabIndex = 47;
            this.txtUsEruo.TabStop = false;
            this.txtUsEruo.Text = "0.00";
            this.txtUsEruo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUsEruo.Click += new System.EventHandler(this.calculate);
            // 
            // txtRateSudan
            // 
            this.txtRateSudan.Location = new System.Drawing.Point(406, 146);
            this.txtRateSudan.Name = "txtRateSudan";
            this.txtRateSudan.Size = new System.Drawing.Size(100, 20);
            this.txtRateSudan.TabIndex = 37;
            this.txtRateSudan.Text = "0.0222082";
            this.txtRateSudan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateSudan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateMexico
            // 
            this.txtRateMexico.Location = new System.Drawing.Point(290, 146);
            this.txtRateMexico.Name = "txtRateMexico";
            this.txtRateMexico.Size = new System.Drawing.Size(100, 20);
            this.txtRateMexico.TabIndex = 36;
            this.txtRateMexico.Text = "0.0511162";
            this.txtRateMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateMexico.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateJapen
            // 
            this.txtRateJapen.Location = new System.Drawing.Point(175, 146);
            this.txtRateJapen.Name = "txtRateJapen";
            this.txtRateJapen.Size = new System.Drawing.Size(100, 20);
            this.txtRateJapen.TabIndex = 35;
            this.txtRateJapen.Text = "0.00931037";
            this.txtRateJapen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateJapen.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateEuro
            // 
            this.txtRateEuro.Location = new System.Drawing.Point(58, 146);
            this.txtRateEuro.Name = "txtRateEuro";
            this.txtRateEuro.Size = new System.Drawing.Size(100, 20);
            this.txtRateEuro.TabIndex = 34;
            this.txtRateEuro.Text = "1.10461";
            this.txtRateEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateEuro.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUsDollars
            // 
            this.txtUsDollars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsDollars.Location = new System.Drawing.Point(624, 172);
            this.txtUsDollars.Name = "txtUsDollars";
            this.txtUsDollars.ReadOnly = true;
            this.txtUsDollars.Size = new System.Drawing.Size(100, 20);
            this.txtUsDollars.TabIndex = 52;
            this.txtUsDollars.TabStop = false;
            this.txtUsDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountSudan
            // 
            this.txtAmountSudan.Location = new System.Drawing.Point(406, 120);
            this.txtAmountSudan.Name = "txtAmountSudan";
            this.txtAmountSudan.Size = new System.Drawing.Size(100, 20);
            this.txtAmountSudan.TabIndex = 29;
            this.txtAmountSudan.Text = "0.00";
            this.txtAmountSudan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountSudan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountMexico
            // 
            this.txtAmountMexico.Location = new System.Drawing.Point(290, 120);
            this.txtAmountMexico.Name = "txtAmountMexico";
            this.txtAmountMexico.Size = new System.Drawing.Size(100, 20);
            this.txtAmountMexico.TabIndex = 27;
            this.txtAmountMexico.Text = "0.00";
            this.txtAmountMexico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountMexico.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountJapen
            // 
            this.txtAmountJapen.Location = new System.Drawing.Point(175, 120);
            this.txtAmountJapen.Name = "txtAmountJapen";
            this.txtAmountJapen.Size = new System.Drawing.Size(100, 20);
            this.txtAmountJapen.TabIndex = 26;
            this.txtAmountJapen.Text = "0.00";
            this.txtAmountJapen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountJapen.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(58, 120);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(100, 20);
            this.txtAmountEuro.TabIndex = 25;
            this.txtAmountEuro.Text = "0.00";
            this.txtAmountEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountEuro.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(644, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "US Dollars:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(618, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(409, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Sudanese Pounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(303, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mexican Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(185, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Japenesse Yen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(94, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Euro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(400, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(284, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 239);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsSudan);
            this.Controls.Add(this.txtUsMexico);
            this.Controls.Add(this.txtUsJapen);
            this.Controls.Add(this.txtUsEruo);
            this.Controls.Add(this.txtRateSudan);
            this.Controls.Add(this.txtRateMexico);
            this.Controls.Add(this.txtRateJapen);
            this.Controls.Add(this.txtRateEuro);
            this.Controls.Add(this.txtUsDollars);
            this.Controls.Add(this.txtAmountSudan);
            this.Controls.Add(this.txtAmountMexico);
            this.Controls.Add(this.txtAmountJapen);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "mbrooks2b1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsSudan;
        private System.Windows.Forms.TextBox txtUsMexico;
        private System.Windows.Forms.TextBox txtUsJapen;
        private System.Windows.Forms.TextBox txtUsEruo;
        private System.Windows.Forms.TextBox txtRateSudan;
        private System.Windows.Forms.TextBox txtRateMexico;
        private System.Windows.Forms.TextBox txtRateJapen;
        private System.Windows.Forms.TextBox txtRateEuro;
        private System.Windows.Forms.TextBox txtUsDollars;
        private System.Windows.Forms.TextBox txtAmountSudan;
        private System.Windows.Forms.TextBox txtAmountMexico;
        private System.Windows.Forms.TextBox txtAmountJapen;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

