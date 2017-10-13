using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toyshop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhaphang n1 = new frmNhaphang();
            n1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmsetGiaban s1 = new frmsetGiaban();
            s1.Show();
        }
    }
}
