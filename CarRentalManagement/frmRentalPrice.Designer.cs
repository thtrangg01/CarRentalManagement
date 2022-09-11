namespace CarRentalManagement
{
    partial class frmRentalPrice
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
            this.components = new System.ComponentModel.Container();
            this.lblCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRentalTime = new System.Windows.Forms.Label();
            this.pnFlat = new System.Windows.Forms.Panel();
            this.lblFlatRate = new System.Windows.Forms.Label();
            this.lblFlat = new System.Windows.Forms.Label();
            this.pnHourly = new System.Windows.Forms.Panel();
            this.lblHourRate = new System.Windows.Forms.Label();
            this.lblHourly = new System.Windows.Forms.Label();
            this.pnDaily = new System.Windows.Forms.Panel();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPercentDiscount = new System.Windows.Forms.TextBox();
            this.contractDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPercentTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnFlat.SuspendLayout();
            this.pnHourly.SuspendLayout();
            this.pnDaily.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDetailBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.lblCar.Location = new System.Drawing.Point(12, 9);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(263, 17);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "CAR00001 - Mercedes S450 - (35B1-83068)\r\n";
            this.lblCar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian thuê:";
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.AutoSize = true;
            this.lblRentalTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(189)))), ((int)(((byte)(109)))));
            this.lblRentalTime.Location = new System.Drawing.Point(103, 35);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.Size = new System.Drawing.Size(218, 15);
            this.lblRentalTime.TabIndex = 2;
            this.lblRentalTime.Text = "06/09/2022 15:30 - 07/09/2022 15:30";
            // 
            // pnFlat
            // 
            this.pnFlat.Controls.Add(this.lblFlatRate);
            this.pnFlat.Controls.Add(this.lblFlat);
            this.pnFlat.Location = new System.Drawing.Point(3, 3);
            this.pnFlat.Name = "pnFlat";
            this.pnFlat.Size = new System.Drawing.Size(330, 20);
            this.pnFlat.TabIndex = 3;
            // 
            // lblFlatRate
            // 
            this.lblFlatRate.AutoSize = true;
            this.lblFlatRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFlatRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.lblFlatRate.Location = new System.Drawing.Point(275, 0);
            this.lblFlatRate.Name = "lblFlatRate";
            this.lblFlatRate.Size = new System.Drawing.Size(55, 15);
            this.lblFlatRate.TabIndex = 1;
            this.lblFlatRate.Text = "1.200.000";
            this.lblFlatRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFlat
            // 
            this.lblFlat.AutoSize = true;
            this.lblFlat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFlat.Location = new System.Drawing.Point(0, 0);
            this.lblFlat.Name = "lblFlat";
            this.lblFlat.Size = new System.Drawing.Size(55, 15);
            this.lblFlat.TabIndex = 0;
            this.lblFlat.Text = "Đồng giá";
            // 
            // pnHourly
            // 
            this.pnHourly.Controls.Add(this.lblHourRate);
            this.pnHourly.Controls.Add(this.lblHourly);
            this.pnHourly.Location = new System.Drawing.Point(3, 29);
            this.pnHourly.Name = "pnHourly";
            this.pnHourly.Size = new System.Drawing.Size(330, 20);
            this.pnHourly.TabIndex = 4;
            // 
            // lblHourRate
            // 
            this.lblHourRate.AutoSize = true;
            this.lblHourRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHourRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.lblHourRate.Location = new System.Drawing.Point(290, 0);
            this.lblHourRate.Name = "lblHourRate";
            this.lblHourRate.Size = new System.Drawing.Size(40, 15);
            this.lblHourRate.TabIndex = 2;
            this.lblHourRate.Text = "40.000";
            this.lblHourRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHourly
            // 
            this.lblHourly.AutoSize = true;
            this.lblHourly.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHourly.Location = new System.Drawing.Point(0, 0);
            this.lblHourly.Name = "lblHourly";
            this.lblHourly.Size = new System.Drawing.Size(55, 15);
            this.lblHourly.TabIndex = 0;
            this.lblHourly.Text = "Đồng giá";
            // 
            // pnDaily
            // 
            this.pnDaily.Controls.Add(this.lblDailyRate);
            this.pnDaily.Controls.Add(this.lblDaily);
            this.pnDaily.Location = new System.Drawing.Point(3, 55);
            this.pnDaily.Name = "pnDaily";
            this.pnDaily.Size = new System.Drawing.Size(330, 20);
            this.pnDaily.TabIndex = 5;
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDailyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.lblDailyRate.Location = new System.Drawing.Point(284, 0);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(46, 15);
            this.lblDailyRate.TabIndex = 3;
            this.lblDailyRate.Text = "500.000";
            this.lblDailyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDaily.Location = new System.Drawing.Point(0, 0);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(55, 15);
            this.lblDaily.TabIndex = 0;
            this.lblDaily.Text = "Đồng giá";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnFlat);
            this.flowLayoutPanel1.Controls.Add(this.pnHourly);
            this.flowLayoutPanel1.Controls.Add(this.pnDaily);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 82);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chiết khấu";
            // 
            // txtPercentDiscount
            // 
            this.txtPercentDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractDetailBindingSource, "PercenDiscount", true));
            this.txtPercentDiscount.Location = new System.Drawing.Point(103, 156);
            this.txtPercentDiscount.Name = "txtPercentDiscount";
            this.txtPercentDiscount.Size = new System.Drawing.Size(52, 23);
            this.txtPercentDiscount.TabIndex = 8;
            // 
            // txtDiscount
            // 
            this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractDetailBindingSource, "Discount", true));
            this.txtDiscount.Location = new System.Drawing.Point(191, 156);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(153, 23);
            this.txtDiscount.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "%";
            // 
            // txtTax
            // 
            this.txtTax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractDetailBindingSource, "Tax", true));
            this.txtTax.Location = new System.Drawing.Point(191, 192);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(153, 23);
            this.txtTax.TabIndex = 11;
            // 
            // txtPercentTax
            // 
            this.txtPercentTax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractDetailBindingSource, "PercentTax", true));
            this.txtPercentTax.Location = new System.Drawing.Point(103, 192);
            this.txtPercentTax.Name = "txtPercentTax";
            this.txtPercentTax.Size = new System.Drawing.Size(52, 23);
            this.txtPercentTax.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thuế";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tổng cộng";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(188, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.lblSubtotal.Location = new System.Drawing.Point(80, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubtotal.Size = new System.Drawing.Size(161, 19);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "5456456400000000000";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Location = new System.Drawing.Point(103, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 19);
            this.panel1.TabIndex = 15;
            // 
            // frmRentalPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPercentTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPercentDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRentalTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCar);
            this.Name = "frmRentalPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết giá thuê";
            this.Load += new System.EventHandler(this.frmRentalPrice_Load);
            this.pnFlat.ResumeLayout(false);
            this.pnFlat.PerformLayout();
            this.pnHourly.ResumeLayout(false);
            this.pnHourly.PerformLayout();
            this.pnDaily.ResumeLayout(false);
            this.pnDaily.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractDetailBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRentalTime;
        private System.Windows.Forms.Panel pnFlat;
        private System.Windows.Forms.Label lblFlat;
        private System.Windows.Forms.Panel pnHourly;
        private System.Windows.Forms.Label lblHourly;
        private System.Windows.Forms.Panel pnDaily;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPercentDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPercentTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource contractDetailBindingSource;
        private System.Windows.Forms.Label lblFlatRate;
        private System.Windows.Forms.Label lblHourRate;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Panel panel1;
    }
}