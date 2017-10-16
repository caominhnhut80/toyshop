using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toyshop.Data;

namespace toyshop
{
    public partial class frmBanhang : DevExpress.XtraEditors.XtraForm
    {
        public frmMain fm = new frmMain();
        public nhanvien emp = new nhanvien();
        Phieuban pb = new Phieuban();
        sanpham sp = new sanpham();
        DataTable dt, dtEdit;
        bool blClick = false;
        MemoryStream ms;
        byte[] hinh;
        report.phieuban rpPhieuban;
        public frmBanhang()
        {
            InitializeComponent();
        }
        private void load_grid()
        {
            gv1.DataSource = pb.Getphieubantam();

            tbmahang.DataSource = sp.LayDanhSach_deban();
            tbmahang.DisplayMember = "tenhang";
            tbmahang.ValueMember = "mahang";

            edit_sp.DataSource = sp.LayDanhSach_deban();
            edit_sp.DisplayMember = "tenhang";
            edit_sp.ValueMember = "mahang";

        }
        private void load_combobox()
        {

            dt = new DataTable();
            // hiện giá bán, số lượng tồn kho, đơn vị tính theo sản phẩm
            //MessageBox.Show(tbmahang.SelectedValue.ToString());
            if (tbmahang.Items.Count == 0)
            {
                anhien(true);
                XtraMessageBox.Show("Đã hết mặt hàng để bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            dt = pb.hien_gb_sl_dvt(tbmahang.SelectedValue.ToString());
            tbKho.Text = dt.Rows[0][3].ToString();
            lbDVT.Text = dt.Rows[0][4].ToString();
            if (rbLe.Checked)
            {
                tbGiaban.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                tbGiaban.Text = dt.Rows[0][1].ToString();
            }


        }
        private void load_comboboxEdit()
        {

            dtEdit = new DataTable();
            // hiện giá bán, số lượng tồn kho, đơn vị tính theo sản phẩm
            //MessageBox.Show(tbmahang.SelectedValue.ToString());
            dtEdit = pb.hien_gb_sl_dvt(edit_sp.SelectedValue.ToString());
            edit_kho.Text = dtEdit.Rows[0][3].ToString();
            tbDVT_edit.Text = dtEdit.Rows[0][4].ToString();
            if (edit_le.Checked)
            {
                edit_giaban.Text = dtEdit.Rows[0][2].ToString();
            }
            else
            {
                edit_giaban.Text = dtEdit.Rows[0][1].ToString();
            }


        }
        void loadhinh(int loai)
        {
            if (loai==0)
            sp.mahang = tbmahang.SelectedValue.ToString();
            else sp.mahang = edit_sp.SelectedValue.ToString();
            hinh = sp.getHinh();
            if (hinh != null)
            {
                ms = new MemoryStream(hinh);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void frmBanhang_Load(object sender, EventArgs e)
        {
            anhien(false);
            load_grid();
            load_combobox();
            loadhinh(0);
        }



        private void tbmahang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load_combobox();
            loadhinh(0);
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
                XtraMessageBox.Show("Dữ liệu nhập sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSL.SelectAll();
                tbSL.Focus();
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
            pb.Thanhtien = long.Parse(tbThanhtien.Text);
            if (pb.Thanhtien == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pb.Mahang = tbmahang.SelectedValue.ToString();
            pb.Soluong = int.Parse(tbSL.Text);
            pb.Giaban = long.Parse(tbGiaban.Text);

            if (pb.AddHang() == -1)
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

            if (rbLe.Checked)
            {
                tbGiaban.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                tbGiaban.Text = dt.Rows[0][1].ToString();
            }

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
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

        private void gridView1_Click(object sender, EventArgs e)
        {
            anhien(true);
            blClick = true;
            edit_kho.Text = tbKho.Text;
            edit_sl.Text = gridView1.GetFocusedRowCellValue("soluong").ToString();
            edit_thanhtien.Text = gridView1.GetFocusedRowCellValue("thanhtien").ToString();
            edit_giaban.Text = gridView1.GetFocusedRowCellValue("giaban").ToString();
            edit_sp.SelectedValue = gridView1.GetFocusedRowCellValue("mahang").ToString();

            pb.Mahang = gridView1.GetFocusedRowCellValue("mahang").ToString();
            pb.Giaban = long.Parse(gridView1.GetFocusedRowCellValue("giaban").ToString());
            if (pb.checkGiaSiLe() == 0) //giá bán lẻ
            {
                edit_le.Checked = true;
            }
            else edit_si.Checked = true;

            // xử lý checkbox


            load_comboboxEdit();
            loadhinh(1);
            blClick = false;
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(edit_sl.Text) > int.Parse(edit_kho.Text))
            {
                XtraMessageBox.Show("Số lượng Hàng trong kho không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                edit_sl.SelectAll();
                edit_sl.Focus();
                return;
            }
            pb.Thanhtien = long.Parse(edit_thanhtien.Text);
            if (pb.Thanhtien == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm , số lượng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pb.Mahang = edit_sp.SelectedValue.ToString();
            pb.Soluong = int.Parse(edit_sl.Text);
            pb.Giaban = long.Parse(edit_giaban.Text);

            pb.capnhatHang();
            XtraMessageBox.Show("Cập nhật sản phẩm thành công", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_grid();
            load_combobox();
            load_comboboxEdit();
            edit_sl.Text = "1";
            anhien(false);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                pb.Thanhtien = long.Parse(edit_thanhtien.Text);
                pb.Mahang = edit_sp.SelectedValue.ToString();
                if (pb.Thanhtien == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn sản phẩm ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pb.xoaHang();
                load_grid();
                load_combobox();
                load_comboboxEdit();
                edit_sl.Text = "1";
            }
            anhien(false);
        }

        private void btnChottoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn chốt toa hàng này và tính tiền?", "Xác nhận chốt toa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pb.chotToa(emp.id);
                XtraMessageBox.Show("Chốt toa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_grid();
                load_combobox();


            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            rpPhieuban = new report.phieuban();

            using (ReportPrintTool printTool = new ReportPrintTool(rpPhieuban))
            {
                // Invoke the Ribbon Print Preview form modally, 
                // and load the report document into it.
                printTool.ShowRibbonPreviewDialog();

                // Invoke the Ribbon Print Preview form
                // with the specified look and feel setting.
                printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
            }
        }
        private void anhien(bool blEdit)
        {
            //if (tbmahang.Items.Count == 0&&!blEdit) return;
            pnEdit.Visible = blEdit;
            pnInsert.Visible = !blEdit;
            btnShow.Visible = blEdit;
        }

        private void edit_le_CheckedChanged(object sender, EventArgs e)
        {
            if (!blClick)
            {
                load_comboboxEdit();
                if (edit_le.Checked)
                {
                    edit_giaban.Text = dtEdit.Rows[0][2].ToString();
                }
                else
                {
                    edit_giaban.Text = dtEdit.Rows[0][1].ToString();
                }
            }
        }

        private void edit_si_CheckedChanged(object sender, EventArgs e)
        {
            if (!blClick)
            {
                load_comboboxEdit();
                if (edit_le.Checked)
                {
                    edit_giaban.Text = dtEdit.Rows[0][2].ToString();
                }
                else
                {
                    edit_giaban.Text = dtEdit.Rows[0][1].ToString();
                }
            }
        }

        private void edit_sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blClick)
            {
                edit_giaban.Text = gridView1.GetFocusedRowCellValue("giaban").ToString();
                loadhinh(1);
            }
        }

        private void edit_sl_EditValueChanged(object sender, EventArgs e)
        {
            if (!blClick)
            {
                try
                {
                    if (int.Parse(edit_sl.Text) > int.Parse(edit_kho.Text))
                    {
                        XtraMessageBox.Show("Số lượng Hàng trong kho không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        edit_sl.SelectAll();
                        edit_sl.Focus();
                        return;
                    }
                    edit_thanhtien.Text = (long.Parse(edit_giaban.Text) * int.Parse(edit_sl.Text)).ToString();
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Dữ liệu nhập sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    edit_sl.SelectAll();
                    edit_sl.Focus();
                    return;
                }
            }

        }

        private void edit_giaban_EditValueChanged(object sender, EventArgs e)
        {
            if (!blClick)
            {
                edit_thanhtien.Text = (long.Parse(edit_giaban.Text) * int.Parse(edit_sl.Text)).ToString();
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            
                anhien(false);
        }


    }
}