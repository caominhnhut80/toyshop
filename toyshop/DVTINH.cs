using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toyshop
{
    public partial class DVTINH : Form
    {
        public frmMain fm = new frmMain();
        public DVTINH()
        {
            InitializeComponent();
        }

        private void btthemdvt_Click_1(object sender, EventArgs e)
        {
            donvitinh dv = new donvitinh();

            //truyen tham so vao
            //dv.ID = int.Parse(txtid.Text);
            dv.DONVITINH = txtdvt.Text;




            //goi ham xu ly
            dv.ThemMoidvt();
            //TL.ThemMoi();
            MessageBox.Show(" Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_database();
        }

        private void btsuadvt_Click_1(object sender, EventArgs e)
        {
            donvitinh dv = new donvitinh();

            //truyen tham so vao
            dv.ID = int.Parse(txtid.Text);
            dv.DONVITINH = txtdvt.Text;


            //goi ham xu ly
            dv.SuaDVT();
            //TL.ThemMoi();
            MessageBox.Show(" Đã sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_database();
        }

        private void btxoadvt_Click_1(object sender, EventArgs e)
        {
            donvitinh dv = new donvitinh();
            // lkh.IDLOAI = int.Parse(txtid.Text);
            dv.ID = int.Parse(txtid.Text);
            // lkh.Xoa();
            MessageBox.Show(" Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  load();
            dv.XoaDVT();
            load_database();

        }
        public void load_database()
        {
            donvitinh dv = new donvitinh();
            luoidvtngoai.DataSource = dv.LayDanhSach();
        }

        private void gridload(object sender, EventArgs e)
        {
            load_database();
        }



        private void Load_DuLieu_tuluoilentext()
        {
            txtid.Text = luoiDVT.GetFocusedRowCellValue(id).ToString();
            txtdvt.Text = luoiDVT.GetFocusedRowCellValue(donvitinh).ToString();
            
        }

        private void luoidvtngoai_Click(object sender, EventArgs e)
        {
            Load_DuLieu_tuluoilentext();
        }

        private void DVTINH_Load(object sender, EventArgs e)
        {

        }

       
    }
}
