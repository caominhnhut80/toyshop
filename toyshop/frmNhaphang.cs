using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toyshop.Data;

namespace toyshop
{
    public partial class frmNhaphang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain fm = new frmMain();
        public nhanvien emp=new nhanvien();
        phieunhap pn = new phieunhap();
        sanpham sp = new sanpham();
        MemoryStream ms;
        byte[] hinh;
        public frmNhaphang()
        {
            InitializeComponent();
          

        }
        private void load_grid()
        {
            gv1.DataSource = pn.getphieunhaptam();
            tbmahang.DataSource = sp.LayDanhSach();
            tbmahang.DisplayMember = "tenhang";
            tbmahang.ValueMember = "mahang";

            edit_sp.DataSource = sp.LayDanhSach();
            edit_sp.DisplayMember = "tenhang";
            edit_sp.ValueMember = "mahang";
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gv1.ShowRibbonPrintPreview();
        }
      
        private void nhaphang_Load(object sender, EventArgs e)
        {
            load_grid();
            // TODO: This line of code loads data into the 'toyshopDataset.sanpham' table. You can move, or remove it, as needed.
            sp.mahang = tbmahang.SelectedValue.ToString();
             hinh= sp.getHinh();
            if (hinh != null)
            {
                ms = new MemoryStream(hinh);
                pictureBox1.Image = Image.FromStream(ms);
            }


        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            pn.thanhtien = long.Parse(tbThanhtien.Text);
            if (pn.thanhtien == 0 ) {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng và giá nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            pn.mahang = tbmahang.SelectedValue.ToString();
            pn.soluong = int.Parse( tbSL.Text);
            pn.gianhap = long.Parse( tbGianhap.Text);

            if (pn.addHang(pn) == -1) {

                XtraMessageBox.Show("Sản phẩm đã nhập trong phiếu tạm","Thêm mới thất bại",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            load_grid();
            tbSL.Text = "0";
            tbGianhap.Text = "0";
        }

        private void tbSL_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbThanhtien.Text = (int.Parse(tbSL.Text) * long.Parse(tbGianhap.Text)).ToString();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void tbGianhap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbThanhtien.Text = (int.Parse(tbSL.Text) * long.Parse(tbGianhap.Text)).ToString();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void tbSL_Click(object sender, EventArgs e)
        {
            (sender as TextEdit).SelectAll();
        }

        private void tbGianhap_Click(object sender, EventArgs e)
        {
            (sender as TextEdit).SelectAll();
        }

        private void gridView_Click(object sender, EventArgs e)
        {
            edit_sp.Text= gridView.GetFocusedRowCellValue("tenhang").ToString();
            //XtraMessageBox.Show(edit_sp.EditValue.ToString());
            edit_sl.Text = gridView.GetFocusedRowCellValue("soluong").ToString();
            edit_gn.Text = gridView.GetFocusedRowCellValue("gianhap").ToString();
            edit_tt.Text = gridView.GetFocusedRowCellValue("thanhtien").ToString();
        }

        private void edit_sl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                edit_tt.Text = (int.Parse(edit_sl.Text) * long.Parse(edit_gn.Text)).ToString();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void edit_gn_EditValueChanged(object sender, EventArgs e)
        {
            edit_tt.Text = (int.Parse(edit_sl.Text) * long.Parse(edit_gn.Text)).ToString();
        }

        private void edit_sl_Click(object sender, EventArgs e)
        {
            (sender as TextEdit).SelectAll();
        }

        private void edit_gn_Click(object sender, EventArgs e)
        {
            (sender as TextEdit).SelectAll();
        }

        private void btnEditsave_Click(object sender, EventArgs e)
        {
            pn.thanhtien = long.Parse(edit_tt.Text);
            if (pn.thanhtien == 0 )
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng và giá nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pn.mahang = edit_sp.SelectedValue.ToString();
            pn.soluong = int.Parse(edit_sl.Text);
            pn.gianhap = long.Parse(edit_gn.Text);
           
            pn.capnhatHang(pn);
            load_grid();
            edit_sl.Text = "0";
            edit_gn.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            pn.thanhtien = long.Parse(edit_tt.Text);
            pn.mahang= edit_sp.SelectedValue.ToString();
            if (pn.thanhtien == 0 )
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng và giá nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pn.xoaHang(pn.mahang);
            load_grid();
            edit_sl.Text = "0";
            edit_gn.Text = "0";
            
        }

        private void btnChottoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn chốt toa nhập không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
               
                pn.chotToa(emp.id);
                XtraMessageBox.Show("Chốt toa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_grid();
            }
            
        }

        private void tbmahang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp.mahang = tbmahang.SelectedValue.ToString();
             hinh = sp.getHinh();
            if (hinh != null)
            {
                ms = new MemoryStream(hinh);
                pictureBox1.Image = Image.FromStream(ms);
            }


        }
    }
}