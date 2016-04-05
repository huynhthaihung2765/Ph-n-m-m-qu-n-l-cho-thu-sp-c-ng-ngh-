namespace Demo
{
    partial class ucQLKhachHang
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
            this.txtQLKH_Ten = new DevExpress.XtraEditors.TextEdit();
            this.lbCMND = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQLKH_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txtQLKH_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nvbrctrControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navbargrQLKhachHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarQLKH_Sua = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLKH_Luu = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLKH_Xoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLKH_Thoat = new DevExpress.XtraNavBar.NavBarItem();
            this.txtQLKH_CMND = new DevExpress.XtraEditors.TextEdit();
<<<<<<< HEAD
            this.gridctrl_QLKH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridcln_CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcln_HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcln_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIenThoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
=======
            this.grctrControlCustommer = new DevExpress.XtraGrid.GridControl();
            this.grvwControlCustommer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grctrInfor = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
>>>>>>> origin/master
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvbrctrControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_CMND.Properties)).BeginInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.gridctrl_QLKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.grctrControlCustommer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvwControlCustommer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrInfor)).BeginInit();
            this.grctrInfor.SuspendLayout();
>>>>>>> origin/master
            this.SuspendLayout();
            // 
            // txtQLKH_Ten
            // 
            this.txtQLKH_Ten.Location = new System.Drawing.Point(22, 98);
            this.txtQLKH_Ten.Name = "txtQLKH_Ten";
            this.txtQLKH_Ten.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_Ten.TabIndex = 1;
            this.txtQLKH_Ten.EditValueChanged += new System.EventHandler(this.txtTenKhachHang_EditValueChanged);
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(19, 36);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(138, 13);
            this.lbCMND.TabIndex = 2;
            this.lbCMND.Text = "Nhập chứng minh nhân dân";
            this.lbCMND.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên khách  hàng";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQLKH_SDT
            // 
            this.txtQLKH_SDT.Location = new System.Drawing.Point(22, 137);
            this.txtQLKH_SDT.Name = "txtQLKH_SDT";
            this.txtQLKH_SDT.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_SDT.TabIndex = 1;
            this.txtQLKH_SDT.EditValueChanged += new System.EventHandler(this.txtSoDT_EditValueChanged);
            // 
            // txtQLKH_DiaChi
            // 
            this.txtQLKH_DiaChi.Location = new System.Drawing.Point(22, 180);
            this.txtQLKH_DiaChi.Name = "txtQLKH_DiaChi";
            this.txtQLKH_DiaChi.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_DiaChi.TabIndex = 1;
            this.txtQLKH_DiaChi.EditValueChanged += new System.EventHandler(this.txtDiaChi_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập địa chỉ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập số điện thoại";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // nvbrctrControl
            // 
            this.nvbrctrControl.ActiveGroup = this.navbargrQLKhachHang;
            this.nvbrctrControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvbrctrControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbargrQLKhachHang});
            this.nvbrctrControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarQLKH_Sua,
            this.navbarQLKH_Luu,
            this.navbarQLKH_Xoa,
            this.navbarQLKH_Thoat});
            this.nvbrctrControl.Location = new System.Drawing.Point(0, 0);
            this.nvbrctrControl.Name = "nvbrctrControl";
            this.nvbrctrControl.OptionsNavPane.ExpandedWidth = 144;
            this.nvbrctrControl.Size = new System.Drawing.Size(144, 481);
            this.nvbrctrControl.TabIndex = 4;
            this.nvbrctrControl.Text = "navBarControl1";
            this.nvbrctrControl.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navbargrQLKhachHang
            // 
            this.navbargrQLKhachHang.Caption = "Quản lý khách hàng";
            this.navbargrQLKhachHang.Expanded = true;
            this.navbargrQLKhachHang.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLKH_Sua),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLKH_Luu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLKH_Xoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarQLKH_Thoat)});
            this.navbargrQLKhachHang.Name = "navbargrQLKhachHang";
            // 
            // navbarQLKH_Sua
            // 
            this.navbarQLKH_Sua.Caption = "Sửa thông tin";
            this.navbarQLKH_Sua.Name = "navbarQLKH_Sua";
            // 
            // navbarQLKH_Luu
            // 
            this.navbarQLKH_Luu.Caption = "Lưu thông tin";
            this.navbarQLKH_Luu.Name = "navbarQLKH_Luu";
            // 
            // navbarQLKH_Xoa
            // 
            this.navbarQLKH_Xoa.Caption = "Xóa khách hàng";
            this.navbarQLKH_Xoa.Name = "navbarQLKH_Xoa";
            // 
            // navbarQLKH_Thoat
            // 
            this.navbarQLKH_Thoat.Caption = "Thoát";
            this.navbarQLKH_Thoat.Name = "navbarQLKH_Thoat";
            // 
            // txtQLKH_CMND
            // 
            this.txtQLKH_CMND.Location = new System.Drawing.Point(22, 52);
            this.txtQLKH_CMND.Name = "txtQLKH_CMND";
            this.txtQLKH_CMND.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_CMND.TabIndex = 5;
            // 
