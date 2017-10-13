namespace toyshop
{
    partial class frmSanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanpham));
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.luoitenchngoai = new DevExpress.XtraGrid.GridControl();
            this.luoitench = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.donvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.combodvt = new System.Windows.Forms.ComboBox();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoitenchngoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luoitench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmahang
            // 
            this.txtmahang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahang.Location = new System.Drawing.Point(123, 37);
            this.txtmahang.Multiline = true;
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(200, 39);
            this.txtmahang.TabIndex = 1;
            // 
            // txttenhang
            // 
            this.txttenhang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenhang.Location = new System.Drawing.Point(329, 37);
            this.txttenhang.Multiline = true;
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(332, 39);
            this.txttenhang.TabIndex = 10;
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupbox.Controls.Add(this.combodvt);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label7);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.btxoa);
            this.groupbox.Controls.Add(this.btsua);
            this.groupbox.Controls.Add(this.btthem);
            this.groupbox.Controls.Add(this.txttenhang);
            this.groupbox.Controls.Add(this.txtmahang);
            this.groupbox.Location = new System.Drawing.Point(0, 268);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(1001, 137);
            this.groupbox.TabIndex = 24;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "sanpham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "MÃ HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "ĐƠN VỊ TÍNH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "TÊN HÀNG";
            // 
            // btxoa
            // 
            this.btxoa.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Appearance.Options.UseFont = true;
            this.btxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.ImageOptions.Image")));
            this.btxoa.Location = new System.Drawing.Point(708, 81);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(155, 42);
            this.btxoa.TabIndex = 18;
            this.btxoa.Text = "XÓA";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // btsua
            // 
            this.btsua.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Appearance.Options.UseFont = true;
            this.btsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btsua.ImageOptions.Image")));
            this.btsua.Location = new System.Drawing.Point(421, 81);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(149, 42);
            this.btsua.TabIndex = 17;
            this.btsua.Text = "SỬA";
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btthem
            // 
            this.btthem.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Appearance.Options.UseFont = true;
            this.btthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthem.ImageOptions.Image")));
            this.btthem.Location = new System.Drawing.Point(144, 82);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(155, 42);
            this.btthem.TabIndex = 16;
            this.btthem.Text = "THÊM";
            this.btthem.Click += new System.EventHandler(this.btthem_Click_1);
            // 
            // luoitenchngoai
            // 
            this.luoitenchngoai.Location = new System.Drawing.Point(0, 43);
            this.luoitenchngoai.MainView = this.luoitench;
            this.luoitenchngoai.Name = "luoitenchngoai";
            this.luoitenchngoai.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.luoitenchngoai.Size = new System.Drawing.Size(991, 219);
            this.luoitenchngoai.TabIndex = 25;
            this.luoitenchngoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.luoitench});
            // 
            // luoitench
            // 
            this.luoitench.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mahang,
            this.tenhang,
            this.donvitinh});
            this.luoitench.GridControl = this.luoitenchngoai;
            this.luoitench.Name = "luoitench";
            this.luoitench.OptionsView.ShowAutoFilterRow = true;
            this.luoitench.OptionsView.ShowGroupPanel = false;
            this.luoitench.Click += new System.EventHandler(this.luoitench_Click);
            // 
            // mahang
            // 
            this.mahang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahang.AppearanceHeader.Options.UseFont = true;
            this.mahang.Caption = "MÃ HÀNG";
            this.mahang.FieldName = "mahang";
            this.mahang.Name = "mahang";
            this.mahang.OptionsColumn.AllowEdit = false;
            this.mahang.OptionsColumn.AllowFocus = false;
            this.mahang.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.mahang.Visible = true;
            this.mahang.VisibleIndex = 0;
            this.mahang.Width = 315;
            // 
            // tenhang
            // 
            this.tenhang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenhang.AppearanceHeader.Options.UseFont = true;
            this.tenhang.Caption = "TÊN HÀNG";
            this.tenhang.ColumnEdit = this.repositoryItemButtonEdit1;
            this.tenhang.FieldName = "tenhang";
            this.tenhang.Name = "tenhang";
            this.tenhang.OptionsColumn.AllowEdit = false;
            this.tenhang.OptionsColumn.AllowFocus = false;
            this.tenhang.Visible = true;
            this.tenhang.VisibleIndex = 1;
            this.tenhang.Width = 369;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // donvitinh
            // 
            this.donvitinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donvitinh.AppearanceHeader.Options.UseFont = true;
            this.donvitinh.Caption = "ĐƠN VỊ TÍNH";
            this.donvitinh.ColumnEdit = this.repositoryItemButtonEdit1;
            this.donvitinh.FieldName = "donvitinh";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.OptionsColumn.AllowEdit = false;
            this.donvitinh.OptionsColumn.AllowFocus = false;
            this.donvitinh.Visible = true;
            this.donvitinh.VisibleIndex = 2;
            this.donvitinh.Width = 299;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(359, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(260, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // combodvt
            // 
            this.combodvt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodvt.FormattingEnabled = true;
            this.combodvt.Location = new System.Drawing.Point(667, 41);
            this.combodvt.Name = "combodvt";
            this.combodvt.Size = new System.Drawing.Size(214, 35);
            this.combodvt.TabIndex = 24;
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 417);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.luoitenchngoai);
            this.Controls.Add(this.groupbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSanpham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoitenchngoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luoitench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.GroupBox groupbox;
        private DevExpress.XtraGrid.GridControl luoitenchngoai;
        private DevExpress.XtraGrid.Views.Grid.GridView luoitench;
        private DevExpress.XtraGrid.Columns.GridColumn mahang;
        private DevExpress.XtraGrid.Columns.GridColumn tenhang;
        private DevExpress.XtraGrid.Columns.GridColumn donvitinh;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combodvt;
    }
}

