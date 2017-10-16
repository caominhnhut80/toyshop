using DevExpress.XtraEditors;
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
using System.IO;

namespace toyshop
{
    public partial class frmsetGiaban : Form
    {
        public frmMain fm = new frmMain();
        sanpham sp = new sanpham();
        public frmsetGiaban()
        {
            InitializeComponent();
        }

        private void setGiaban_Load(object sender, EventArgs e)
        {
            load_grid();
        }
        private void load_grid()
        {
            gv.DataSource = sp.getGiaban();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            MemoryStream ms;
            tbMahang.Text = gridView1.GetFocusedRowCellValue("mahang").ToString();
            tbSp.Text = gridView1.GetFocusedRowCellValue("tenhang").ToString();
            tbGianhap.Text = gridView1.GetFocusedRowCellValue("gianhap").ToString();
            tbGiabanle.Text = gridView1.GetFocusedRowCellValue("giabanle").ToString();
            tbGiabansi.Text = gridView1.GetFocusedRowCellValue("giabansi").ToString();
            if (gridView1.GetFocusedRowCellValue("hinh") != null)
            {
                try
                {
                    ms = new MemoryStream((byte[])gridView1.GetFocusedRowCellValue("hinh"));
                }
                catch (Exception ex)
                {
                    pictureBox2.Image = null;
                    return;
                    throw ex;
                }

                pictureBox2.Image = null;
                pictureBox2.Image = Image.FromStream(ms);
            }

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (long.Parse(tbGiabansi.Text)<long.Parse(tbGianhap.Text)|| long.Parse(tbGiabanle.Text) < long.Parse(tbGianhap.Text))
            {
                XtraMessageBox.Show("Giá bán sỉ/bán lẻ phải lớn hơn giá nhập vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (tbMahang.Text == "")
            {
                XtraMessageBox.Show("Chưa chọn hàng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                sp.giabanle = long.Parse(tbGiabanle.Text);
                sp.giabansi = long.Parse(tbGiabansi.Text);
                sp.mahang = tbMahang.Text;
                if (sp.setGiaban()==-1)
                {
                    XtraMessageBox.Show("Định giá thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else
                {
                    XtraMessageBox.Show("Cài đặt giá thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    load_grid();
                }
            }
        }

        private void tbGiabanle_Click(object sender, EventArgs e)
        {
            (sender as TextEdit).SelectAll();
        }

        private void tbGiabansi_Click(object sender, EventArgs e)
        {
            (sender as TextEdit).SelectAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();       }

        
    }
}
