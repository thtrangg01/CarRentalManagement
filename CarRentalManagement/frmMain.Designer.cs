namespace CarRentalManagement
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCar = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContract = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContract = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 383);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(576, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuCar,
            this.mnuContract,
            this.mnuCustomer,
            this.mnuReport,
            this.mnuSignOut});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(576, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstStaff});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(73, 20);
            this.mnuSystem.Text = "Nhân viên";
            // 
            // lstStaff
            // 
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(184, 22);
            this.lstStaff.Text = "Danh sách nhân viên";
            this.lstStaff.Click += new System.EventHandler(this.lstStaff_Click);
            // 
            // mnuCar
            // 
            this.mnuCar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstCar});
            this.mnuCar.Name = "mnuCar";
            this.mnuCar.Size = new System.Drawing.Size(42, 20);
            this.mnuCar.Text = "Ô tô";
            // 
            // lstCar
            // 
            this.lstCar.Name = "lstCar";
            this.lstCar.Size = new System.Drawing.Size(153, 22);
            this.lstCar.Text = "Danh sách ô tô";
            this.lstCar.Click += new System.EventHandler(this.lstCar_Click);
            // 
            // mnuContract
            // 
            this.mnuContract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstContract});
            this.mnuContract.Name = "mnuContract";
            this.mnuContract.Size = new System.Drawing.Size(73, 20);
            this.mnuContract.Text = "Hợp đồng";
            // 
            // lstContract
            // 
            this.lstContract.Name = "lstContract";
            this.lstContract.Size = new System.Drawing.Size(184, 22);
            this.lstContract.Text = "Danh sách hợp đồng";
            this.lstContract.Click += new System.EventHandler(this.lstContract_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstCustomer});
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(82, 20);
            this.mnuCustomer.Text = "Khách hàng";
            // 
            // lstCustomer
            // 
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(194, 22);
            this.lstCustomer.Text = "Danh sách khách hàng";
            this.lstCustomer.Click += new System.EventHandler(this.lstCustomer_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(114, 20);
            this.mnuReport.Text = "Báo cáo, thống kê";
            // 
            // mnuSignOut
            // 
            this.mnuSignOut.Name = "mnuSignOut";
            this.mnuSignOut.Size = new System.Drawing.Size(73, 20);
            this.mnuSignOut.Text = "Đăng xuất";
            this.mnuSignOut.Click += new System.EventHandler(this.mnuSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::CarRentalManagement.Properties.Resources.thutcthuexe2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuCar;
        private System.Windows.Forms.ToolStripMenuItem mnuContract;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSignOut;
        private System.Windows.Forms.ToolStripMenuItem lstCar;
        private System.Windows.Forms.ToolStripMenuItem lstContract;
        private System.Windows.Forms.ToolStripMenuItem lstCustomer;
        private System.Windows.Forms.ToolStripMenuItem lstStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



