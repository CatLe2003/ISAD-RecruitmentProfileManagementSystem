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
            this.DNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HopDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(973, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieuDKQCToolStripMenuItem,
            this.HopDongToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // phieuDKQCToolStripMenuItem
            // 
            this.phieuDKQCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DNToolStripMenuItem,
            this.UVToolStripMenuItem});
            this.phieuDKQCToolStripMenuItem.Name = "phieuDKQCToolStripMenuItem";
            this.phieuDKQCToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phieuDKQCToolStripMenuItem.Text = "Phiếu đăng ký TV";
            // 
            // DNToolStripMenuItem
            // 
            this.DNToolStripMenuItem.Name = "DNToolStripMenuItem";
            this.DNToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DNToolStripMenuItem.Text = "Doanh nghiệp";
            this.DNToolStripMenuItem.Click += new System.EventHandler(this.DNToolStripMenuItem_Click);
            // 
            // UVToolStripMenuItem
            // 
            this.UVToolStripMenuItem.Name = "UVToolStripMenuItem";
            this.UVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.UVToolStripMenuItem.Text = "Ứng viên";
            this.UVToolStripMenuItem.Click += new System.EventHandler(this.UVToolStripMenuItem_Click);
            // 
            // HopDongToolStripMenuItem
            // 
            this.HopDongToolStripMenuItem.Name = "HopDongToolStripMenuItem";
            this.HopDongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HopDongToolStripMenuItem.Text = "Hợp đồng ";
            this.HopDongToolStripMenuItem.Click += new System.EventHandler(this.HopDongToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 28);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(973, 514);
            this.pnlContent.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(61, 2);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 22);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(818, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 27);
            this.panel2.TabIndex = 7;
            // 
            // fMain_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.fMain_NV_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuDKQCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UVToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem HopDongToolStripMenuItem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel2;
    }
}