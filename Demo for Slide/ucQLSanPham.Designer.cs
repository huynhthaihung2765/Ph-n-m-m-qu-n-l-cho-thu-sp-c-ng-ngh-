namespace Demo
{
    partial class ucQLSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbargrQLSanPham = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarQLLaptop = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLLoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLMayChieu = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLPhuKien = new DevExpress.XtraNavBar.NavBarItem();
            this.navbargrQLTacVu = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarQLSP_Them = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLSP_Sua = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLSP_Xoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLSP_Luu = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLSP_Thoat = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarPhuKien = new DevExpress.XtraNavBar.NavBarItem();
            this.grctrl_QLSP = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grvwQLSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoXuLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAISP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrl_QLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvwQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navbargrQLSanPham;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbargrQLSanPham,
            this.navbargrQLTacVu});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarQLLaptop,
            this.navbarQLLoa,
            this.navbarQLMayChieu,
            this.navbarPhuKien,
            this.navbarQLPhuKien,
            this.navbarQLSP_Them,
            this.navbarQLSP_Sua,
            this.navbarQLSP_Xoa,
            this.navbarQLSP_Luu,
            this.navbarQLSP_Thoat});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 184;
            this.navBarControl1.Size = new System.Drawing.Size(184, 535);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "Sản phẩm";
            // 
            // navbargrQLSanPham
            // 
            this.navbargrQLSanPham.Caption = "Sản phẩm";
            this.navbargrQLSanPham.Expanded = true;
            this.navbargrQLSanPham.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLLaptop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLLoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLMayChieu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLPhuKien)});
            this.navbargrQLSanPham.Name = "navbargrQLSanPham";
            // 
            // navbarQLLaptop
            // 
            this.navbarQLLaptop.Caption = "Laptop";
            this.navbarQLLaptop.Name = "navbarQLLaptop";
            // 
            // navbarQLLoa
            // 
            this.navbarQLLoa.Caption = "Loa";
            this.navbarQLLoa.Name = "navbarQLLoa";
            // 
            // navbarQLMayChieu
            // 
            this.navbarQLMayChieu.Caption = "Máy chiếu";
            this.navbarQLMayChieu.Name = "navbarQLMayChieu";
            // 
            // navbarQLPhuKien
            // 
            this.navbarQLPhuKien.Caption = "Phụ kiện";
            this.navbarQLPhuKien.Name = "navbarQLPhuKien";
            // 
            // navbargrQLTacVu
            // 
            this.navbargrQLTacVu.Caption = "Tác vụ";
            this.navbargrQLTacVu.Expanded = true;
            this.navbargrQLTacVu.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLSP_Them),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLSP_Sua),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLSP_Xoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLSP_Luu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLSP_Thoat)});
            this.navbargrQLTacVu.Name = "navbargrQLTacVu";
            // 
            // navbarQLSP_Them
            // 
            this.navbarQLSP_Them.Caption = "Thêm sản phẩm mới";
            this.navbarQLSP_Them.Name = "navbarQLSP_Them";
            // 
            // navbarQLSP_Sua
            // 
            this.navbarQLSP_Sua.Caption = "Sửa thông tin sản phẩm";
            this.navbarQLSP_Sua.Name = "navbarQLSP_Sua";
            // 
            // navbarQLSP_Xoa
            // 
            this.navbarQLSP_Xoa.Caption = "Xóa sản phẩm";
            this.navbarQLSP_Xoa.Name = "navbarQLSP_Xoa";
            // 
            // navbarQLSP_Luu
            // 
            this.navbarQLSP_Luu.Caption = "Lưu sản phẩm";
            this.navbarQLSP_Luu.Name = "navbarQLSP_Luu";
            // 
            // navbarQLSP_Thoat
            // 
            this.navbarQLSP_Thoat.Caption = "Thoát";
            this.navbarQLSP_Thoat.Name = "navbarQLSP_Thoat";
            // 
            // navbarPhuKien
            // 
            this.navbarPhuKien.Caption = "Phụ kiện";
            this.navbarPhuKien.Name = "navbarPhuKien";
            // 
            // grctrl_QLSP
            // 
            this.grctrl_QLSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrl_QLSP.Location = new System.Drawing.Point(184, 0);
            this.grctrl_QLSP.MainView = this.grvwQLSP;
            this.grctrl_QLSP.Name = "grctrl_QLSP";
            this.grctrl_QLSP.Size = new System.Drawing.Size(546, 535);
            this.grctrl_QLSP.TabIndex = 1;
            this.grctrl_QLSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvwQLSP});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DAL.SANPHAM);
            // 
            // grvwQLSP
            // 
            this.grvwQLSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colMoTa,
            this.colTinhTrang,
            this.colMaLoaiSP,
            this.colManHinh,
            this.colRam,
            this.colBoXuLy,
            this.colDoHoa,
            this.colNhaSX,
            this.colGiaThue,
            this.colSoLuong,
            this.colLOAISP});
            this.grvwQLSP.GridControl = this.grctrl_QLSP;
            this.grvwQLSP.Name = "grvwQLSP";
            this.grvwQLSP.OptionsView.ShowFooter = true;
            this.grvwQLSP.OptionsView.ShowGroupPanel = false;
            // 
            // colMaSP
            // 
            this.colMaSP.FieldName = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            // 
            // colTenSP
            // 
            this.colTenSP.FieldName = "TenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            // 
            // colMoTa
            // 
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 2;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 3;
            // 
            // colMaLoaiSP
            // 
            this.colMaLoaiSP.FieldName = "MaLoaiSP";
            this.colMaLoaiSP.Name = "colMaLoaiSP";
            this.colMaLoaiSP.Visible = true;
            this.colMaLoaiSP.VisibleIndex = 4;
            // 
            // colManHinh
            // 
            this.colManHinh.FieldName = "ManHinh";
            this.colManHinh.Name = "colManHinh";
            this.colManHinh.Visible = true;
            this.colManHinh.VisibleIndex = 5;
            // 
            // colRam
            // 
            this.colRam.FieldName = "Ram";
            this.colRam.Name = "colRam";
            this.colRam.Visible = true;
            this.colRam.VisibleIndex = 6;
            // 
            // colBoXuLy
            // 
            this.colBoXuLy.FieldName = "BoXuLy";
            this.colBoXuLy.Name = "colBoXuLy";
            this.colBoXuLy.Visible = true;
            this.colBoXuLy.VisibleIndex = 7;
            // 
            // colDoHoa
            // 
            this.colDoHoa.FieldName = "DoHoa";
            this.colDoHoa.Name = "colDoHoa";
            this.colDoHoa.Visible = true;
            this.colDoHoa.VisibleIndex = 8;
            // 
            // colNhaSX
            // 
            this.colNhaSX.FieldName = "NhaSX";
            this.colNhaSX.Name = "colNhaSX";
            this.colNhaSX.Visible = true;
            this.colNhaSX.VisibleIndex = 9;
            // 
            // colGiaThue
            // 
            this.colGiaThue.FieldName = "GiaThue";
            this.colGiaThue.Name = "colGiaThue";
            this.colGiaThue.Visible = true;
            this.colGiaThue.VisibleIndex = 10;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 11;
            // 
            // colLOAISP
            // 
            this.colLOAISP.FieldName = "LOAISP";
            this.colLOAISP.Name = "colLOAISP";
            this.colLOAISP.Visible = true;
            this.colLOAISP.VisibleIndex = 12;
            // 
            // ucQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grctrl_QLSP);
            this.Controls.Add(this.navBarControl1);
            this.Name = "ucQLSanPham";
            this.Size = new System.Drawing.Size(730, 535);
            this.Load += new System.EventHandler(this.ucQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrl_QLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvwQLSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navbargrQLSanPham;
        private DevExpress.XtraNavBar.NavBarItem navbarQLLaptop;
        private DevExpress.XtraNavBar.NavBarItem navbarQLLoa;
        private DevExpress.XtraNavBar.NavBarItem navbarQLMayChieu;
        private DevExpress.XtraNavBar.NavBarItem navbarPhuKien;
        private DevExpress.XtraNavBar.NavBarItem navbarQLPhuKien;
        private DevExpress.XtraNavBar.NavBarGroup navbargrQLTacVu;
        private DevExpress.XtraNavBar.NavBarItem navbarQLSP_Them;
        private DevExpress.XtraNavBar.NavBarItem navbarQLSP_Sua;
        private DevExpress.XtraNavBar.NavBarItem navbarQLSP_Xoa;
        private DevExpress.XtraNavBar.NavBarItem navbarQLSP_Luu;
        private DevExpress.XtraNavBar.NavBarItem navbarQLSP_Thoat;
        private DevExpress.XtraGrid.GridControl grctrl_QLSP;
        private DevExpress.XtraGrid.Views.Grid.GridView grvwQLSP;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiSP;
        private DevExpress.XtraGrid.Columns.GridColumn colManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colRam;
        private DevExpress.XtraGrid.Columns.GridColumn colBoXuLy;
        private DevExpress.XtraGrid.Columns.GridColumn colDoHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaSX;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaThue;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAISP;
    }
}
