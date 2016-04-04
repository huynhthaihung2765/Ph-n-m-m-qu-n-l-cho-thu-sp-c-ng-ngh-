namespace Demo
{
    partial class ucTTTBienBanThue
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
            this.rptTTT_BienBan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptTTT_BienBan
            // 
            this.rptTTT_BienBan.Location = new System.Drawing.Point(122, 47);
            this.rptTTT_BienBan.Name = "rptTTT_BienBan";
            this.rptTTT_BienBan.Size = new System.Drawing.Size(546, 361);
            this.rptTTT_BienBan.TabIndex = 0;
            // 
            // ucTTTBienBanThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rptTTT_BienBan);
            this.Name = "ucTTTBienBanThue";
            this.Size = new System.Drawing.Size(829, 523);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptTTT_BienBan;
    }
}
