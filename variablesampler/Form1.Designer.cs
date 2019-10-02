namespace variablesampler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCornDogsSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCornDogs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheeseburgersSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheeseBurgers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(177, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(177, 111);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(59, 20);
            this.txtTotal.TabIndex = 31;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(177, 85);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(59, 20);
            this.txtTax.TabIndex = 29;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tax:";
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(177, 59);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(59, 20);
            this.txtPretaxTotal.TabIndex = 27;
            this.txtPretaxTotal.TabStop = false;
            this.txtPretaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Pretax total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 159);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtCornDogsSubtotal
            // 
            this.txtCornDogsSubtotal.Location = new System.Drawing.Point(177, 33);
            this.txtCornDogsSubtotal.Name = "txtCornDogsSubtotal";
            this.txtCornDogsSubtotal.ReadOnly = true;
            this.txtCornDogsSubtotal.Size = new System.Drawing.Size(59, 20);
            this.txtCornDogsSubtotal.TabIndex = 24;
            this.txtCornDogsSubtotal.TabStop = false;
            this.txtCornDogsSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "x $4.00 = ";
            // 
            // txtCornDogs
            // 
            this.txtCornDogs.Location = new System.Drawing.Point(85, 33);
            this.txtCornDogs.Name = "txtCornDogs";
            this.txtCornDogs.Size = new System.Drawing.Size(38, 20);
            this.txtCornDogs.TabIndex = 22;
            this.txtCornDogs.Text = "0";
            this.txtCornDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Corn dogs:";
            // 
            // txtCheeseburgersSubtotal
            // 
            this.txtCheeseburgersSubtotal.Location = new System.Drawing.Point(177, 7);
            this.txtCheeseburgersSubtotal.Name = "txtCheeseburgersSubtotal";
            this.txtCheeseburgersSubtotal.ReadOnly = true;
            this.txtCheeseburgersSubtotal.Size = new System.Drawing.Size(59, 20);
            this.txtCheeseburgersSubtotal.TabIndex = 20;
            this.txtCheeseburgersSubtotal.TabStop = false;
            this.txtCheeseburgersSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "x $5.00 = ";
            // 
            // txtCheeseBurgers
            // 
            this.txtCheeseBurgers.Location = new System.Drawing.Point(85, 7);
            this.txtCheeseBurgers.Name = "txtCheeseBurgers";
            this.txtCheeseBurgers.Size = new System.Drawing.Size(38, 20);
            this.txtCheeseBurgers.TabIndex = 18;
            this.txtCheeseBurgers.Text = "0";
            this.txtCheeseBurgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cheeseburgers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(266, 195);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCornDogsSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCornDogs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheeseburgersSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCheeseBurgers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCornDogsSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCornDogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheeseburgersSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCheeseBurgers;
        private System.Windows.Forms.Label label1;
    }
}

