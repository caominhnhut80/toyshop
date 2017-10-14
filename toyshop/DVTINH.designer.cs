namespace toyshop
{
    partial class DVTINH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVTINH));
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.luoidvtngoai = new DevExpress.XtraGrid.GridControl();
            this.luoiDVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btthemdvt = new DevExpress.XtraEditors.SimpleButton();
            this.btxoadvt = new DevExpress.XtraEditors.SimpleButton();
            this.btsuadvt = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luoidvtngoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luoiDVT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // luoidvtngoai
            // 
            this.luoidvtngoai.Location = new System.Drawing.Point(-2, 43);
            this.luoidvtngoai.MainView = this.luoiDVT;
            this.luoidvtngoai.Name = "luoidvtngoai";
            this.luoidvtngoai.Size = new System.Drawing.Size(548, 283);
            this.luoidvtngoai.TabIndex = 26;
            this.luoidvtngoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.luoiDVT});
            this.luoidvtngoai.Load += new System.EventHandler(this.gridload);
            this.luoidvtngoai.Click += new System.EventHandler(this.luoidvtngoai_Click);
            // 
            // luoiDVT
            // 
            this.luoiDVT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.donvitinh});
            this.luoiDVT.GridControl = this.luoidvtngoai;
            this.luoiDVT.Name = "luoiDVT";
            this.luoiDVT.OptionsView.ShowGroupPanel = false;
            this.luoiDVT.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.id, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.donvitinh, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // id
            // 
            this.id.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.AppearanceHeader.Options.UseFont = true;
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.OptionsColumn.AllowFocus = false;
            this.id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // donvitinh
            // 
            this.donvitinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donvitinh.AppearanceHeader.Options.UseFont = true;
            this.donvitinh.Caption = "ĐƠN VỊ TÍNH";
            this.donvitinh.FieldName = "donvitinh";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.OptionsColumn.AllowEdit = false;
            this.donvitinh.OptionsColumn.AllowFocus = false;
            this.donvitinh.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.donvitinh.Visible = true;
            this.donvitinh.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineColor = System.Drawing.Color.Teal;
            this.labelControl1.Location = new System.Drawing.Point(-2, -5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(548, 47);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "                         ĐƠN VỊ TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "ĐƠN VỊ TÍNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdvt.Location = new System.Drawing.Point(336, 78);
            this.txtdvt.Multiline = true;
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(164, 34);
            this.txtdvt.TabIndex = 29;
            this.txtdvt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(336, 18);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(164, 34);
            this.txtid.TabIndex = 28;
            // 
            // btthemdvt
            // 
            this.btthemdvt.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemdvt.Appearance.Options.UseFont = true;
            this.btthemdvt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthemdvt.ImageOptions.Image")));
            this.btthemdvt.Location = new System.Drawing.Point(565, 20);
            this.btthemdvt.Name = "btthemdvt";
            this.btthemdvt.Size = new System.Drawing.Size(111, 34);
            this.btthemdvt.TabIndex = 35;
            this.btthemdvt.Text = "THÊM";
            this.btthemdvt.Click += new System.EventHandler(this.btthemdvt_Click_1);
            // 
            // btxoadvt
            // 
            this.btxoadvt.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoadvt.Appearance.Options.UseFont = true;
            this.btxoadvt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btxoadvt.ImageOptions.Image")));
            this.btxoadvt.Location = new System.Drawing.Point(720, 45);
            this.btxoadvt.Name = "btxoadvt";
            this.btxoadvt.Size = new System.Drawing.Size(114, 34);
            this.btxoadvt.TabIndex = 36;
            this.btxoadvt.Text = "XÓA";
            this.btxoadvt.Click += new System.EventHandler(this.btxoadvt_Click_1);
            // 
            // btsuadvt
            // 
            this.btsuadvt.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsuadvt.Appearance.Options.UseFont = true;
            this.btsuadvt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btsuadvt.ImageOptions.Image")));
            this.btsuadvt.Location = new System.Drawing.Point(565, 78);
            this.btsuadvt.Name = "btsuadvt";
            this.btsuadvt.Size = new System.Drawing.Size(111, 34);
            this.btsuadvt.TabIndex = 37;
            this.btsuadvt.Text = "SỬA";
            this.btsuadvt.Click += new System.EventHandler(this.btsuadvt_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.btsuadvt);
            this.groupBox1.Controls.Add(this.btxoadvt);
            this.groupBox1.Controls.Add(this.btthemdvt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdvt);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(-2, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 132);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dvt";
            // 
            // DVTINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.luoidvtngoai);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DVTINH";
            this.Text = "DONVITINH";
            this.Load += new System.EventHandler(this.DVTINH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luoidvtngoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luoiDVT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl luoidvtngoai;
        private DevExpress.XtraGrid.Views.Grid.GridView luoiDVT;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn donvitinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtid;
        private DevExpress.XtraEditors.SimpleButton btthemdvt;
        private DevExpress.XtraEditors.SimpleButton btxoadvt;
        private DevExpress.XtraEditors.SimpleButton btsuadvt;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}