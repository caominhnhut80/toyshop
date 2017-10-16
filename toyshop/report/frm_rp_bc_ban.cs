using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toyshop.report.xuat;

namespace toyshop.report
{
    public partial class frm_rp_bc_ban : Form
    {
        public frmMain fm = new frmMain();
        toyshop.Data.Phieuban pb = new toyshop.Data.Phieuban();
        public frm_rp_bc_ban()
        {
            InitializeComponent();
            gridControl1.DataSource = pb.get_report_all_pb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rp_banhangall rpn = new rp_banhangall();
            rpn.ShowPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            lbphieu.Text = gridView1.GetFocusedRowCellValue("phieu").ToString();
            lbtong.Text = gridView1.GetFocusedRowCellValue("tong").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            pb.Phieu = int.Parse(lbphieu.Text);
            ds = pb.get_report_ct_pb();
            rp_chitiet_pb rep = new rp_chitiet_pb();
            rep.DataSource = ds;
            rep.xrTableCell14.DataBindings.Add("Text", ds.Tables[0], "mahang");
            rep.xrTableCell15.DataBindings.Add("Text", ds.Tables[0], "soluong");
            rep.xrTableCell16.DataBindings.Add("Text", ds.Tables[0], "giaban");
            rep.xrTableCell17.DataBindings.Add("Text", ds.Tables[0], "thanhtien");
            rep.xrTableCell18.DataBindings.Add("Text", ds.Tables[0], "phieu");
            rep.xrTableCell19.DataBindings.Add("Text", ds.Tables[0], "ngaylapphieu");
            rep.xrTableCell20.DataBindings.Add("Text", ds.Tables[0], "hoten");
            tam t = new tam();
            t.tong = long.Parse(lbtong.Text);
            List<tam> mang = new List<tam>();
            mang.Add(t);

            rep.xrLabel3.DataBindings.Add("Text", mang, "tong");


            rep.ShowPreview();
            //using (ReportPrintTool printTool = new ReportPrintTool(rp))
            //{
            //    // Invoke the Ribbon Print Preview form modally, 
            //    // and load the report document into it.
            //    printTool.ShowRibbonPreviewDialog();

            //    // Invoke the Ribbon Print Preview form
            //    // with the specified look and feel setting.
            //    printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
            //}

            //ReportDesignTool rdt = new ReportDesignTool(rp);
            //rdt.ShowDesignerDialog();
        }

    
    }
   

}


