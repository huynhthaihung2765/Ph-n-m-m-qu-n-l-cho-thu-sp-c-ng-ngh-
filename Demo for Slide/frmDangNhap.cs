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
using System.IO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;


namespace Demo
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        NhanVienBUS nhanVienBus = new NhanVienBUS();
        QLSPCNDataContext qlsp = new QLSPCNDataContext();
        

        public frmDangNhap()
        {
            InitializeComponent();
            // Gallery Skin
            //DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            //UserLookAndFeel.Default.SetSkinStyle("Default");
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (nhanVienBus.kiemTraDangNhap(txtDNTaiKhoan.Text, txtDNMatKhau.Text) == true)
            {
                foreach (Form oform in Application.OpenForms)
                {
                    if (oform is frmChinh)
                    {
                        oform.Enabled = true;
                        break;
                    }
                }
                this.Close(); 
            }
            else
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu không đúng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Chương trình sẽ đóng lại, đóng(Yes)/không(No)", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbDNQuenMatKhau_Click(object sender, EventArgs e)
        {
            foreach (Form oform in Application.OpenForms)
            {
                if (oform is frmChinh)
                {
                    oform.Enabled = true;
                    break;
                }
            }
            this.Visible = false;
            frmTimMatKhau frmTimMatKhau = new frmTimMatKhau();
            frmTimMatKhau.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
        }

        //Hàm để chuyển byte[] => image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image image = Image.FromStream(ms);
            return image;
        }

        private void txtDNTaiKhoan_Leave(object sender, EventArgs e)
        {
            txtTaiKhoangLeave();
        }

        private void txtDNTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void grcntrDangNhap_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        public void txtTaiKhoangLeave()
        {

            try
            {
                // Lấy ra  tên nhân viên trong Table Nhan vien
                string tenNhanVien = qlsp.NHANVIENs.Single(nhanvien => nhanvien.TenDangNhap == txtDNTaiKhoan.Text).TenDangNhap;
                // Kt tên nhân viên đó đúng với tên kong table Nhân viên
                if (tenNhanVien != "")
                {

                    var hinhanh = (from nv in qlsp.NHANVIENs
                                   where nv.TenDangNhap == txtDNTaiKhoan.Text
                                   select nv).Single();
                    picNhanVien.Image = ByteArrayToImage(hinhanh.HinhAnh.ToArray());
                    //picChange1.Image = imageCollection.Images["apply_16x16.png"];
                    frmDangNhap.ActiveForm.Size = new Size(316, 432);
                    Image image = picNhanVien.Image;
                    if (image.Width < picNhanVien.Width && image.Height < picNhanVien.Height)
                    {
                        picNhanVien.SizeMode = PictureBoxSizeMode.Normal;
                    }
                    else
                    {
                        picNhanVien.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                }
                else
                {
                    frmDangNhap.ActiveForm.Size = new Size(316, 150);
                }
            }
            catch
            {
                frmDangNhap.ActiveForm.Size = new Size(316, 150);
            }
        }

        private void txtMatKhauChange()
        {
            try
            {
                int matKhauNhanVien = (from nhanvien in qlsp.NHANVIENs
                                          where nhanvien.TenDangNhap == txtDNTaiKhoan.Text && nhanvien.MatKhau == txtDNMatKhau.Text
                                          select nhanvien).Count();
                if (matKhauNhanVien == 1)
                {
                    picChange2.Image = imageCollection.Images["apply_16x16.png"];
                }
                else
                {
                    picChange2.Image = imageCollection.Images["cancel_16x16.png"];
                }
            }
            catch
            {
                picChange2.Image = imageCollection.Images["cancel_16x16.png"];
            }
        }

        private void txtDNMatKhau_Properties_Leave(object sender, EventArgs e)
        {
            txtMatKhauChange();
        }

        private void txtDNMatKhau_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtDNMatKhau_Properties_Enter(object sender, EventArgs e)
        {
           
        }

        private void picSeePass_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureEdit1_Properties_MouseHover(object sender, EventArgs e)
        {
            txtDNMatKhau.Properties.PasswordChar = (char)0;
        }

        private void pictureEdit1_Properties_MouseLeave(object sender, EventArgs e)
        {
            txtDNMatKhau.Properties.PasswordChar = '*';
        }

        private void picNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picNhanVien_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                var hinhanh = (from nv in qlsp.NHANVIENs
                               where nv.TenDangNhap == txtDNTaiKhoan.Text
                               select nv).Single();
                Image image = ByteArrayToImage(hinhanh.HinhAnh.ToArray());
                // Thay đổi kich thước của picture box theo scale của image
                if (image.Width < picNhanVien.Width && image.Height < picNhanVien.Height)
                {
                    picNhanVien.SizeMode = PictureBoxSizeMode.Normal;
                }
                else
                {
                    picNhanVien.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch
            {
                picNhanVien.Image = imageCollection.Images["fullstackedsplinearea_32x32.png"];
            }
        }

        public static implicit operator frmDangNhap(Size v)
        {
            throw new NotImplementedException();
        }
    }
}
