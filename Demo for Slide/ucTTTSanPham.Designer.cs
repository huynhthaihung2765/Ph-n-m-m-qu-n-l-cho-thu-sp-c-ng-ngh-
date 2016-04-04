namespace Demo
{
    partial class ucTTTSanPham
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
            this.navbargrTTT = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarTTT_Laptop = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarTTT_Loa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarTTT_MayChieu = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarTTT_PhuKien = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navbargrTTT;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbargrTTT});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarTTT_Laptop,
            this.navbarTTT_Loa,
            this.navbarTTT_MayChieu,
            this.navbarTTT_PhuKien});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(140, 525);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navbargrTTT
            // 
            this.navbargrTTT.Caption = "Sản phẩm cần thuê";
            this.navbargrTTT.Expanded = true;
            this.navbargrTTT.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarTTT_Laptop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarTTT_Loa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarTTT_MayChieu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarTTT_PhuKien)});
            this.navbargrTTT.Name = "navbargrTTT";
            // 
            // navbarTTT_Laptop
            // 
            this.navbarTTT_Laptop.Caption = "Laptop";
            this.navbarTTT_Laptop.Name = "navbarTTT_Laptop";
            // 
            // navbarTTT_Loa
            // 
            this.navbarTTT_Loa.Caption = "Loa, âm thanh";
            this.navbarTTT_Loa.Name = "navbarTTT_Loa";
            // 
            // navbarTTT_MayChieu
            // 
            this.navbarTTT_MayChieu.Caption = "Máy chiếu";
            this.navbarTTT_MayChieu.Name = "navbarTTT_MayChieu";
            // 
            // navbarTTT_PhuKien
            // 
            this.navbarTTT_PhuKien.Caption = "Phụ kiện";
            this.navbarTTT_PhuKien.Name = "navbarTTT_PhuKien";
            // 
            // ucTTTSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navBarControl1);
            this.Name = "ucTTTSanPham";
            this.Size = new System.Drawing.Size(835, 525);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navbargrTTT;
        private DevExpress.XtraNavBar.NavBarItem navbarTTT_Laptop;
        private DevExpress.XtraNavBar.NavBarItem navbarTTT_Loa;
        private DevExpress.XtraNavBar.NavBarItem navbarTTT_MayChieu;
        private DevExpress.XtraNavBar.NavBarItem navbarTTT_PhuKien;
    }
}
