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
namespace Demo
{
    public partial class ucQLKhachHang : UserControl
    {

        public ucQLKhachHang()
        {
            InitializeComponent();

        }
        LinktoSQLDataContext db = new LinktoSQLDataContext();

        private void loadKhachHang()
        {
            
            var list = from p in db.KHACHHANGs
                       where p.CMND == p.CMND//Chọn toàn bộ bảng
                       select p;
            gridctrl_QLKH.DataSource = list;
        }
        private void gridctrl_QLKH_Click(object sender, EventArgs e)
        {
            //gridctrl_QLKH.DataSource = db.KHACHHANGs;//Cách 1
            
            //Refresh();//Cách 2
        }

        QLSPDataContext qlsp = new QLSPDataContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            gridctrl_QLKH.DataSource = db.KHACHHANGs;
            //loadKhachHang();
=======
>>>>>>> origin/master
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

       
    }
}
