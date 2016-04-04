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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbargrQLKhachHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarQLKH_Sua = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLKH_Luu = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLKH_Xoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarQLKH_Thoat = new DevExpress.XtraNavBar.NavBarItem();
            this.txtQLKH_CMND = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQLKH_Ten
            // 
            this.txtQLKH_Ten.Location = new System.Drawing.Point(251, 110);
            this.txtQLKH_Ten.Name = "txtQLKH_Ten";
            this.txtQLKH_Ten.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_Ten.TabIndex = 1;
            this.txtQLKH_Ten.EditValueChanged += new System.EventHandler(this.txtTenKhachHang_EditValueChanged);
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(248, 43);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(139, 13);
            this.lbCMND.TabIndex = 2;
            this.lbCMND.Text = "Nhập chứng minh nhân dân";
            this.lbCMND.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên khách  hàng";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQLKH_SDT
            // 
            this.txtQLKH_SDT.Location = new System.Drawing.Point(251, 149);
            this.txtQLKH_SDT.Name = "txtQLKH_SDT";
            this.txtQLKH_SDT.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_SDT.TabIndex = 1;
            this.txtQLKH_SDT.EditValueChanged += new System.EventHandler(this.txtSoDT_EditValueChanged);
            // 
            // txtQLKH_DiaChi
            // 
            this.txtQLKH_DiaChi.Location = new System.Drawing.Point(251, 192);
            this.txtQLKH_DiaChi.Name = "txtQLKH_DiaChi";
            this.txtQLKH_DiaChi.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_DiaChi.TabIndex = 1;
            this.txtQLKH_DiaChi.EditValueChanged += new System.EventHandler(this.txtDiaChi_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập địa chỉ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập số điện thoại";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navbargrQLKhachHang;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbargrQLKhachHang});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarQLKH_Sua,
            this.navbarQLKH_Luu,
            this.navbarQLKH_Xoa,
            this.navbarQLKH_Thoat});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 131;
            this.navBarControl1.Size = new System.Drawing.Size(131, 481);
            this.navBarControl1.TabIndex = 4;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
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
            this.txtQLKH_CMND.Location = new System.Drawing.Point(251, 59);
            this.txtQLKH_CMND.Name = "txtQLKH_CMND";
            this.txtQLKH_CMND.Size = new System.Drawing.Size(163, 20);
            this.txtQLKH_CMND.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(131, 281);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(459, 200);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ucQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtQLKH_CMND);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.txtQLKH_DiaChi);
            this.Controls.Add(this.txtQLKH_SDT);
            this.Controls.Add(this.txtQLKH_Ten);
            this.Name = "ucQLKhachHang";
            this.Size = new System.Drawing.Size(590, 481);
            this.Load += new System.EventHandler(this.ucQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQLKH_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtQLKH_Ten;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtQLKH_SDT;
        private DevExpress.XtraEditors.TextEdit txtQLKH_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navbargrQLKhachHang;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Sua;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Luu;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Xoa;
        private DevExpress.XtraNavBar.NavBarItem navbarQLKH_Thoat;
        private DevExpress.XtraEditors.TextEdit txtQLKH_CMND;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
