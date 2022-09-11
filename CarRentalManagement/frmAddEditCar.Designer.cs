using Domain.Entities;

namespace CarRentalManagement
{
    partial class frmAddEditCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCar));
            this.imgCar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbRequireCheckList = new System.Windows.Forms.CheckBox();
            this.lblPickUpCheckList = new System.Windows.Forms.Label();
            this.lblReturnCheckList = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvRentalPrice = new System.Windows.Forms.DataGridView();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carEntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.carEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txtOverCharge = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMeter = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCar
            // 
            this.imgCar.Image = ((System.Drawing.Image)(resources.GetObject("imgCar.Image")));
            this.imgCar.Location = new System.Drawing.Point(12, 12);
            this.imgCar.Name = "imgCar";
            this.imgCar.Size = new System.Drawing.Size(300, 300);
            this.imgCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCar.TabIndex = 0;
            this.imgCar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái:";
            // 
            // chbRequireCheckList
            // 
            this.chbRequireCheckList.AutoSize = true;
            this.chbRequireCheckList.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carBindingSource, "RequireCheckList", true));
            this.chbRequireCheckList.Location = new System.Drawing.Point(12, 423);
            this.chbRequireCheckList.Name = "chbRequireCheckList";
            this.chbRequireCheckList.Size = new System.Drawing.Size(186, 19);
            this.chbRequireCheckList.TabIndex = 3;
            this.chbRequireCheckList.Text = "Yêu cầu kiểm tra giao/nhận xe";
            this.chbRequireCheckList.UseVisualStyleBackColor = true;
            this.chbRequireCheckList.CheckedChanged += new System.EventHandler(this.chbRequireCheckList_CheckedChanged);
            // 
            // lblPickUpCheckList
            // 
            this.lblPickUpCheckList.AutoSize = true;
            this.lblPickUpCheckList.Location = new System.Drawing.Point(30, 447);
            this.lblPickUpCheckList.Name = "lblPickUpCheckList";
            this.lblPickUpCheckList.Size = new System.Drawing.Size(134, 15);
            this.lblPickUpCheckList.TabIndex = 4;
            this.lblPickUpCheckList.Text = "Danh mục kiểm tra giao";
            this.lblPickUpCheckList.Visible = false;
            this.lblPickUpCheckList.Click += new System.EventHandler(this.lblPickUpCheckList_Click);
            // 
            // lblReturnCheckList
            // 
            this.lblReturnCheckList.AutoSize = true;
            this.lblReturnCheckList.Location = new System.Drawing.Point(30, 467);
            this.lblReturnCheckList.Name = "lblReturnCheckList";
            this.lblReturnCheckList.Size = new System.Drawing.Size(138, 15);
            this.lblReturnCheckList.TabIndex = 4;
            this.lblReturnCheckList.Text = "Danh mục kiểm tra nhận";
            this.lblReturnCheckList.Visible = false;
            this.lblReturnCheckList.Click += new System.EventHandler(this.lblReturnCheckList_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(329, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Biển số xe:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "LicensePlates", true));
            this.textBox4.Location = new System.Drawing.Point(426, 233);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 23);
            this.textBox4.TabIndex = 3;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(BUS.Model.Car);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày nhập kho:";
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.carBindingSource, "Manufacturer", true));
            this.cboManufacturer.DataSource = this.manufacturerBindingSource;
            this.cboManufacturer.DisplayMember = "Name";
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Location = new System.Drawing.Point(426, 146);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(191, 23);
            this.cboManufacturer.TabIndex = 1;
            this.cboManufacturer.ValueMember = "Id";
            this.cboManufacturer.SelectedValueChanged += new System.EventHandler(this.cboManufacturer_SelectedValueChanged);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(Domain.Entities.Manufacturer);
            // 
            // cboProduct
            // 
            this.cboProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.carBindingSource, "Product", true));
            this.cboProduct.DataSource = this.productBindingSource;
            this.cboProduct.DisplayMember = "ProductCode";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(426, 187);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(149, 23);
            this.cboProduct.TabIndex = 2;
            this.cboProduct.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Domain.Entities.Product);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Năm:";
            // 
            // txtYear
            // 
            this.txtYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Year", true));
            this.txtYear.Location = new System.Drawing.Point(694, 187);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(164, 23);
            this.txtYear.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(637, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Màu:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(694, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 23);
            this.textBox3.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã số:";
            // 
            // txtNumber
            // 
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumber.Location = new System.Drawing.Point(80, 336);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(139, 23);
            this.txtNumber.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(721, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Ghi nhận";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(800, 507);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(60, 30);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dgvRentalPrice
            // 
            this.dgvRentalPrice.AllowUserToAddRows = false;
            this.dgvRentalPrice.AllowUserToDeleteRows = false;
            this.dgvRentalPrice.AutoGenerateColumns = false;
            this.dgvRentalPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentalPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.meterLimitDataGridViewTextBoxColumn,
            this.keyCodeDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.carEntityDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.dgvRentalPrice.DataSource = this.rentalPricesBindingSource;
            this.dgvRentalPrice.Location = new System.Drawing.Point(331, 376);
            this.dgvRentalPrice.Name = "dgvRentalPrice";
            this.dgvRentalPrice.ReadOnly = true;
            this.dgvRentalPrice.RowTemplate.Height = 25;
            this.dgvRentalPrice.Size = new System.Drawing.Size(529, 120);
            this.dgvRentalPrice.TabIndex = 12;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meterLimitDataGridViewTextBoxColumn
            // 
            this.meterLimitDataGridViewTextBoxColumn.DataPropertyName = "MeterLimit";
            this.meterLimitDataGridViewTextBoxColumn.HeaderText = "Giới hạn";
            this.meterLimitDataGridViewTextBoxColumn.Name = "meterLimitDataGridViewTextBoxColumn";
            this.meterLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyCodeDataGridViewTextBoxColumn
            // 
            this.keyCodeDataGridViewTextBoxColumn.DataPropertyName = "KeyCode";
            this.keyCodeDataGridViewTextBoxColumn.HeaderText = "KeyCode";
            this.keyCodeDataGridViewTextBoxColumn.Name = "keyCodeDataGridViewTextBoxColumn";
            this.keyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carEntityDataGridViewTextBoxColumn
            // 
            this.carEntityDataGridViewTextBoxColumn.DataPropertyName = "CarEntity";
            this.carEntityDataGridViewTextBoxColumn.HeaderText = "CarEntity";
            this.carEntityDataGridViewTextBoxColumn.Name = "carEntityDataGridViewTextBoxColumn";
            this.carEntityDataGridViewTextBoxColumn.ReadOnly = true;
            this.carEntityDataGridViewTextBoxColumn.Visible = false;
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
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // rentalPricesBindingSource
            // 
            this.rentalPricesBindingSource.DataMember = "RentalPrices";
            this.rentalPricesBindingSource.DataSource = this.carBindingSource;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Bảng giá thuê:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thiết lập giá thuê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Status", true));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(189)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(84, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá mua:";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Cost", true));
            this.txtCost.Location = new System.Drawing.Point(694, 275);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(164, 23);
            this.txtCost.TabIndex = 7;
            // 
            // carEntityBindingSource
            // 
            this.carEntityBindingSource.DataSource = typeof(Domain.Entities.CarEntity);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tiền quá hạn:";
            // 
            // txtOverCharge
            // 
            this.txtOverCharge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "OvertimeRate", true));
            this.txtOverCharge.Location = new System.Drawing.Point(426, 310);
            this.txtOverCharge.Name = "txtOverCharge";
            this.txtOverCharge.Size = new System.Drawing.Size(191, 23);
            this.txtOverCharge.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(637, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Meter:";
            // 
            // cboMeter
            // 
            this.cboMeter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "MeterUnit", true));
            this.cboMeter.DisplayMember = "ProductCode";
            this.cboMeter.FormattingEnabled = true;
            this.cboMeter.Location = new System.Drawing.Point(694, 310);
            this.cboMeter.Name = "cboMeter";
            this.cboMeter.Size = new System.Drawing.Size(164, 23);
            this.cboMeter.TabIndex = 2;
            this.cboMeter.ValueMember = "Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(624, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "/";
            // 
            // frmAddEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvRentalPrice);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboMeter);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblReturnCheckList);
            this.Controls.Add(this.lblPickUpCheckList);
            this.Controls.Add(this.chbRequireCheckList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtOverCharge);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgCar);
            this.Name = "frmAddEditCar";
            this.Text = "frmAddEditCar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditCar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbRequireCheckList;
        private System.Windows.Forms.Label lblPickUpCheckList;
        private System.Windows.Forms.Label lblReturnCheckList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView dgvRentalPrice;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.BindingSource carEntityBindingSource;
        private System.Windows.Forms.BindingSource rentalPricesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carEntityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOverCharge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboMeter;
        private System.Windows.Forms.Label label15;
    }
}