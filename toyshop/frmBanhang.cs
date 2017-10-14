using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using toyshop.Data;

namespace toyshop
{
    public partial class frmBanhang : DevExpress.XtraEditors.XtraForm
    {
        public frmMain fm = new frmMain();
        public nhanvien emp = new nhanvien();
        phieuban pb = new phieuban();
        sanpham sp = new sanpham();
        public frmBanhang()
        {
            InitializeComponent();
        }
        private void load_grid()
        {
            gv1.DataSource = pb.getphieubantam();

            tbmahang.DataSource = sp.LayDanhSach();
            tbmahang.DisplayMember = "tenhang";
            tbmahang.ValueMember = "mahang";
            // hiện giá bán, số lượng, đơn vị tính


        }
        private void frmBanhang_Load(object sender, EventArgs e)
        {
            load_grid();
        }
    }
}