﻿using System;
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

namespace Demo
{
    public partial class ucQLKhachHang : UserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        public ucQLKhachHang()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            //gridctrl_QLKH.DataSource = new DAL.QLSPCNDataContext().KHACHes;
            // This line of code is generated by Data Source Configuration Wizard
            //bindingSource1.DataSource = new DAL.QLSPCNDataContext().KHACHes;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
            grctrlQLKH.DataSource = khachhangBUS.hienThiKhachHang();

            grvwQLKH.Columns["TenKH"].Caption = "Tên khách hàng";
            grvwQLKH.Columns["DiaChi"].Caption = "Địa chỉ";
            //grvwQLKH.Columns["CMND"]. = "Ngày hẹn đặt";
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
    }
}
