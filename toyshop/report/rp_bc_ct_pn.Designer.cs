namespace toyshop.report
{
    partial class rp_bc_ct_pn
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
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.documentViewer2 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(801, 403);
            this.documentViewer1.TabIndex = 0;
            // 
            // documentViewer2
            // 
            this.documentViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer2.DocumentSource = typeof(toyshop.report.nhap.rp_chitiet_pn);
            this.documentViewer2.IsMetric = false;
            this.documentViewer2.Location = new System.Drawing.Point(0, 0);
            this.documentViewer2.Name = "documentViewer2";
            this.documentViewer2.Size = new System.Drawing.Size(801, 403);
            this.documentViewer2.TabIndex = 1;
            // 
            // rp_bc_ct_pn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 403);
            this.Controls.Add(this.documentViewer2);
            this.Controls.Add(this.documentViewer1);
            this.Name = "rp_bc_ct_pn";
            this.Text = "rp_bc_ct_pn";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer2;
    }
}