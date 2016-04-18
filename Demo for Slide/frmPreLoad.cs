using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Demo
{
    public partial class frmPreLoad : DevExpress.XtraEditors.XtraForm
    {
        public int thoigianhienthi = 20;
        public frmPreLoad()
        {
            
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            
            if (thoigianhienthi <= 20 && thoigianhienthi > 0)
            {
                thoigianhienthi = thoigianhienthi - 1;
                lbTime.Text = thoigianhienthi.ToString() + " Giây";
            }
            if (thoigianhienthi == 0)
            {
                this.Close();
            }
        }

        private void frmPreLoad_Load(object sender, EventArgs e)
        {
            
            lbTime.Visible = false;
        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
