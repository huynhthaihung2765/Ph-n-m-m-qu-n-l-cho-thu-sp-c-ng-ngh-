﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUSLayer
{
    public class KhachHangBUS
    {

        QLSPCNDataContext qlSP = new QLSPCNDataContext();

        // Load danh sach khac khach hang
        public IQueryable hienThiKhachHang()
        {
            var khachHang = from kh in qlSP.KHACHHANGs
                                           select kh;

            return khachHang;
        }

        // Kiem tra khach hang da co trong danh sach hay chua?
        public bool kiemTraKhachHang(string tenkhachhang, string cmnd)
        {
            // Dem so luong khach hang trung trong ten
            int kiemTraKhachHang = (from khachhang in qlSP.KHACHHANGs
                                    where khachhang.TenKH == tenkhachhang && khachhang.CMND == cmnd
                                    select khachhang).Count();
            // khach hang da trung ten
            if (kiemTraKhachHang >= 1) 
            {
                return false;
            }
            // khach hang van chua co trong danh sach
            else
            {
                return true;
            }
        }

        // Dang ky khach hang moi khi thue linh kien
        public void dangKyKhachHang(string tenkhachhang, string cmnd, string diachi, string sodienthoai)
        {
            //tao mot doi tuong khach hang
            KHACHHANG khachhang = new KHACHHANG();

            //Nhung thong tin de dang ky cho khach hang
            khachhang.TenKH = tenkhachhang;
            khachhang.CMND = cmnd;
            khachhang.DiaChi = diachi;
            khachhang.SDT = sodienthoai;

            // Thong tin khach hang se dc luu lai
            qlSP.KHACHHANGs.InsertOnSubmit(khachhang); 

            //luu thong tin xuong SQL
            qlSP.SubmitChanges();
        }

        // Sua thong tin khach hang
        public void suaKhachHang(string tenkhachhang, string diachi, string sodienthoai)
        {
            // Lay khach hang da da co ten dc tim thay
            KHACHHANG suaKhachHang = (from khachhang in qlSP.KHACHHANGs
                                  select khachhang).Single(kh => kh.TenKH == tenkhachhang);

            // Nhung thong tin can dc sua cua khach hang
            suaKhachHang.DiaChi = diachi;
            suaKhachHang.SDT = sodienthoai;

            //thay doi csdl trong SQL
            qlSP.SubmitChanges(); 
        }

        // Xoa Khach hang theo ten khach hang
        public void xoaKhachHang(string tenkhachhang)
        {
            KHACHHANG xoaKhachHang = (from khachhang in qlSP.KHACHHANGs
                                  select khachhang).Single(kh => kh.TenKH == tenkhachhang);

            qlSP.KHACHHANGs.DeleteOnSubmit(xoaKhachHang);

            qlSP.SubmitChanges();

        }

    }
}
