﻿namespace Demo
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
            this.grctrQLSP = new DevExpress.XtraGrid.GridControl();
            this.grvwQLSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrQLSP)).BeginInit();
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
            // grctrQLSP
            // 
            this.grctrQLSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrQLSP.Location = new System.Drawing.Point(184, 0);
            this.grctrQLSP.MainView = this.grvwQLSP;
            this.grctrQLSP.Name = "grctrQLSP";
            this.grctrQLSP.Size = new System.Drawing.Size(546, 535);
            this.grctrQLSP.TabIndex = 1;
            this.grctrQLSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvwQLSP});
            // 
            // grvwQLSP
            // 
            this.grvwQLSP.GridControl = this.grctrQLSP;
            this.grvwQLSP.Name = "grvwQLSP";
            // 
            // ucQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grctrQLSP);
            this.Controls.Add(this.navBarControl1);
            this.Name = "ucQLSanPham";
            this.Size = new System.Drawing.Size(730, 535);
            this.Load += new System.EventHandler(this.ucQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrQLSP)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grctrQLSP;
        private DevExpress.XtraGrid.Views.Grid.GridView grvwQLSP;
    }
}
