namespace QLHSUNGTUYEN
{
    partial class fDSPhieuDKQC
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
            this.grBoxDSPhieuDKQC = new System.Windows.Forms.GroupBox();
            this.dgvPhieuDKQC = new System.Windows.Forms.DataGridView();
            this.MaHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grBoxDSPhieuDKQC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDKQC)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxDSPhieuDKQC
            // 
            this.grBoxDSPhieuDKQC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDSPhieuDKQC.AutoSize = true;
            this.grBoxDSPhieuDKQC.Controls.Add(this.dgvPhieuDKQC);
            this.grBoxDSPhieuDKQC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDSPhieuDKQC.Location = new System.Drawing.Point(12, -582);
            this.grBoxDSPhieuDKQC.Name = "grBoxDSPhieuDKQC";
            this.grBoxDSPhieuDKQC.Size = new System.Drawing.Size(892, 1106);
            this.grBoxDSPhieuDKQC.TabIndex = 1;
            this.grBoxDSPhieuDKQC.TabStop = false;
            this.grBoxDSPhieuDKQC.Text = "Danh sách phiếu đăng ký quảng cáo";
            // 
            // dgvPhieuDKQC
            // 
            this.dgvPhieuDKQC.AllowUserToAddRows = false;
            this.dgvPhieuDKQC.AllowUserToDeleteRows = false;
            this.dgvPhieuDKQC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuDKQC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDKQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDKQC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHT,
            this.MaDT,
            this.MaHDong,
            this.NgayLap,
            this.btnDelete});
            this.dgvPhieuDKQC.Location = new System.Drawing.Point(3, 703);
            this.dgvPhieuDKQC.MultiSelect = false;
            this.dgvPhieuDKQC.Name = "dgvPhieuDKQC";
            this.dgvPhieuDKQC.ReadOnly = true;
            this.dgvPhieuDKQC.RowHeadersWidth = 51;
            this.dgvPhieuDKQC.RowTemplate.Height = 24;
            this.dgvPhieuDKQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDKQC.Size = new System.Drawing.Size(870, 377);
            this.dgvPhieuDKQC.TabIndex = 0;
            this.dgvPhieuDKQC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDKQC_CellClick);
            this.dgvPhieuDKQC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDKQC_CellDoubleClick);
            // 
            // MaHT
            // 
            this.MaHT.HeaderText = "Mã hình thức";
            this.MaHT.MinimumWidth = 6;
            this.MaHT.Name = "MaHT";
            this.MaHT.ReadOnly = true;
            this.MaHT.Visible = false;
            // 
            // MaDT
            // 
            this.MaDT.HeaderText = "Mã đăng tuyển";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            this.MaDT.Visible = false;
            // 
            // MaHDong
            // 
            this.MaHDong.HeaderText = "Mã hợp đồng";
            this.MaHDong.MinimumWidth = 6;
            this.MaHDong.Name = "MaHDong";
            this.MaHDong.ReadOnly = true;
            this.MaHDong.Visible = false;
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 60F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(109, 22);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(313, 31);
            this.txtKeyword.TabIndex = 9;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(23, 25);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(80, 25);
            this.lblKeyword.TabIndex = 8;
            this.lblKeyword.Text = "Từ khóa:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(438, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 33);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(542, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 33);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fDSPhieuDKQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 536);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grBoxDSPhieuDKQC);
            this.Name = "fDSPhieuDKQC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu đăng ký quảng cáo";
            this.Load += new System.EventHandler(this.fLapPhieuDKQC_Load);
            this.grBoxDSPhieuDKQC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDKQC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxDSPhieuDKQC;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhieuDKQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}