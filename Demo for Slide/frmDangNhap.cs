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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            
            frmChinh FC = new frmChinh();
            //FC.Activate();
            FC.Show();
            this.Hide();
        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            grctrlDangKy.Enabled = false;
            grctrlLayMatKhau.Enabled = false;
        }
        private void grcntrDoiMatKhau_Paint(object sender, PaintEventArgs e)
        {
            grctrlDoiMatKhau.Enabled = false;
        }

        private void grctrlDangKy_Paint(object sender, PaintEventArgs e)
        {
           // grctrlDangKy.Enabled = false;
        }

        private void grctrlLayMatKhau_Paint(object sender, PaintEventArgs e)
        {
            grctrlLayMatKhau.Enabled = false;
        }

        private void btDNThoat_Click(object sender, EventArgs e)
        {

        }

        private void lbDNTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            grctrlDangKy.Enabled = true;
            if (grctrlLayMatKhau.Enabled == true)
            {
                grctrlLayMatKhau.Enabled = false;
            }
        }

        private void lbDNQuenMatKhau_Click(object sender, EventArgs e)
        {
            grctrlLayMatKhau.Enabled = true;
            if (grctrlDangKy.Enabled == true)
            {
                grctrlDangKy.Enabled = false;
            }
        }

        private void txtLMKTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if(grcntrDangNhap.Enabled == true || grctrlDangKy.Enabled == true || grctrlDoiMatKhau.Enabled == true)
            {
                grctrlDangKy.Enabled = false;
                grcntrDangNhap.Enabled = false;
                grctrlDoiMatKhau.Enabled = false;
            }
        }

        private void txtDKTenNguoiDung_TextChanged(object sender, EventArgs e)
        {
            if (grcntrDangNhap.Enabled == true || grctrlLayMatKhau.Enabled == true || grctrlDoiMatKhau.Enabled == true)
            {
                grcntrDangNhap.Enabled = false;
                grctrlLayMatKhau.Enabled = false;
                grctrlDoiMatKhau.Enabled = false;
            }
        }

        private void btHuyDangKy_Click(object sender, EventArgs e)
        {
            grcntrDangNhap.Enabled = true;
            grctrlDangKy.Enabled = false;
        }

        private void grctrlDangKy_Click(object sender, EventArgs e)
        {

        }

        private void txtDMKTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (grcntrDangNhap.Enabled == true || grctrlDangKy.Enabled == true || grctrlLayMatKhau.Enabled == true)
            {
                grcntrDangNhap.Enabled = false;
                grctrlDangKy.Enabled = false;
                grctrlLayMatKhau.Enabled = false;
            }
        }

        private void lbLMK_Click(object sender, EventArgs e)
        {

        }

        private void grctrlDoiMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grctrlLayMatKhau_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void grctrlDangKy_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát.","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
