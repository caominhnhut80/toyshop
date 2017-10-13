namespace toyshop
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.IDNV = new System.Windows.Forms.Label();
            this.USERNAME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDNV = new System.Windows.Forms.TextBox();
            this.textBoxUSN = new System.Windows.Forms.TextBox();
            this.textBoxHT = new System.Windows.Forms.TextBox();
            this.LUOINHANVIEN = new DevExpress.XtraGrid.GridControl();
            this.GRIDNHANVIEN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tendn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonTHEM = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSUA = new DevExpress.XtraEditors.SimpleButton();
            this.buttonXOA = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxQuyen1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LUOINHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDNHANVIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNV
            // 
            this.IDNV.AutoSize = true;
            this.IDNV.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNV.Location = new System.Drawing.Point(2, 212);
            this.IDNV.Name = "IDNV";
            this.IDNV.Size = new System.Drawing.Size(83, 13);
            this.IDNV.TabIndex = 0;
            this.IDNV.Text = "ID NHÂN VIÊN";
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(2, 239);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(68, 13);
            this.USERNAME.TabIndex = 1;
            this.USERNAME.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỌ TÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUYỀN";
            // 
            // textBoxIDNV
            // 
            this.textBoxIDNV.Enabled = false;
            this.textBoxIDNV.Location = new System.Drawing.Point(91, 205);
            this.textBoxIDNV.Name = "textBoxIDNV";
            this.textBoxIDNV.ReadOnly = true;
            this.textBoxIDNV.Size = new System.Drawing.Size(188, 20);
            this.textBoxIDNV.TabIndex = 4;
            // 
            // textBoxUSN
            // 
            this.textBoxUSN.Location = new System.Drawing.Point(91, 236);
            this.textBoxUSN.Name = "textBoxUSN";
            this.textBoxUSN.Size = new System.Drawing.Size(188, 20);
            this.textBoxUSN.TabIndex = 5;
            // 
            // textBoxHT
            // 
            this.textBoxHT.Location = new System.Drawing.Point(360, 205);
            this.textBoxHT.Name = "textBoxHT";
            this.textBoxHT.Size = new System.Drawing.Size(188, 20);
            this.textBoxHT.TabIndex = 6;
            // 
            // LUOINHANVIEN
            // 
            this.LUOINHANVIEN.Location = new System.Drawing.Point(-2, -2);
            this.LUOINHANVIEN.MainView = this.GRIDNHANVIEN;
            this.LUOINHANVIEN.Name = "LUOINHANVIEN";
            this.LUOINHANVIEN.Size = new System.Drawing.Size(904, 179);
            this.LUOINHANVIEN.TabIndex = 11;
            this.LUOINHANVIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRIDNHANVIEN});
            this.LUOINHANVIEN.Click += new System.EventHandler(this.LUOINHANVIEN_Click);
            // 
            // GRIDNHANVIEN
            // 
            this.GRIDNHANVIEN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.tendn,
            this.HOTEN,
            this.QUYEN,
            this.colPassword});
            this.GRIDNHANVIEN.GridControl = this.LUOINHANVIEN;
            this.GRIDNHANVIEN.Name = "GRIDNHANVIEN";
            this.GRIDNHANVIEN.OptionsView.ShowGroupPanel = false;
            this.GRIDNHANVIEN.Click += new System.EventHandler(this.GRIDNHANVIEN_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // tendn
            // 
            this.tendn.Caption = "USERNAME";
            this.tendn.FieldName = "username";
            this.tendn.Name = "tendn";
            this.tendn.OptionsColumn.AllowEdit = false;
            this.tendn.OptionsColumn.AllowFocus = false;
            this.tendn.Visible = true;
            this.tendn.VisibleIndex = 1;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "hoten";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.AllowEdit = false;
            this.HOTEN.OptionsColumn.AllowFocus = false;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 2;
            // 
            // QUYEN
            // 
            this.QUYEN.Caption = "QUYỀN";
            this.QUYEN.FieldName = "quyen";
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.OptionsColumn.AllowEdit = false;
            this.QUYEN.OptionsColumn.AllowFocus = false;
            this.QUYEN.Visible = true;
            this.QUYEN.VisibleIndex = 3;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "PASSWORD";
            this.colPassword.FieldName = "password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 4;
            // 
            // buttonTHEM
            // 
            this.buttonTHEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonTHEM.ImageOptions.Image")));
            this.buttonTHEM.Location = new System.Drawing.Point(299, 262);
            this.buttonTHEM.Name = "buttonTHEM";
            this.buttonTHEM.Size = new System.Drawing.Size(83, 40);
            this.buttonTHEM.TabIndex = 12;
            this.buttonTHEM.Text = "THÊM";
            this.buttonTHEM.Click += new System.EventHandler(this.buttonTHEM_Click);
            // 
            // buttonSUA
            // 
            this.buttonSUA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSUA.ImageOptions.Image")));
            this.buttonSUA.Location = new System.Drawing.Point(477, 262);
            this.buttonSUA.Name = "buttonSUA";
            this.buttonSUA.Size = new System.Drawing.Size(83, 40);
            this.buttonSUA.TabIndex = 13;
            this.buttonSUA.Text = "SỬA";
            this.buttonSUA.Click += new System.EventHandler(this.buttonSUA_Click);
            // 
            // buttonXOA
            // 
            this.buttonXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonXOA.ImageOptions.Image")));
            this.buttonXOA.Location = new System.Drawing.Point(388, 262);
            this.buttonXOA.Name = "buttonXOA";
            this.buttonXOA.Size = new System.Drawing.Size(83, 40);
            this.buttonXOA.TabIndex = 14;
            this.buttonXOA.Text = "XÓA";
            this.buttonXOA.Click += new System.EventHandler(this.buttonXOA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ \r\nNHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(92, 262);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(188, 20);
            this.tbPass.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "PASSWORD";
            // 
            // comboBoxQuyen1
            // 
            this.comboBoxQuyen1.FormattingEnabled = true;
            this.comboBoxQuyen1.Location = new System.Drawing.Point(360, 231);
            this.comboBoxQuyen1.Name = "comboBoxQuyen1";
            this.comboBoxQuyen1.Size = new System.Drawing.Size(188, 21);
            this.comboBoxQuyen1.TabIndex = 20;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(903, 306);
            this.Controls.Add(this.comboBoxQuyen1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonXOA);
            this.Controls.Add(this.buttonSUA);
            this.Controls.Add(this.buttonTHEM);
            this.Controls.Add(this.LUOINHANVIEN);
            this.Controls.Add(this.textBoxHT);
            this.Controls.Add(this.textBoxUSN);
            this.Controls.Add(this.textBoxIDNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.IDNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(919, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(919, 345);
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUOINHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDNHANVIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDNV;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDNV;
        private System.Windows.Forms.TextBox textBoxUSN;
        private System.Windows.Forms.TextBox textBoxHT;
        private DevExpress.XtraGrid.GridControl LUOINHANVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView GRIDNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn tendn;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn QUYEN;
        private DevExpress.XtraEditors.SimpleButton buttonTHEM;
        private DevExpress.XtraEditors.SimpleButton buttonSUA;
        private DevExpress.XtraEditors.SimpleButton buttonXOA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private System.Windows.Forms.ComboBox comboBoxQuyen1;
    }
}


