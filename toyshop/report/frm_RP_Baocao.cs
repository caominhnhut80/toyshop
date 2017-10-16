using DevExpress.LookAndFeel;
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
using toyshop.Data;
using toyshop.report.nhap;

namespace toyshop.report
{
    public partial class frm_RP_Baocao : Form
    {
        public frmMain fm = new frmMain();
        phieunhap pn = new phieunhap();
        public frm_RP_Baocao()
        {
            InitializeComponent();
            gridControl1.DataSource = pn.get_report_all_pn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rp_bc_all_phieunhap rpn = new rp_bc_all_phieunhap();
            rpn.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            lbphieu.Text = gridView1.GetFocusedRowCellValue("phieu").ToString();
            lbtong.Text = gridView1.GetFocusedRowCellValue("tong").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            pn.phieu = int.Parse(lbphieu.Text);
            ds = pn.get_report_ct_pn();
            rp_chitiet_pn rep = new rp_chitiet_pn();
            rep.DataSource = ds;
            rep.xrTableCell14.DataBindings.Add("Text", ds.Tables[0], "mahang");
            rep.xrTableCell15.DataBindings.Add("Text", ds.Tables[0], "soluong");
            rep.xrTableCell16.DataBindings.Add("Text", ds.Tables[0], "gianhap");
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
    public class tam
    {
       public long tong;
    }
        
    }

