namespace toyshop
{
    partial class frmNhaphang
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv1 = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgianhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnChottoa = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnEditsave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.edit_tt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.edit_gn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.edit_sl = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbThanhtien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbGianhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbSL = new DevExpress.XtraEditors.TextEdit();
            this.tbmahang = new System.Windows.Forms.ComboBox();
            this.edit_sp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_tt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_gn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_sl.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThanhtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGianhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gv1
            // 
            this.gv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv1.Location = new System.Drawing.Point(0, 374);
            this.gv1.MainView = this.gridView;
            this.gv1.MenuManager = this.ribbonControl;
            this.gv1.Name = "gv1";
            this.gv1.Size = new System.Drawing.Size(867, 221);
            this.gv1.TabIndex = 2;
            this.gv1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmahang,
            this.coltenhang,
            this.colsoluong,
            this.colgianhap,
            this.colthanhtien,
            this.coldonvitinh,
            this.colID});
            this.gridView.GridControl = this.gv1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.Click += new System.EventHandler(this.gridView_Click);
            // 
            // colmahang
            // 
            this.colmahang.AppearanceCell.Options.UseTextOptions = true;
            this.colmahang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmahang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colmahang.AppearanceHeader.Options.UseFont = true;
            this.colmahang.AppearanceHeader.Options.UseTextOptions = true;
            this.colmahang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmahang.Caption = "Mã sản phẩm";
            this.colmahang.DisplayFormat.FormatString = "#,###,###,##0";
            this.colmahang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmahang.FieldName = "mahang";
            this.colmahang.Name = "colmahang";
            this.colmahang.OptionsColumn.AllowEdit = false;
            this.colmahang.OptionsColumn.AllowFocus = false;
            this.colmahang.Visible = true;
            this.colmahang.VisibleIndex = 0;
            // 
            // coltenhang
            // 
            this.coltenhang.AppearanceCell.Options.UseTextOptions = true;
            this.coltenhang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenhang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.coltenhang.AppearanceHeader.Options.UseFont = true;
            this.coltenhang.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenhang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenhang.Caption = "Tên sản phẩm";
            this.coltenhang.DisplayFormat.FormatString = "#,###,###,##0";
            this.coltenhang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltenhang.FieldName = "tenhang";
            this.coltenhang.Name = "coltenhang";
            this.coltenhang.OptionsColumn.AllowEdit = false;
            this.coltenhang.OptionsColumn.AllowFocus = false;
            this.coltenhang.Visible = true;
            this.coltenhang.VisibleIndex = 1;
            // 
            // colsoluong
            // 
            this.colsoluong.AppearanceCell.Options.UseTextOptions = true;
            this.colsoluong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colsoluong.AppearanceHeader.Options.UseFont = true;
            this.colsoluong.AppearanceHeader.Options.UseTextOptions = true;
            this.colsoluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.Caption = "Số lượng";
            this.colsoluong.DisplayFormat.FormatString = "#,###,###,##0";
            this.colsoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.OptionsColumn.AllowEdit = false;
            this.colsoluong.OptionsColumn.AllowFocus = false;
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 3;
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
            this.colgianhap.OptionsColumn.AllowEdit = false;
            this.colgianhap.OptionsColumn.AllowFocus = false;
            this.colgianhap.Visible = true;
            this.colgianhap.VisibleIndex = 4;
            // 
            // colthanhtien
            // 
            this.colthanhtien.AppearanceCell.Options.UseTextOptions = true;
            this.colthanhtien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthanhtien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colthanhtien.AppearanceHeader.Options.UseFont = true;
            this.colthanhtien.AppearanceHeader.Options.UseTextOptions = true;
            this.colthanhtien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthanhtien.Caption = "Thành tiền";
            this.colthanhtien.DisplayFormat.FormatString = "#,###,###,##0";
            this.colthanhtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colthanhtien.FieldName = "thanhtien";
            this.colthanhtien.Name = "colthanhtien";
            this.colthanhtien.Visible = true;
            this.colthanhtien.VisibleIndex = 5;
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
            this.coldonvitinh.OptionsColumn.AllowEdit = false;
            this.coldonvitinh.OptionsColumn.AllowFocus = false;
            this.coldonvitinh.Visible = true;
            this.coldonvitinh.VisibleIndex = 2;
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Loại phiếu";
            this.colID.DisplayFormat.FormatString = "#,###,###,##0";
            this.colID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colID.FieldName = "phieu";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 6;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(867, 143);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            this.ribbonPage1.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnChottoa);
            this.panelControl1.Controls.Add(this.sidePanel2);
            this.panelControl1.Controls.Add(this.sidePanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(867, 208);
            this.panelControl1.TabIndex = 4;
            // 
            // btnChottoa
            // 
            this.btnChottoa.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnChottoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChottoa.Appearance.Options.UseFont = true;
            this.btnChottoa.Appearance.Options.UseForeColor = true;
            this.btnChottoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnChottoa.Location = new System.Drawing.Point(346, 55);
            this.btnChottoa.Name = "btnChottoa";
            this.btnChottoa.Size = new System.Drawing.Size(204, 80);
            this.btnChottoa.TabIndex = 23;
            this.btnChottoa.Text = "CHỐT TOA NHẬP";
            this.btnChottoa.Click += new System.EventHandler(this.btnChottoa_Click);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.edit_sp);
            this.sidePanel2.Controls.Add(this.btnXoa);
            this.sidePanel2.Controls.Add(this.labelControl6);
            this.sidePanel2.Controls.Add(this.btnEditsave);
            this.sidePanel2.Controls.Add(this.labelControl7);
            this.sidePanel2.Controls.Add(this.edit_tt);
            this.sidePanel2.Controls.Add(this.labelControl8);
            this.sidePanel2.Controls.Add(this.edit_gn);
            this.sidePanel2.Controls.Add(this.labelControl9);
            this.sidePanel2.Controls.Add(this.labelControl10);
            this.sidePanel2.Controls.Add(this.edit_sl);
            this.sidePanel2.Location = new System.Drawing.Point(653, 1);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(214, 203);
            this.sidePanel2.TabIndex = 13;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Location = new System.Drawing.Point(127, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(58, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "ĐIỀU CHỈNH";
            // 
            // btnEditsave
            // 
            this.btnEditsave.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnEditsave.Appearance.Options.UseForeColor = true;
            this.btnEditsave.Location = new System.Drawing.Point(16, 177);
            this.btnEditsave.Name = "btnEditsave";
            this.btnEditsave.Size = new System.Drawing.Size(75, 23);
            this.btnEditsave.TabIndex = 19;
            this.btnEditsave.Text = "Cập nhật";
            this.btnEditsave.Click += new System.EventHandler(this.btnEditsave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 139);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Thành tiền";
            // 
            // edit_tt
            // 
            this.edit_tt.EditValue = "0";
            this.edit_tt.Enabled = false;
            this.edit_tt.Location = new System.Drawing.Point(81, 136);
            this.edit_tt.MenuManager = this.ribbonControl;
            this.edit_tt.Name = "edit_tt";
            this.edit_tt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edit_tt.Size = new System.Drawing.Size(100, 20);
            this.edit_tt.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 104);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Giá nhập vào";
            // 
            // edit_gn
            // 
            this.edit_gn.EditValue = "0";
            this.edit_gn.Location = new System.Drawing.Point(81, 101);
            this.edit_gn.MenuManager = this.ribbonControl;
            this.edit_gn.Name = "edit_gn";
            this.edit_gn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edit_gn.Size = new System.Drawing.Size(100, 20);
            this.edit_gn.TabIndex = 15;
            this.edit_gn.EditValueChanged += new System.EventHandler(this.edit_gn_EditValueChanged);
            this.edit_gn.Click += new System.EventHandler(this.edit_gn_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(7, 68);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Số lượng";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(7, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Sản phẩm";
            // 
            // edit_sl
            // 
            this.edit_sl.EditValue = "1";
            this.edit_sl.Location = new System.Drawing.Point(81, 65);
            this.edit_sl.MenuManager = this.ribbonControl;
            this.edit_sl.Name = "edit_sl";
            this.edit_sl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edit_sl.Size = new System.Drawing.Size(100, 20);
            this.edit_sl.TabIndex = 12;
            this.edit_sl.EditValueChanged += new System.EventHandler(this.edit_sl_EditValueChanged);
            this.edit_sl.Click += new System.EventHandler(this.edit_sl_Click);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tbmahang);
            this.sidePanel1.Controls.Add(this.labelControl5);
            this.sidePanel1.Controls.Add(this.btLuu);
            this.sidePanel1.Controls.Add(this.labelControl4);
            this.sidePanel1.Controls.Add(this.tbThanhtien);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.tbGianhap);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.tbSL);
            this.sidePanel1.Location = new System.Drawing.Point(5, 5);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(214, 203);
            this.sidePanel1.TabIndex = 12;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(58, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "TOA NHẬP HÀNG";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(81, 176);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 19;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Thành tiền";
            // 
            // tbThanhtien
            // 
            this.tbThanhtien.EditValue = "0";
            this.tbThanhtien.Enabled = false;
            this.tbThanhtien.Location = new System.Drawing.Point(81, 136);
            this.tbThanhtien.MenuManager = this.ribbonControl;
            this.tbThanhtien.Name = "tbThanhtien";
            this.tbThanhtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbThanhtien.Size = new System.Drawing.Size(100, 20);
            this.tbThanhtien.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Giá nhập vào";
            // 
            // tbGianhap
            // 
            this.tbGianhap.EditValue = "0";
            this.tbGianhap.Location = new System.Drawing.Point(81, 101);
            this.tbGianhap.MenuManager = this.ribbonControl;
            this.tbGianhap.Name = "tbGianhap";
            this.tbGianhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbGianhap.Size = new System.Drawing.Size(100, 20);
            this.tbGianhap.TabIndex = 15;
            this.tbGianhap.EditValueChanged += new System.EventHandler(this.tbGianhap_EditValueChanged);
            this.tbGianhap.Click += new System.EventHandler(this.tbGianhap_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Số lượng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Sản phẩm";
            // 
            // tbSL
            // 
            this.tbSL.EditValue = "1";
            this.tbSL.Location = new System.Drawing.Point(81, 65);
            this.tbSL.MenuManager = this.ribbonControl;
            this.tbSL.Name = "tbSL";
            this.tbSL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSL.Size = new System.Drawing.Size(100, 20);
            this.tbSL.TabIndex = 12;
            this.tbSL.EditValueChanged += new System.EventHandler(this.tbSL_EditValueChanged);
            this.tbSL.Click += new System.EventHandler(this.tbSL_Click);
            // 
            // tbmahang
            // 
            this.tbmahang.FormattingEnabled = true;
            this.tbmahang.Location = new System.Drawing.Point(81, 34);
            this.tbmahang.Name = "tbmahang";
            this.tbmahang.Size = new System.Drawing.Size(121, 21);
            this.tbmahang.TabIndex = 24;
            // 
            // edit_sp
            // 
            this.edit_sp.FormattingEnabled = true;
            this.edit_sp.Location = new System.Drawing.Point(81, 34);
            this.edit_sp.Name = "edit_sp";
            this.edit_sp.Size = new System.Drawing.Size(121, 21);
            this.edit_sp.TabIndex = 23;
            // 
            // frmNhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 595);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gv1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmNhaphang";
            this.Ribbon = this.ribbonControl;
            this.Text = "Nhập toa hàng";
            this.Load += new System.EventHandler(this.nhaphang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_tt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_gn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_sl.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThanhtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGianhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gv1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbThanhtien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbGianhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbSL;
        private DevExpress.XtraGrid.Columns.GridColumn colmahang;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhang;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colgianhap;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnEditsave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit edit_tt;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit edit_gn;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit edit_sl;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnChottoa;
        private DevExpress.XtraGrid.Columns.GridColumn colthanhtien;
        private System.Windows.Forms.ComboBox edit_sp;
        private System.Windows.Forms.ComboBox tbmahang;
    }
}