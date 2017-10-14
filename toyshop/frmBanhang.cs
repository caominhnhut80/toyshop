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
            DataTable dt = new DataTable();
            // hiện giá bán, số lượng tồn kho, đơn vị tính theo sản phẩm
            //MessageBox.Show(tbmahang.SelectedValue.ToString());
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

        }
    }
}