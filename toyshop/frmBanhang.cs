using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
using toyshop.Data;

namespace toyshop
{
    public partial class frmBanhang : DevExpress.XtraEditors.XtraForm
    {
        public frmMain fm = new frmMain();
        public nhanvien emp = new nhanvien();
        phieuban pb = new phieuban();
        sanpham sp = new sanpham();
        DataTable dt;
        bool clickGrid = false;
        public frmBanhang()
        {
            InitializeComponent();
        }
        private void load_grid()
        {
            gv1.DataSource = pb.getphieubantam();

            tbmahang.DataSource = sp.LayDanhSach_deban();
            tbmahang.DisplayMember = "tenhang";
            tbmahang.ValueMember = "mahang";



        }
        private void load_combobox()
        {
           
           dt = new DataTable();
            // hiện giá bán, số lượng tồn kho, đơn vị tính theo sản phẩm
            //MessageBox.Show(tbmahang.SelectedValue.ToString());
            dt = pb.hien_gb_sl_dvt(tbmahang.SelectedValue.ToString());
            tbKho.Text = dt.Rows[0][3].ToString();
            lbDVT.Text = dt.Rows[0][4].ToString();
            if (!clickGrid)
            {
                if (rbLe.Checked)
                {
                    tbGiaban.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    tbGiaban.Text = dt.Rows[0][1].ToString();
                }
            }
            
        }
            private void frmBanhang_Load(object sender, EventArgs e)
        {
            load_grid();
            load_combobox();
        }

      

        private void tbmahang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load_combobox();
        }

        private void tbSL_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbSL.Text) > int.Parse(tbKho.Text))
                {
                    XtraMessageBox.Show("Số lượng Hàng trong kho không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    tbSL.SelectAll();
                    tbSL.Focus();
                    return;
                }
                tbThanhtien.Text = (long.Parse(tbGiaban.Text) * int.Parse(tbSL.Text)).ToString();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void tbGiaban_EditValueChanged(object sender, EventArgs e)
        {
            tbThanhtien.Text = (long.Parse(tbGiaban.Text) * int.Parse(tbSL.Text)).ToString();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbSL.Text) > int.Parse(tbKho.Text))
            {
                XtraMessageBox.Show("Số lượng Hàng trong kho không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSL.SelectAll();
                tbSL.Focus();
                return;
            }
            pb.thanhtien = long.Parse(tbThanhtien.Text);
            if (pb.thanhtien == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pb.mahang = tbmahang.SelectedValue.ToString();
            pb.soluong =int.Parse( tbSL.Text);
            pb.giaban = long.Parse(tbGiaban.Text);
           
            if (pb.addHang() == -1)
            {

                XtraMessageBox.Show("Sản phẩm đã nhập trong phiếu tạm", "Thêm mới thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            load_grid();
            load_combobox();
            tbSL.Text = "1";
            
           

        }

        private void rbLe_CheckedChanged(object sender, EventArgs e)
        {
            if (!clickGrid)
            {
                if (rbLe.Checked)
                {
                    tbGiaban.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    tbGiaban.Text = dt.Rows[0][1].ToString();
                }
            }
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (!clickGrid)
            {
                if (rbLe.Checked)
                {
                    tbGiaban.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    tbGiaban.Text = dt.Rows[0][1].ToString();
                }
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            clickGrid = true;
            tbmahang.SelectedValue= gridView1.GetFocusedRowCellValue("mahang").ToString();
          
            tbGiaban.Text = gridView1.GetFocusedRowCellValue("giaban").ToString();
            pb.mahang = gridView1.GetFocusedRowCellValue("mahang").ToString();
            pb.giaban = long.Parse(gridView1.GetFocusedRowCellValue("giaban").ToString());
            //XtraMessageBox.Show(edit_sp.EditValue.ToString());
            tbSL.Text = gridView1.GetFocusedRowCellValue("soluong").ToString();

           
            tbThanhtien.Text = gridView1.GetFocusedRowCellValue("thanhtien").ToString();
            // xử lý checkbox
            
            
            if (pb.checkGiaSiLe() == 0) //giá bán lẻ
            {
                rbLe.Checked = true;
            }
            else rbSi.Checked = true;
            clickGrid = false;
        }

        private void tbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickGrid)
            {
                load_combobox();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbSL.Text) > int.Parse(tbKho.Text))
            {
                XtraMessageBox.Show("Số lượng Hàng trong kho không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSL.SelectAll();
                tbSL.Focus();
                return;
            }
            pb.thanhtien = long.Parse(tbThanhtien.Text);
            if (pb.thanhtien == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pb.mahang = tbmahang.SelectedValue.ToString();
            pb.soluong = int.Parse(tbSL.Text);
            pb.giaban = long.Parse(tbGiaban.Text);

            pb.capnhatHang();
            XtraMessageBox.Show("Cập nhật sản phẩm thành công", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_grid();
            load_combobox();
            tbSL.Text = "1";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                pb.thanhtien = long.Parse(tbThanhtien.Text);
                pb.mahang = tbmahang.SelectedValue.ToString();
                if (pb.thanhtien == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn sản phẩm ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pb.xoaHang();
                load_grid();
                load_combobox();
                tbSL.Text = "1";
            }
        }

        private void btnChottoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn chốt toa hàng này và tính tiền?", "Xác nhận chốt toa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pb.chotToa(emp.id);
                XtraMessageBox.Show("Chốt toa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_grid();
            }
            }
        }
}