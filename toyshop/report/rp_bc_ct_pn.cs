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
    public partial class rp_bc_ct_pn : Form
    {
        public int phieu;
        phieunhap pn=new phieunhap();
        public rp_bc_ct_pn()
        {
            InitializeComponent();
            rp_chitiet_pn rp = new rp_chitiet_pn();
            rp.phieu = phieu;
        }
       
    }
}
