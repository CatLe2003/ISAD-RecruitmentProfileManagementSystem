namespace QLHSUNGTUYEN.NhanVien
{
    partial class fMain_NV
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuDKQCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhNghiệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.HopDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1095, 34);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieuDKQCToolStripMenuItem,
            this.HopDongToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // phieuDKQCToolStripMenuItem
            // 
            this.phieuDKQCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhNghiệpToolStripMenuItem,
            this.UVToolStripMenuItem});
            this.phieuDKQCToolStripMenuItem.Name = "phieuDKQCToolStripMenuItem";
            this.phieuDKQCToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.phieuDKQCToolStripMenuItem.Text = "Phiếu đăng ký TV";
            // 
            // doanhNghiệpToolStripMenuItem
            // 
            this.doanhNghiệpToolStripMenuItem.Name = "doanhNghiệpToolStripMenuItem";
            this.doanhNghiệpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.doanhNghiệpToolStripMenuItem.Text = "Doanh nghiệp";
            // 
            // UVToolStripMenuItem
            // 
            this.UVToolStripMenuItem.Name = "UVToolStripMenuItem";
            this.UVToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.UVToolStripMenuItem.Text = "Ứng viên";
            this.UVToolStripMenuItem.Click += new System.EventHandler(this.UVToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1095, 689);
            this.pnlContent.TabIndex = 3;
            // 
            // HopDongToolStripMenuItem
            // 
            this.HopDongToolStripMenuItem.Name = "HopDongToolStripMenuItem";
            this.HopDongToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.HopDongToolStripMenuItem.Text = "Hợp đồng ";
            this.HopDongToolStripMenuItem.Click += new System.EventHandler(this.HopDongToolStripMenuItem_Click);
            // 
            // fMain_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 689);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fMain_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain_NV";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuDKQCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhNghiệpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UVToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem HopDongToolStripMenuItem;
    }
}