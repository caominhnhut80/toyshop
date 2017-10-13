﻿using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using toyshop.Data;

namespace toyshop
{
    public partial class login_form : Form
    {
        public frmMain fm = new frmMain();
        public nhanvien nv = new nhanvien();
        public login_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (nv.id == -1)
            {
                fm.Close();
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                nv=nv.check_userlogin(tbUsername.Text, tbPassword.Text);
                if (nv.id != -1)
                {
                    fm.nv = nv;
                    fm.Show();
                    this.Close();
                } else
                {
                    XtraMessageBox.Show("Sai username hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                XtraMessageBox.Show("Bạn phải nhập username và mật khẩu", "Dăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
