namespace toyshop
{
    partial class frmsetGiaban
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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tbSp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbGiabansi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbGiabanle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbGianhap = new DevExpress.XtraEditors.TextEdit();
            this.gv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgianhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiabanle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgiabansi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMahang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiabansi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiabanle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGianhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMahang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sidePanel1.Controls.Add(this.tbMahang);
            this.sidePanel1.Controls.Add(this.labelControl6);
            this.sidePanel1.Controls.Add(this.tbGiabanle);
            this.sidePanel1.Controls.Add(this.tbSp);
            this.sidePanel1.Controls.Add(this.labelControl5);
            this.sidePanel1.Controls.Add(this.btLuu);
            this.sidePanel1.Controls.Add(this.labelControl4);
            this.sidePanel1.Controls.Add(this.tbGiabansi);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.tbGianhap);
            this.sidePanel1.Location = new System.Drawing.Point(257, 12);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(270, 217);
            this.sidePanel1.TabIndex = 13;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tbSp
            // 
            this.tbSp.EditValue = "";
            this.tbSp.Enabled = false;
            this.tbSp.Location = new System.Drawing.Point(87, 60);
            this.tbSp.Name = "tbSp";
            this.tbSp.Size = new System.Drawing.Size(153, 20);
            this.tbSp.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(108, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "ĐẶT GIÁ BÁN";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(106, 191);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 19;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Giá bán sỉ";
            // 
            // tbGiabansi
            // 
            this.tbGiabansi.EditValue = "0";
            this.tbGiabansi.Location = new System.Drawing.Point(87, 130);
            this.tbGiabansi.Name = "tbGiabansi";
            this.tbGiabansi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGiabansi.Size = new System.Drawing.Size(153, 20);
            this.tbGiabansi.TabIndex = 17;
            this.tbGiabansi.Click += new System.EventHandler(this.tbGiabansi_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Giá bán lẻ";
            // 
            // tbGiabanle
            // 
            this.tbGiabanle.EditValue = "0";
            this.tbGiabanle.Location = new System.Drawing.Point(87, 161);
            this.tbGiabanle.Name = "tbGiabanle";
            this.tbGiabanle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGiabanle.Size = new System.Drawing.Size(153, 20);
            this.tbGiabanle.TabIndex = 15;
            this.tbGiabanle.Click += new System.EventHandler(this.tbGiabanle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Giá nhập";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Sản phẩm";
            // 
            // tbGianhap
            // 
            this.tbGianhap.EditValue = "0";
            this.tbGianhap.Enabled = false;
            this.tbGianhap.Location = new System.Drawing.Point(87, 94);
            this.tbGianhap.Name = "tbGianhap";
            this.tbGianhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGianhap.Size = new System.Drawing.Size(153, 20);
            this.tbGianhap.TabIndex = 12;
            // 
            // gv
            // 
            this.gv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv.Location = new System.Drawing.Point(0, 235);
            this.gv.MainView = this.gridView1;
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(684, 264);
            this.gv.TabIndex = 14;
            this.gv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahang,
            this.coltenhang,
            this.colsoluong,
            this.colgianhap,
            this.colgiabanle,
            this.colgiabansi,
            this.coldonvitinh,
            this.colid});
            this.gridView1.GridControl = this.gv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colmahang
            // 
            this.colmahang.AppearanceCell.Options.UseTextOptions = true;
            this.colmahang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmahang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmahang.AppearanceHeader.Options.UseFont = true;
            this.colmahang.AppearanceHeader.Options.UseTextOptions = true;
            this.colmahang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmahang.Caption = "Mã hàng";
            this.colmahang.DisplayFormat.FormatString = "#,###,###,##0";
            this.colmahang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmahang.FieldName = "mahang";
            this.colmahang.Name = "colmahang";
            this.colmahang.Visible = true;
            this.colmahang.VisibleIndex = 1;
            // 
            // coltenhang
            // 
            this.coltenhang.AppearanceCell.Options.UseTextOptions = true;
            this.coltenhang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenhang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltenhang.AppearanceHeader.Options.UseFont = true;
            this.coltenhang.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenhang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenhang.Caption = "Tên hàng";
            this.coltenhang.DisplayFormat.FormatString = "#,###,###,##0";
            this.coltenhang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltenhang.FieldName = "tenhang";
            this.coltenhang.Name = "coltenhang";
            this.coltenhang.Visible = true;
            this.coltenhang.VisibleIndex = 2;
            // 
            // colsoluong
            // 
            this.colsoluong.AppearanceCell.Options.UseTextOptions = true;
            this.colsoluong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colsoluong.AppearanceHeader.Options.UseFont = true;
            this.colsoluong.AppearanceHeader.Options.UseTextOptions = true;
            this.colsoluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.Caption = "Số lượng tồn";
            this.colsoluong.DisplayFormat.FormatString = "#,###,###,##0";
            this.colsoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 7;
            // 
            // colgianhap
            // 
            this.colgianhap.AppearanceCell.Options.UseTextOptions = true;
            this.colgianhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgianhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colgianhap.AppearanceHeader.Options.UseFont = true;
            this.colgianhap.AppearanceHeader.Options.UseTextOptions = true;
            this.colgianhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgianhap.Caption = "Giá nhập";
            this.colgianhap.DisplayFormat.FormatString = "#,###,###,##0";
            this.colgianhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgianhap.FieldName = "gianhap";
            this.colgianhap.Name = "colgianhap";
            this.colgianhap.Visible = true;
            this.colgianhap.VisibleIndex = 4;
            // 
            // colgiabanle
            // 
            this.colgiabanle.AppearanceCell.Options.UseTextOptions = true;
            this.colgiabanle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgiabanle.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colgiabanle.AppearanceHeader.Options.UseFont = true;
            this.colgiabanle.AppearanceHeader.Options.UseTextOptions = true;
            this.colgiabanle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgiabanle.Caption = "Giá bán lẻ";
            this.colgiabanle.DisplayFormat.FormatString = "#,###,###,##0";
            this.colgiabanle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgiabanle.FieldName = "giabanle";
            this.colgiabanle.Name = "colgiabanle";
            this.colgiabanle.Visible = true;
            this.colgiabanle.VisibleIndex = 6;
            // 
            // coldonvitinh
            // 
            this.coldonvitinh.AppearanceCell.Options.UseTextOptions = true;
            this.coldonvitinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldonvitinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coldonvitinh.AppearanceHeader.Options.UseFont = true;
            this.coldonvitinh.AppearanceHeader.Options.UseTextOptions = true;
            this.coldonvitinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldonvitinh.Caption = "Đơn vị tính";
            this.coldonvitinh.DisplayFormat.FormatString = "#,###,###,##0";
            this.coldonvitinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldonvitinh.FieldName = "donvitinh";
            this.coldonvitinh.Name = "coldonvitinh";
            this.coldonvitinh.Visible = true;
            this.coldonvitinh.VisibleIndex = 3;
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colid.AppearanceHeader.Options.UseFont = true;
            this.colid.AppearanceHeader.Options.UseTextOptions = true;
            this.colid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.Caption = "Id";
            this.colid.DisplayFormat.FormatString = "#,###,###,##0";
            this.colid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colgiabansi
            // 
            this.colgiabansi.AppearanceCell.Options.UseTextOptions = true;
            this.colgiabansi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgiabansi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colgiabansi.AppearanceHeader.Options.UseFont = true;
            this.colgiabansi.AppearanceHeader.Options.UseTextOptions = true;
            this.colgiabansi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgiabansi.Caption = "Giá bán sỉ";
            this.colgiabansi.DisplayFormat.FormatString = "#,###,###,##0";
            this.colgiabansi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgiabansi.FieldName = "giabansi";
            this.colgiabansi.Name = "colgiabansi";
            this.colgiabansi.Visible = true;
            this.colgiabansi.VisibleIndex = 5;
            // 
            // tbMahang
            // 
            this.tbMahang.EditValue = "";
            this.tbMahang.Enabled = false;
            this.tbMahang.Location = new System.Drawing.Point(87, 32);
            this.tbMahang.Name = "tbMahang";
            this.tbMahang.Size = new System.Drawing.Size(153, 20);
            this.tbMahang.TabIndex = 24;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Mã hàng";
            // 
            // setGiaban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.sidePanel1);
            this.Name = "setGiaban";
            this.Text = "setGiaban";
            this.Load += new System.EventHandler(this.setGiaban_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiabansi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiabanle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGianhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMahang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbGiabansi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbGiabanle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbSp;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbGianhap;
        private DevExpress.XtraGrid.GridControl gv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmahang;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhang;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colgiabanle;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colgianhap;
        private DevExpress.XtraGrid.Columns.GridColumn colgiabansi;
        private DevExpress.XtraEditors.TextEdit tbMahang;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}