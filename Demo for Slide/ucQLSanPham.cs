﻿using System;
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
            // This line of code is generated by Data Source Configuration Wizard
            grctrl_QLSP.DataSource = new DAL.QLSPCNDataContext().CT_HDs;
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = new DAL.QLSPCNDataContext().SANPHAMs;
        }


        private void ucQLSanPham_Load(object sender, EventArgs e)
        {
        }

        public void loadSP()
        {
        }

        public void doitenColumns()
        {
        }
    }
}
