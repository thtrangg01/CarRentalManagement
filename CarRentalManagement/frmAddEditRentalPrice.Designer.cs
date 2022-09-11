namespace CarRentalManagement
{
    partial class frmAddEditRentalPrice
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
            this.cboTittle = new System.Windows.Forms.ComboBox();
            this.rentalPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTittle
            // 
            this.cboTittle.DataSource = this.rentalPriceBindingSource;
            this.cboTittle.DisplayMember = "Title";
            this.cboTittle.FormattingEnabled = true;
            this.cboTittle.Location = new System.Drawing.Point(12, 27);
            this.cboTittle.Name = "cboTittle";
            this.cboTittle.Size = new System.Drawing.Size(121, 23);
            this.cboTittle.TabIndex = 1;
            this.cboTittle.ValueMember = "Id";
            this.cboTittle.SelectedIndexChanged += new System.EventHandler(this.cboTittle_SelectedIndexChanged);
            // 
            // rentalPriceBindingSource
            // 
            this.rentalPriceBindingSource.DataSource = typeof(Domain.Entities.RentalPrice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới hạn";
            // 
            // txtLimit
            // 
            this.txtLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalPriceBindingSource, "MeterLimit", true));
            this.txtLimit.Location = new System.Drawing.Point(275, 27);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(65, 23);
            this.txtLimit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá";
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalPriceBindingSource, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(142, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(124, 23);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(306, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            this.txtRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalPriceBindingSource, "Rate", true));
            this.txtRate.Location = new System.Drawing.Point(349, 27);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(91, 23);
            this.txtRate.TabIndex = 2;
            // 
            // frmAddEditRentalPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 99);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTittle);
            this.Name = "frmAddEditRentalPrice";
            this.Text = "frmAddEditRentalPrice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditRentalPrice_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource rentalPriceBindingSource;
        private System.Windows.Forms.TextBox txtRate;
    }
}