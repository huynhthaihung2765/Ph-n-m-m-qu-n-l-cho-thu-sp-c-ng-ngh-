using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            grctrlDoiMatKhau.Enabled = true;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            
            frmChinh FC = new frmChinh();
            //FC.Activate();
            FC.ShowDialog();
            this.Close();
        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        private void grcntrDoiMatKhau_Paint(object sender, PaintEventArgs e)
        {
            grctrlDoiMatKhau.Enabled = false;
        }

        private void grctrlDangKy_Paint(object sender, PaintEventArgs e)
        {
            grctrlDangKy.Enabled = false;
        }

        private void grctrlLayMatKhau_Paint(object sender, PaintEventArgs e)
        {
            grctrlLayMatKhau.Enabled = false;
        }

        private void btDNThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn có muốn thoát !");
            this.Close();
        }

        private void lbDNTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            grctrlDangKy.Enabled = true;
        }
        
    }
}
