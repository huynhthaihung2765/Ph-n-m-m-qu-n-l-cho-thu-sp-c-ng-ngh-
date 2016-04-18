using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DAL;
using BUSLayer;
using DevExpress.XtraEditors.Repository;
using System.Data.Sql;
using System.Data.Linq;
using DevExpress.XtraEditors.Controls;

namespace Demo
{
    public partial class ucQLKhachHang : UserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        public ucQLKhachHang()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
            grctrlKhachHang.DataSource = khachhangBUS.hienThiKhachHang();
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNganHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridctrlQLKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void grctrl_QLKH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbThongBao.Text = "không thể nhập ký tự khác ngoài số trong ô (CMND).";
            }
            else if (txtCMND.Text.Length > 12)
            {
                lbThongBao.Text = "Số CMND hiện hành là 12 chữ số.";
            }
            else
            {
                lbThongBao.Text = "";
            }
        }


        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và click vào sửa.";
        }

        private void grctrlKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và click vào sửa.";
        }
    }
}
