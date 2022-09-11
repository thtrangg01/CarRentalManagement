namespace CarRentalManagement
{
    partial class frmSearchCarContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.contractDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cboRentalUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.Label();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceOnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pickUpCheckListIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnCheckListIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resrevedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.licensePlatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requireCheckListDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpCheckListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnCheckListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contractDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(97, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(391, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thuê từ ngày:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dddd, dd/MM/yyyy hh:mm";
            this.dtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractDetailBindingSource, "StartDate", true));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(97, 64);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(206, 23);
            this.dtStartDate.TabIndex = 2;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // contractDetailBindingSource
            // 
            this.contractDetailBindingSource.DataSource = typeof(BUS.Model.ContractDetail);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian thuê";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(398, 64);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 23);
            this.txtQty.TabIndex = 4;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // cboRentalUnit
            // 
            this.cboRentalUnit.FormattingEnabled = true;
            this.cboRentalUnit.Location = new System.Drawing.Point(464, 64);
            this.cboRentalUnit.Name = "cboRentalUnit";
            this.cboRentalUnit.Size = new System.Drawing.Size(121, 23);
            this.cboRentalUnit.TabIndex = 5;
            this.cboRentalUnit.SelectedIndexChanged += new System.EventHandler(this.cboRentalUnit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày trả:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.AutoSize = true;
            this.txtEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractDetailBindingSource, "EndDate", true));
            this.txtEndDate.Location = new System.Drawing.Point(651, 68);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(171, 15);
            this.txtEndDate.TabIndex = 6;
            this.txtEndDate.Text = "Thứ Ba 11/10/2022 18:05 (2 giờ)";
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.AutoGenerateColumns = false;
            this.dgvCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCar.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn,
            this.meterUnitDataGridViewTextBoxColumn,
            this.insuranceOnDataGridViewCheckBoxColumn,
            this.pickUpCheckListIdDataGridViewTextBoxColumn,
            this.returnCheckListIdDataGridViewTextBoxColumn,
            this.overtimeRateDataGridViewTextBoxColumn,
            this.resrevedDataGridViewCheckBoxColumn,
            this.licensePlatesDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.requireCheckListDataGridViewCheckBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.pickUpCheckListDataGridViewTextBoxColumn,
            this.returnCheckListDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAdDataGridViewTextBoxColumn});
            this.dgvCar.DataSource = this.carBindingSource;
            this.dgvCar.Location = new System.Drawing.Point(12, 93);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RowTemplate.Height = 25;
            this.dgvCar.Size = new System.Drawing.Size(821, 345);
            this.dgvCar.TabIndex = 7;
            this.dgvCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_CellDoubleClick);
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Hãng sản xuất";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Model";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Mã xe";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Visible = false;
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            this.meterDataGridViewTextBoxColumn.HeaderText = "Meter";
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterDataGridViewTextBoxColumn.Visible = false;
            // 
            // meterUnitDataGridViewTextBoxColumn
            // 
            this.meterUnitDataGridViewTextBoxColumn.DataPropertyName = "MeterUnit";
            this.meterUnitDataGridViewTextBoxColumn.HeaderText = "MeterUnit";
            this.meterUnitDataGridViewTextBoxColumn.Name = "meterUnitDataGridViewTextBoxColumn";
            this.meterUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterUnitDataGridViewTextBoxColumn.Visible = false;
            // 
            // insuranceOnDataGridViewCheckBoxColumn
            // 
            this.insuranceOnDataGridViewCheckBoxColumn.DataPropertyName = "InsuranceOn";
            this.insuranceOnDataGridViewCheckBoxColumn.HeaderText = "InsuranceOn";
            this.insuranceOnDataGridViewCheckBoxColumn.Name = "insuranceOnDataGridViewCheckBoxColumn";
            this.insuranceOnDataGridViewCheckBoxColumn.ReadOnly = true;
            this.insuranceOnDataGridViewCheckBoxColumn.Visible = false;
            // 
            // pickUpCheckListIdDataGridViewTextBoxColumn
            // 
            this.pickUpCheckListIdDataGridViewTextBoxColumn.DataPropertyName = "PickUpCheckListId";
            this.pickUpCheckListIdDataGridViewTextBoxColumn.HeaderText = "PickUpCheckListId";
            this.pickUpCheckListIdDataGridViewTextBoxColumn.Name = "pickUpCheckListIdDataGridViewTextBoxColumn";
            this.pickUpCheckListIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pickUpCheckListIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // returnCheckListIdDataGridViewTextBoxColumn
            // 
            this.returnCheckListIdDataGridViewTextBoxColumn.DataPropertyName = "ReturnCheckListId";
            this.returnCheckListIdDataGridViewTextBoxColumn.HeaderText = "ReturnCheckListId";
            this.returnCheckListIdDataGridViewTextBoxColumn.Name = "returnCheckListIdDataGridViewTextBoxColumn";
            this.returnCheckListIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnCheckListIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // overtimeRateDataGridViewTextBoxColumn
            // 
            this.overtimeRateDataGridViewTextBoxColumn.DataPropertyName = "OvertimeRate";
            this.overtimeRateDataGridViewTextBoxColumn.HeaderText = "OvertimeRate";
            this.overtimeRateDataGridViewTextBoxColumn.Name = "overtimeRateDataGridViewTextBoxColumn";
            this.overtimeRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.overtimeRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // resrevedDataGridViewCheckBoxColumn
            // 
            this.resrevedDataGridViewCheckBoxColumn.DataPropertyName = "Resreved";
            this.resrevedDataGridViewCheckBoxColumn.HeaderText = "Resreved";
            this.resrevedDataGridViewCheckBoxColumn.Name = "resrevedDataGridViewCheckBoxColumn";
            this.resrevedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.resrevedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // licensePlatesDataGridViewTextBoxColumn
            // 
            this.licensePlatesDataGridViewTextBoxColumn.DataPropertyName = "LicensePlates";
            this.licensePlatesDataGridViewTextBoxColumn.HeaderText = "Biển số xe";
            this.licensePlatesDataGridViewTextBoxColumn.Name = "licensePlatesDataGridViewTextBoxColumn";
            this.licensePlatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Năm sản xuất";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requireCheckListDataGridViewCheckBoxColumn
            // 
            this.requireCheckListDataGridViewCheckBoxColumn.DataPropertyName = "RequireCheckList";
            this.requireCheckListDataGridViewCheckBoxColumn.HeaderText = "RequireCheckList";
            this.requireCheckListDataGridViewCheckBoxColumn.Name = "requireCheckListDataGridViewCheckBoxColumn";
            this.requireCheckListDataGridViewCheckBoxColumn.ReadOnly = true;
            this.requireCheckListDataGridViewCheckBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // pickUpCheckListDataGridViewTextBoxColumn
            // 
            this.pickUpCheckListDataGridViewTextBoxColumn.DataPropertyName = "PickUpCheckList";
            this.pickUpCheckListDataGridViewTextBoxColumn.HeaderText = "PickUpCheckList";
            this.pickUpCheckListDataGridViewTextBoxColumn.Name = "pickUpCheckListDataGridViewTextBoxColumn";
            this.pickUpCheckListDataGridViewTextBoxColumn.ReadOnly = true;
            this.pickUpCheckListDataGridViewTextBoxColumn.Visible = false;
            // 
            // returnCheckListDataGridViewTextBoxColumn
            // 
            this.returnCheckListDataGridViewTextBoxColumn.DataPropertyName = "ReturnCheckList";
            this.returnCheckListDataGridViewTextBoxColumn.HeaderText = "ReturnCheckList";
            this.returnCheckListDataGridViewTextBoxColumn.Name = "returnCheckListDataGridViewTextBoxColumn";
            this.returnCheckListDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnCheckListDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedAdDataGridViewTextBoxColumn
            // 
            this.updatedAdDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAd";
            this.updatedAdDataGridViewTextBoxColumn.HeaderText = "UpdatedAd";
            this.updatedAdDataGridViewTextBoxColumn.Name = "updatedAdDataGridViewTextBoxColumn";
            this.updatedAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAdDataGridViewTextBoxColumn.Visible = false;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(BUS.Model.Car);
            // 
            // frmSearchCarContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.cboRentalUnit);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchCarContract";
            this.Text = "Chọn sản phẩm thuê";
            ((System.ComponentModel.ISupportInitialize)(this.contractDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cboRentalUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtEndDate;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.BindingSource contractDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn insuranceOnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpCheckListIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnCheckListIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn resrevedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requireCheckListDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpCheckListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnCheckListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAdDataGridViewTextBoxColumn;
    }
}