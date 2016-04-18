using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUSLayer
{
    public class BangXuatSPBUS
    {
        QLSPCNDataContext qlSP = new QLSPCNDataContext();

        // Kiểm tra số lượng  xuất để biết mà xóa sản phẩm đó.
        public bool kiemtraSoluong(int masp)
        {
            string soluong = qlSP.XUATSPs.Single(sanpham => sanpham.MaSP == masp).SoLuong.ToString();
            int sl = int.Parse(soluong);

            if (sl == 0 )
            {
                return true;
            }
            else
            {
                // không xóa được
                return false;
            }
        }

        // Xóa bản xuất số Lượng
        public void xoaBangXuatSP(int masp)
        {
            XUATSP xoaXuatSP = (from xuatsp in qlSP.XUATSPs
                                where xuatsp.MaSP == masp
                                select xuatsp).Single();
            qlSP.XUATSPs.DeleteOnSubmit(xoaXuatSP);
            qlSP.SubmitChanges();
        }
    }
}
