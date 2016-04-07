using System;
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
        public IEnumerable<KHACH> hienThiKhachHang()
        {
            IEnumerable<KHACH> khachHang = from kh in qlSP.KHACHes
                                           select kh;
            return khachHang;
        }
    }
}
