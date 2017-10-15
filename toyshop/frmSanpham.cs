using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toyshop.Data;

namespace toyshop
{
    public partial class frmSanpham : Form
    {
        public frmMain fm = new frmMain();
        sanpham CH = new sanpham();
        string filename;
        image im = new image();
        public frmSanpham()
        {
            InitializeComponent();
        }
        string mahangcu;

        private void btthem_Click_1(object sender, EventArgs e)
        {
            
           
            //truyen tham so vao
           CH.mahang=txtmahang.Text;
           CH.tenhang = txttenhang.Text;
           CH.donvitinh = int.Parse(combodvt.SelectedValue.ToString());
           CH.kiemtramahang();
           if (txtmahang.Text.Trim() == "")
           {
               MessageBox.Show("Mã hàng không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           if (CH.kiemtramahang() == true)
           {
               MessageBox.Show(" Mã hàng bạn nhập đã bị trùng hoặc bỏ trống đề nghị nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return;
           }

           if (combodvt.Text== null)
           {
               MessageBox.Show("Đơn vị tính không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           if (filename!="") CH.hinh = im.ReadFile(filename);
            //goi ham xu ly
           CH.ThemMoisp();
            //TL.ThemMoi();
            MessageBox.Show(" Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_database();
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            
            //truyen tham so vao
            CH.mahang = txtmahang.Text;
            CH.tenhang = txttenhang.Text;
            CH.donvitinh = int.Parse(combodvt.SelectedValue.ToString());
            
            CH.kiemtramahang();
            if (txtmahang.Text.Trim() == "")
            {
                MessageBox.Show("Mã hàng không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CH.kiemtramahang() == true&&txtmahang.Text!=mahangcu)
            {
                MessageBox.Show(" Mã hàng bạn nhập đã bị trùng hoặc bỏ trống đề nghị nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
            if (combodvt.Text== null)
            {
                MessageBox.Show("Đơn vị tính không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            CH.Sua();
            //TL.ThemMoi();
            MessageBox.Show(" Đã sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_database();
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
           
            // lkh.IDLOAI = int.Parse(txtid.Text);
            CH.mahang =txtmahang.Text;
            CH.Xoa();
            // lkh.Xoa();
            MessageBox.Show(" Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  load();
            load_database();
        }
        public void load_database()
        {

            combodvt.DataSource = CH.LayDanhSach_dvt();
            combodvt.DisplayMember = "donvitinh";
            combodvt.ValueMember = "id";
            luoitenchngoai.DataSource = CH.LayDanhSach();
        }      
      

       

        
        private void Load_DuLieu_tuluoilentext()
        {
            MemoryStream ms;
            txtmahang.Text = luoitench.GetFocusedRowCellValue(mahang).ToString();
            mahangcu = luoitench.GetFocusedRowCellValue(mahang).ToString();
            txttenhang.Text = luoitench.GetFocusedRowCellValue(tenhang).ToString();
            combodvt.Text = luoitench.GetFocusedRowCellValue("donvitinh").ToString();
            if (luoitench.GetFocusedRowCellValue("hinh") != null)
            {
                try
                {
                    ms = new MemoryStream((byte[])luoitench.GetFocusedRowCellValue("hinh"));
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                pictureBox1.Image = null;
                pictureBox1.Image = Image.FromStream(ms);
            }
            
            // txtdonvitinh.Text = luoitench.GetFocusedRowCellValue(donvitinh).ToString();


        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            load_database();
        }

        private void luoitench_Click(object sender, EventArgs e)
        {
            Load_DuLieu_tuluoilentext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                //System.IO.StreamReader sr = new
                //   System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                //sr.Close();
            }
        }
    }
}
