using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class ucQLSanPham : UserControl
    {
        public ucQLSanPham()
        {
            InitializeComponent();
        }
        QLSPDataContext qlsp = new QLSPDataContext();

        private void ucQLSanPham_Load(object sender, EventArgs e)
        {
            loadSP();
            doitenColumns();
        }

        public void loadSP()
        {
            //dung cau lenh SQL de lay thong tin sản phẩm.
            var sanpham = from sp in qlsp.SPs
                          select sp;
            //dung datasource de load len gridcontrol.
            grctrQLSP.DataSource = sanpham;
        }

        public void doitenColumns()
        {
            //Doi ten cho tung columns 
            grvwQLSP.Columns["MaSP"].Visible = false;
            grvwQLSP.Columns["MoTa"].Caption = "Mô tả";
            grvwQLSP.Columns["TinhTrang"].Caption = "Tình trạng";
            grvwQLSP.Columns["MaLoaiSP"].Visible = false;
            grvwQLSP.Columns["NgayVao"].Caption = "Ngày vào";
            grvwQLSP.Columns["SoHDTT"].Caption = "Số hóa đơn thu tiền";
            grvwQLSP.Columns["NgayRa"].Caption = "Ngày ra";
            grvwQLSP.Columns["LOAISP"].Caption = "Loại sản phẩm";
            grvwQLSP.Columns["SPVao"].Caption = "Sản phẩm vào";
            grvwQLSP.Columns["HDTT"].Caption = "Hóa đơn thu tiền";
            grvwQLSP.Columns["SPRa"].Caption = "Sản phẩm ra";
        }
    }
}
