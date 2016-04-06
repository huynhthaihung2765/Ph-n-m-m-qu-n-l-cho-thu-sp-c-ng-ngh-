using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BUSLayer;

namespace Demo
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        NhanVienBUS nhanVienBus = new NhanVienBUS();

        public frmDangNhap()
        {
            InitializeComponent();
            // Gallery Skin
            //DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            //UserLookAndFeel.Default.SetSkinStyle("Default");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        
         
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (nhanVienBus.kiemTraDangNhap(txtDNTaiKhoan.Text, txtDNMatKhau.Text) == true)
            {
                frmChinh FC = new frmChinh();
                //FC.Activate();
                FC.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu không đúng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            DialogResult dialog = XtraMessageBox.Show("Bạn thật sự muốn thoát.","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btLayMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
                if (nhanVienBus.kiemTraDangKy(txtDKTaiKhoan.Text, txtDKEmail.Text) == true)
                {
                    //nhanVienBus.dangKyNhanVien(txtDKTenNguoiDung.Text, txtDKTaiKhoan.Text, txtDKMatKhau.Text, txtDKEmail.Text);
                    XtraMessageBox.Show("Bạn đã đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    XtraMessageBox.Show("Tên tài khoản hoặc mật khẩu đã có người sử dụng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (nhanVienBus.kiemTraDoiMatKhau(txtDMKTaiKhoan.Text, txtDMKHienTai.Text) == true)
            {
                nhanVienBus.doiMaTKhau(txtDMKTaiKhoan.Text, txtDMKMoi.Text);
                XtraMessageBox.Show("Bạn đã đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                grctrlDoiMatKhau.Enabled = false;
                grcntrDangNhap.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu hiện tại ko đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btLMKCancel_Click(object sender, EventArgs e)
        {
            grcntrDangNhap.Enabled = true;
            grctrlLayMatKhau.Enabled = false;
        }

        private void grcntrDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
