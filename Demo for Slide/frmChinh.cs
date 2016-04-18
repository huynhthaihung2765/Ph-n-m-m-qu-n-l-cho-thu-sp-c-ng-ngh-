using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSLayer;
using DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Demo
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        ucHTHuongDanSuDung hdsd = new ucHTHuongDanSuDung();
        ucQLSanPham QLSP = new ucQLSanPham();
        ucQLKhachHang QLKH = new ucQLKhachHang();
        ucTTTSanPham thongtinthueSP = new ucTTTSanPham();
        ucTCKhachHang tracuuKH = new ucTCKhachHang();
        ucTTTKhachHang thongtinthueKH = new ucTTTKhachHang();
        ucTCHoaDon tracuuHD = new ucTCHoaDon();
        ucTCSanPham tracuuSP = new ucTCSanPham();
        ucBCSanPham baocaoSP = new ucBCSanPham();
        ucBCKhachHang baocaoKH = new ucBCKhachHang();
        ucBCDoanhThu baocaoDT = new ucBCDoanhThu();
        ucBCMayHu baocaoMH = new ucBCMayHu();
        frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
        frmDangKy frmDangKy = new frmDangKy();

        int thoigiancho = 5;

        public frmChinh()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryThames, true, false);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSPDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            //  this.nHANVIENTableAdapter.Fill(this.qLSPDataSet1.NHANVIEN);

            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
            this.Enabled = false;

           

            frmPreLoad formPreload = new frmPreLoad();
            formPreload.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            hdsd.Dock = DockStyle.Fill;
            pncntr.Controls.Add(hdsd);
        }

        private void btQLSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            QLSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(QLSP);
            QLSP.Visible = true;

            
        }

        private void btQLKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            QLKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(QLKH);
        }

        private void btTTTSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            thongtinthueSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(thongtinthueSP);
        }

        private void btTTTKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            thongtinthueKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(thongtinthueKH);
        }

        private void btTTTBienBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btTCKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            tracuuKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(tracuuKH);
        }

        private void btHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            tracuuHD.Dock = DockStyle.Fill;
            pncntr.Controls.Add(tracuuHD);
        }

        private void btTCSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            tracuuSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(tracuuSP);
        }

        private void btBCKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            baocaoKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoKH);
        }

        private void btBCSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            baocaoSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoSP);
        }

        private void btBCDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            baocaoDT.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoDT);
        }

        private void btBCMayHu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 10;
            formPreLoad.Show();
            baocaoMH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoMH);
        }

        private void btHTDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn thật sự muốn đổi mật khẩu", "Thông báo đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                
                frmDoiMatKhau.Show();
                this.Enabled = false;
            }
          
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có thật sự muốn thoát.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btHTDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn thật sự muốn đăng xuất", "Thông báo đăng xuất",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
               frmDangNhap.Size = new Size(316, 145);
                this.Enabled = false;
            }
        }

        private void btHTDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn muốn đăng ký thành viên mới", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Enabled = false;
                
                frmDangKy.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (thoigiancho <= 5 && thoigiancho > 0)
            {
                thoigiancho = thoigiancho - 1;
            }
            if (thoigiancho == 0)
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
                frmDangNhap.Size = new Size(316, 145);
                timer.Enabled = false;
            }
        }
    }
}
