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

namespace Demo
{
    public partial class frmChinh : DevExpress.XtraEditors.XtraForm
    {
        public frmChinh()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryThames, true, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSPDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
          //  this.nHANVIENTableAdapter.Fill(this.qLSPDataSet1.NHANVIEN);


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
            ucHTHuongDanSuDung hdsd = new ucHTHuongDanSuDung();
            hdsd.Dock = DockStyle.Fill;
            pncntr.Controls.Add(hdsd);
        }

        private void btQLSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucQLSanPham QLSP = new ucQLSanPham();
            QLSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(QLSP);
        }

        private void btQLKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucQLKhachHang QLKH = new ucQLKhachHang();
            QLKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(QLKH);
        }

        private void btTTTSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucTTTSanPham thongtinthueSP = new ucTTTSanPham();
            thongtinthueSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(thongtinthueSP);
        }

        private void btTTTKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucTTTKhachHang thongtinthueKH = new ucTTTKhachHang();
            thongtinthueKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(thongtinthueKH);
        }

        private void btTTTBienBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucTTTBienBanThue thongtinthueBB = new ucTTTBienBanThue();
            thongtinthueBB.Dock = DockStyle.Fill;
            pncntr.Controls.Add(thongtinthueBB);
        }

        private void btTCKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucTCKhachHang tracuuKH = new ucTCKhachHang();
            tracuuKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(tracuuKH);
        }

        private void btHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucTCHoaDon tracuuHD = new ucTCHoaDon();
            tracuuHD.Dock = DockStyle.Fill;
            pncntr.Controls.Add(tracuuHD);
        }

        private void btTCSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucTCSanPham tracuuSP = new ucTCSanPham();
            tracuuSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(tracuuSP);
        }

        private void btBCKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucBCKhachHang baocaoKH = new ucBCKhachHang();
            baocaoKH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoKH);
        }

        private void btBCSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucBCSanPham baocaoSP = new ucBCSanPham();
            baocaoSP.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoSP);
        }

        private void btBCDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucBCDoanhThu baocaoDT = new ucBCDoanhThu();
            baocaoDT.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoDT);
        }

        private void btBCMayHu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pncntr.Controls.Clear();
            ucBCMayHu baocaoMH = new ucBCMayHu();
            baocaoMH.Dock = DockStyle.Fill;
            pncntr.Controls.Add(baocaoMH);
        }

        private void btHTDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
            this.Hide();
        }
    }
}
