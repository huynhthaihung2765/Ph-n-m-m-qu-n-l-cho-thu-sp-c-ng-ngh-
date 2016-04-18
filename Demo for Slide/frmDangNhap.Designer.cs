namespace Demo
{
    partial class frmDangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lbDNTaiKhoan = new System.Windows.Forms.Label();
            this.lbDNMatKhau = new System.Windows.Forms.Label();
            this.txtDNTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtDNMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.lbDNQuenMatKhau = new System.Windows.Forms.Label();
            this.grcntrDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.picSeePass = new DevExpress.XtraEditors.PictureEdit();
            this.picChange2 = new DevExpress.XtraEditors.PictureEdit();
            this.picChange1 = new DevExpress.XtraEditors.PictureEdit();
            this.btMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.btExit = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcntrDangNhap)).BeginInit();
            this.grcntrDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDNTaiKhoan
            // 
            this.lbDNTaiKhoan.AutoSize = true;
            this.lbDNTaiKhoan.Location = new System.Drawing.Point(5, 51);
            this.lbDNTaiKhoan.Name = "lbDNTaiKhoan";
            this.lbDNTaiKhoan.Size = new System.Drawing.Size(53, 13);
            this.lbDNTaiKhoan.TabIndex = 0;
            this.lbDNTaiKhoan.Text = "Tài khoản";
            // 
            // lbDNMatKhau
            // 
            this.lbDNMatKhau.AutoSize = true;
            this.lbDNMatKhau.Location = new System.Drawing.Point(146, 47);
            this.lbDNMatKhau.Name = "lbDNMatKhau";
            this.lbDNMatKhau.Size = new System.Drawing.Size(51, 13);
            this.lbDNMatKhau.TabIndex = 0;
            this.lbDNMatKhau.Text = "Mật khẩu";
            // 
            // txtDNTaiKhoan
            // 
            this.txtDNTaiKhoan.Location = new System.Drawing.Point(5, 66);
            this.txtDNTaiKhoan.Name = "txtDNTaiKhoan";
            this.txtDNTaiKhoan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDNTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.txtDNTaiKhoan.Size = new System.Drawing.Size(115, 20);
            this.txtDNTaiKhoan.TabIndex = 1;
            this.txtDNTaiKhoan.EditValueChanged += new System.EventHandler(this.txtDNTaiKhoan_EditValueChanged);
            this.txtDNTaiKhoan.Leave += new System.EventHandler(this.txtDNTaiKhoan_Leave);
            // 
            // txtDNMatKhau
            // 
            this.txtDNMatKhau.Location = new System.Drawing.Point(149, 66);
            this.txtDNMatKhau.Name = "txtDNMatKhau";
            this.txtDNMatKhau.Properties.PasswordChar = '*';
            this.txtDNMatKhau.Properties.Enter += new System.EventHandler(this.txtDNMatKhau_Properties_Enter);
            this.txtDNMatKhau.Properties.Leave += new System.EventHandler(this.txtDNMatKhau_Properties_Leave);
            this.txtDNMatKhau.Size = new System.Drawing.Size(108, 20);
            this.txtDNMatKhau.TabIndex = 2;
            this.txtDNMatKhau.Enter += new System.EventHandler(this.txtDNMatKhau_Enter);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btDangNhap.Appearance.Options.UseFont = true;
            this.btDangNhap.Appearance.Options.UseForeColor = true;
            this.btDangNhap.Location = new System.Drawing.Point(184, 92);
            this.btDangNhap.LookAndFeel.SkinName = "Dark Side";
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(111, 39);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbDNQuenMatKhau
            // 
            this.lbDNQuenMatKhau.AutoSize = true;
            this.lbDNQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDNQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbDNQuenMatKhau.Location = new System.Drawing.Point(35, 92);
            this.lbDNQuenMatKhau.Name = "lbDNQuenMatKhau";
            this.lbDNQuenMatKhau.Size = new System.Drawing.Size(85, 13);
            this.lbDNQuenMatKhau.TabIndex = 0;
            this.lbDNQuenMatKhau.Text = "Quên mật khẩu?";
            this.lbDNQuenMatKhau.Click += new System.EventHandler(this.lbDNQuenMatKhau_Click);
            // 
            // grcntrDangNhap
            // 
            this.grcntrDangNhap.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grcntrDangNhap.CaptionImage")));
            this.grcntrDangNhap.Controls.Add(this.picNhanVien);
            this.grcntrDangNhap.Controls.Add(this.picSeePass);
            this.grcntrDangNhap.Controls.Add(this.picChange2);
            this.grcntrDangNhap.Controls.Add(this.picChange1);
            this.grcntrDangNhap.Controls.Add(this.btMinimize);
            this.grcntrDangNhap.Controls.Add(this.btExit);
            this.grcntrDangNhap.Controls.Add(this.lbDNTaiKhoan);
            this.grcntrDangNhap.Controls.Add(this.btDangNhap);
            this.grcntrDangNhap.Controls.Add(this.lbDNQuenMatKhau);
            this.grcntrDangNhap.Controls.Add(this.txtDNMatKhau);
            this.grcntrDangNhap.Controls.Add(this.lbDNMatKhau);
            this.grcntrDangNhap.Controls.Add(this.txtDNTaiKhoan);
            this.grcntrDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcntrDangNhap.Location = new System.Drawing.Point(0, 0);
            this.grcntrDangNhap.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.grcntrDangNhap.LookAndFeel.SkinName = "Valentine";
            this.grcntrDangNhap.Name = "grcntrDangNhap";
            this.grcntrDangNhap.Size = new System.Drawing.Size(316, 432);
            this.grcntrDangNhap.TabIndex = 0;
            this.grcntrDangNhap.Text = "Đăng nhập";
            this.grcntrDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.grcntrDangNhap_Paint);
            // 
            // picSeePass
            // 
            this.picSeePass.EditValue = ((object)(resources.GetObject("picSeePass.EditValue")));
            this.picSeePass.Location = new System.Drawing.Point(254, 62);
            this.picSeePass.Name = "picSeePass";
            this.picSeePass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picSeePass.Properties.Appearance.Options.UseBackColor = true;
            this.picSeePass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picSeePass.Properties.MouseHover += new System.EventHandler(this.pictureEdit1_Properties_MouseHover);
            this.picSeePass.Properties.MouseLeave += new System.EventHandler(this.pictureEdit1_Properties_MouseLeave);
            this.picSeePass.Size = new System.Drawing.Size(27, 27);
            this.picSeePass.TabIndex = 9;
            this.picSeePass.MouseHover += new System.EventHandler(this.picSeePass_MouseHover);
            // 
            // picChange2
            // 
            this.picChange2.Location = new System.Drawing.Point(287, 62);
            this.picChange2.Name = "picChange2";
            this.picChange2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picChange2.Properties.Appearance.Options.UseBackColor = true;
            this.picChange2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChange2.Size = new System.Drawing.Size(24, 27);
            this.picChange2.TabIndex = 8;
            // 
            // picChange1
            // 
            this.picChange1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picChange1.Location = new System.Drawing.Point(121, 62);
            this.picChange1.Name = "picChange1";
            this.picChange1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picChange1.Properties.Appearance.Options.UseBackColor = true;
            this.picChange1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChange1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("picChange1.Properties.InitialImage")));
            this.picChange1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picChange1.Size = new System.Drawing.Size(24, 27);
            this.picChange1.TabIndex = 7;
            // 
            // btMinimize
            // 
            this.btMinimize.Location = new System.Drawing.Point(195, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(62, 18);
            this.btMinimize.TabIndex = 4;
            this.btMinimize.Text = "Thu nhỏ";
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click_1);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(256, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(56, 18);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("fullstackedsplinearea_32x32.png", "images/chart/fullstackedsplinearea_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/fullstackedsplinearea_32x32.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "fullstackedsplinearea_32x32.png");
            this.imageCollection.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "apply_16x16.png");
            this.imageCollection.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "cancel_16x16.png");
            // 
            // picNhanVien
            // 
            this.picNhanVien.Location = new System.Drawing.Point(12, 140);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(292, 280);
            this.picNhanVien.TabIndex = 10;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.picNhanVien_Paint_1);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 432);
            this.Controls.Add(this.grcntrDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDNTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcntrDangNhap)).EndInit();
            this.grcntrDangNhap.ResumeLayout(false);
            this.grcntrDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDNTaiKhoan;
        private System.Windows.Forms.Label lbDNMatKhau;
        private DevExpress.XtraEditors.TextEdit txtDNTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtDNMatKhau;
        private DevExpress.XtraEditors.SimpleButton btDangNhap;
        private System.Windows.Forms.Label lbDNQuenMatKhau;
        private DevExpress.XtraEditors.GroupControl grcntrDangNhap;
        private DevExpress.XtraEditors.SimpleButton btExit;
        private DevExpress.XtraEditors.SimpleButton btMinimize;
        private DevExpress.XtraEditors.PictureEdit picChange1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.PictureEdit picChange2;
        private DevExpress.XtraEditors.PictureEdit picSeePass;
        private System.Windows.Forms.PictureBox picNhanVien;
    }
}