<<<<<<< HEAD
            // gridctrl_QLKH
            // 
            this.gridctrl_QLKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridctrl_QLKH.Location = new System.Drawing.Point(131, 253);
            this.gridctrl_QLKH.MainView = this.gridView1;
            this.gridctrl_QLKH.Name = "gridctrl_QLKH";
            this.gridctrl_QLKH.Size = new System.Drawing.Size(459, 228);
            this.gridctrl_QLKH.TabIndex = 6;
            this.gridctrl_QLKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridctrl_QLKH.Click += new System.EventHandler(this.gridctrl_QLKH_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridcln_CMND,
            this.gridcln_HoTen,
            this.gridcln_DiaChi,
            this.DIenThoaiKH});
            this.gridView1.GridControl = this.gridctrl_QLKH;
            this.gridView1.Name = "gridView1";
=======
            // grctrControlCustommer
            // 
            this.grctrControlCustommer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grctrControlCustommer.Location = new System.Drawing.Point(144, 206);
            this.grctrControlCustommer.MainView = this.grvwControlCustommer;
            this.grctrControlCustommer.Name = "grctrControlCustommer";
            this.grctrControlCustommer.Size = new System.Drawing.Size(446, 275);
            this.grctrControlCustommer.TabIndex = 6;
            this.grctrControlCustommer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvwControlCustommer});
            // 
            // grvwControlCustommer
            // 
            this.grvwControlCustommer.GridControl = this.grctrControlCustommer;
            this.grvwControlCustommer.Name = "grvwControlCustommer";
            // 
            // grctrInfor
            // 
            this.grctrInfor.Controls.Add(this.simpleButton2);
            this.grctrInfor.Controls.Add(this.simpleButton1);
            this.grctrInfor.Controls.Add(this.lbCMND);
            this.grctrInfor.Controls.Add(this.txtQLKH_Ten);
            this.grctrInfor.Controls.Add(this.txtQLKH_CMND);
            this.grctrInfor.Controls.Add(this.txtQLKH_SDT);
            this.grctrInfor.Controls.Add(this.txtQLKH_DiaChi);
            this.grctrInfor.Controls.Add(this.label6);
            this.grctrInfor.Controls.Add(this.label2);
            this.grctrInfor.Controls.Add(this.label5);
            this.grctrInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grctrInfor.Location = new System.Drawing.Point(144, 0);
            this.grctrInfor.Name = "grctrInfor";
            this.grctrInfor.Size = new System.Drawing.Size(446, 209);
            this.grctrInfor.TabIndex = 7;
            this.grctrInfor.Text = "Thông tin";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(266, 50);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 42);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(266, 126);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 42);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "simpleButton2";
>>>>>>> origin/master
            // 
            // gridcln_CMND
            // 
            this.gridcln_CMND.Caption = "CMND";
            this.gridcln_CMND.Name = "gridcln_CMND";
            this.gridcln_CMND.Visible = true;
            this.gridcln_CMND.VisibleIndex = 0;
            // 
            // gridcln_HoTen
            // 
            this.gridcln_HoTen.Caption = "Họ tên";
            this.gridcln_HoTen.Name = "gridcln_HoTen";
            this.gridcln_HoTen.Visible = true;
            this.gridcln_HoTen.VisibleIndex = 1;
            // 
            // gridcln_DiaChi
            // 
            this.gridcln_DiaChi.Caption = "Địa chỉ";
            this.gridcln_DiaChi.Name = "gridcln_DiaChi";
            this.gridcln_DiaChi.Visible = true;
            this.gridcln_DiaChi.VisibleIndex = 2;
            // 
            // DIenThoaiKH
            // 
            this.DIenThoaiKH.Caption = "Số điện thoại";
            this.DIenThoaiKH.Name = "DIenThoaiKH";
            this.DIenThoaiKH.Visible = true;
            this.DIenThoaiKH.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(131, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(459, 220);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thêm khách hàng";
            // 
            // ucQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.Controls.Add(this.gridctrl_QLKH);
            this.Controls.Add(this.txtQLKH_CMND);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.txtQLKH_DiaChi);
            this.Controls.Add(this.txtQLKH_SDT);
            this.Controls.Add(this.txtQLKH_Ten);
            this.Controls.Add(this.groupControl1);
=======
            this.Controls.Add(this.grctrInfor);
            this.Controls.Add(this.grctrControlCustommer);
            this.Controls.Add(this.nvbrctrControl);
>>>>>>> origin/master
            this.Name = "ucQLKhachHang";
            this.Size = new System.Drawing.Size(590, 481);
            this.Load += new System.EventHandler(this.ucQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvbrctrControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_CMND.Properties)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.gridctrl_QLKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.grctrControlCustommer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvwControlCustommer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrInfor)).EndInit();
            this.grctrInfor.ResumeLayout(false);
            this.grctrInfor.PerformLayout();
>>>>>>> origin/master
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtQLKH_Ten;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtQLKH_SDT;
        private DevExpress.XtraEditors.TextEdit txtQLKH_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraNavBar.NavBarControl nvbrctrControl;
        private DevExpress.XtraNavBar.NavBarGroup navbargrQLKhachHang;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Sua;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Luu;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Xoa;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Thoat;
        private DevExpress.XtraEditors.TextEdit txtQLKH_CMND;
<<<<<<< HEAD
        private DevExpress.XtraGrid.GridControl gridctrl_QLKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridcln_CMND;
        private DevExpress.XtraGrid.Columns.GridColumn gridcln_HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn gridcln_DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DIenThoaiKH;
=======
        private DevExpress.XtraGrid.GridControl grctrControlCustommer;
        private DevExpress.XtraGrid.Views.Grid.GridView grvwControlCustommer;
        private DevExpress.XtraEditors.GroupControl grctrInfor;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
>>>>>>> origin/master
    }
}
