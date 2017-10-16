using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using toyshop.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Threading;
using toyshop.report;

namespace toyshop
{
   
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public nhanvien nv = new nhanvien();
       
        public frmMain()
        {
           
            InitializeComponent();
            
            ribbon.Minimized=true;
          //  nv.id = 1; 
            nv.username = "A";
            nv.hoten = "B";
        }
      

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (nv.id == -1)
            {
                login_form lgf = new login_form();
                lgf.fm = this;
                lgf.ShowDialog();
                lbUser.Caption = "Người dùng: " + nv.username + " - " + nv.hoten;
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nv.id != -1)
            {
                DVTINH dvt  = new DVTINH();
                dvt.fm = this;
                dvt.ShowDialog();
                
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nv.id != -1)
            {
                frmSanpham fsp = new frmSanpham();
                fsp.fm = this;
                fsp.ShowDialog();

            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nv.quyen==0||nv.quyen==1)
            {
                frmNhanvien fsp = new frmNhanvien();
                fsp.fm = this;
                fsp.ShowDialog();

            } else
            {
                XtraMessageBox.Show("Bạn chưa được phân quyền vào tính năng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nv.quyen == 0 || nv.quyen == 1)
            {
                frmNhaphang fsp = new frmNhaphang();
                fsp.fm = this;
                fsp.emp = nv;
                fsp.ShowDialog();

            }
            else
            {
                XtraMessageBox.Show("Bạn chưa được phân quyền vào tính năng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nv.quyen == 0 || nv.quyen == 1)
            {
                frmsetGiaban fsp = new frmsetGiaban();
                fsp.fm = this;
                fsp.ShowDialog();

            }
            else
            {
                XtraMessageBox.Show("Bạn chưa được phân quyền vào tính năng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanhang fbh = new frmBanhang();
            fbh.fm = this;
            fbh.emp = nv;
            fbh.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_RP_Baocao fbh = new frm_RP_Baocao();
            fbh.fm = this;
            fbh.Show();
        }
    }
}