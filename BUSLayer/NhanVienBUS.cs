using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUSLayer
{
    public class NhanVienBUS
    {
        QLSPCNDataContext qlSPCN = new QLSPCNDataContext();

        // Kiem tra dang nhap tai khoan 
        public bool kiemTraDangNhap(string tendangnhap, string matkhau)
        {
            //Dung LinQ dem so luong tk khi nhap ten dang nhap va mat khau
            int ktdangnhap = (from tk in qlSPCN.NHANVIENs
                            where tk.TenDangNhap == tendangnhap && tk.MatKhau == matkhau
                            select tk).Count();
            if (ktdangnhap == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Dang ky mot nhan vien moi 
        public void dangKyNhanVien(string tennguoidung, string taikhoan, string matkhau, string email, string diachi, string sodienthoai)
        {
            NHANVIEN nhanvien = new NHANVIEN();
            nhanvien.HoTen = tennguoidung;
            nhanvien.TenDangNhap = taikhoan;
            nhanvien.MatKhau = matkhau;
            nhanvien.Email = email;
            nhanvien.SDT = sodienthoai;
            qlSPCN.NHANVIENs.InsertOnSubmit(nhanvien);
            qlSPCN.SubmitChanges();
        }

        // kiem tra dang ky tai khoan trung vs tai khoan khac
        public bool kiemTraDangKy(string tendangnhap, string email)
        {
            // dung linQ dem so luong trung ten dang nhap va email
            int ktDangKy = (from tk in qlSPCN.NHANVIENs
                            where tk.TenDangNhap == tendangnhap || tk.Email == email
                            select tk).Count();

            if (ktDangKy >= 1)// Da bi trung ten dang nhap hoac mat khau.
            {
                return false;
            }
            else // Thai khan nay co the dung duoc
            {
                return true;
            }
        }

        // Kiem tra doi mat khau 
        public bool kiemTraDoiMatKhau(string tendangnhap, string matkhauhientai)
        {
            // Dem soluong tai khoan trung trong csdl 
            int ktDoiMatKhau = (from tk in qlSPCN.NHANVIENs
                                where tk.TenDangNhap == tendangnhap || tk.MatKhau == matkhauhientai
                                select tk).Count();

            if (ktDoiMatKhau == 1) // tai khoan nay la duy nhat va co the cap nhat mat khau
            {
                return true;
            }
            else // khong co tai khoan nao hoac co nhieu tai khhoan bi trung ten tai khoan hoac trung mat khau
            {
                return false;
            }
        }

        // Thay doi mat khau moi.
        public void doiMaTKhau(string tendangnhap, string matkhaumoi)
        {
            NHANVIEN suanhanvien = (from nv in qlSPCN.NHANVIENs
                                    select nv).Single(tk => tk.TenDangNhap == tendangnhap);

            suanhanvien.MatKhau = matkhaumoi;

            qlSPCN.SubmitChanges();
        }

    }
}
