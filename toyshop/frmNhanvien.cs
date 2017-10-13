using System;
using System.Windows.Forms;
using toyshop.Data;

namespace toyshop
{
    public partial class frmNhanvien : Form
    {
        public frmMain fm = new frmMain();
        nhanvien LNV = new nhanvien();
        public frmNhanvien()
        {
            InitializeComponent();
        }
        string usercu;
        private void buttonTHEM_Click(object sender, EventArgs e)
        {
            
            
            //TRUYEN THAM SO VAO
            //LNV.id = int.Parse(textBoxIDNV.Text);
            if (textBoxUSN.Text.Trim() == "" || textBoxHT.Text.Trim() == "")
            {
                MessageBox.Show("Dữ liệu không được để trống và phải chọn quyền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LNV.username = textBoxUSN.Text;
            LNV.password = tbPass.Text;
            LNV.hoten = textBoxHT.Text;
            LNV.quyen = int.Parse(comboBoxQuyen1.SelectedValue.ToString());
            // goi phuong thuc xu ly
            

            if (LNV.kiemtrausernametrung()== false)
            {
                LNV.ThemMoi();

                MessageBox.Show("Đã thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_DuLieu();
            }

            else
            {
                MessageBox.Show("Username bị trùng, hãy nhập lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }

        private void LUOINHANVIEN_Click(object sender, EventArgs e)
        {

        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
          
            Load_DuLieu();
            comboBoxQuyen1.DataSource = LNV.LayDanhSachQuyen();
            comboBoxQuyen1.DisplayMember = "tenquyen";
            comboBoxQuyen1.ValueMember = "id";
        }
       
        public void Load_DuLieu()
        {
           
            
            LUOINHANVIEN.DataSource = LNV.LayDanhSach();
           
        }

        public void GRIDNHANVIEN_Click(object sender, EventArgs e)
        {
            textBoxIDNV.Text = GRIDNHANVIEN.GetFocusedRowCellValue(ID).ToString();
            textBoxUSN.Text = GRIDNHANVIEN.GetFocusedRowCellValue(tendn).ToString();
            textBoxHT.Text = GRIDNHANVIEN.GetFocusedRowCellValue(HOTEN).ToString();
            tbPass.Text = GRIDNHANVIEN.GetFocusedRowCellValue(colPassword).ToString();
            //textBoxQ.Text = GRIDNHANVIEN.GetFocusedRowCellValue(QUYEN).ToString();
            comboBoxQuyen1.Text = GRIDNHANVIEN.GetFocusedRowCellValue(QUYEN).ToString();
            usercu= GRIDNHANVIEN.GetFocusedRowCellValue(tendn).ToString();
        }

        private void buttonSUA_Click(object sender, EventArgs e)
        {
           
          
            //TRUYEN THAM SO VAO
            LNV.id = int.Parse(textBoxIDNV.Text);
            LNV.username = textBoxUSN.Text;
            LNV.password = tbPass.Text;
            LNV.hoten = textBoxHT.Text;
            LNV.quyen = int.Parse(comboBoxQuyen1.SelectedValue.ToString());
            // goi phuong thuc xu ly
            if (LNV.kiemtrausernametrung() == false|| LNV.username==usercu)//username khong bi trung hoac khong sua user
            {
                LNV.Sua();

                MessageBox.Show("Đã sửa thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load_DuLieu();
            }
            else
            {
                MessageBox.Show("Username bị trùng, hãy nhập lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonXOA_Click(object sender, EventArgs e)
        {
           
            LNV.id = int.Parse(textBoxIDNV.Text);
            //goi phuong thuc xoa
            LNV.Xoa();
            //sau khi xoa xong, hien thi thong bao de biet
            MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //load lai du lieu tren form
            Load_DuLieu();
        }
    }
}
