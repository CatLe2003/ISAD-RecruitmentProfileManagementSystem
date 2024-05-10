namespace QLHSUNGTUYEN.NhanVien
{
    partial class fGhiNhanTVUV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.lblIDUser = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSPhieuUV = new System.Windows.Forms.DataGridView();
            this.txtNgaylap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioInvalid = new System.Windows.Forms.RadioButton();
            this.radioValid = new System.Windows.Forms.RadioButton();
            this.radioPending = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuUV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHIẾU ĐĂNG KÝ THÀNH VIÊN CỦA ỨNG VIÊN";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(305, 57);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(313, 31);
            this.txtKeyword.TabIndex = 12;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(196, 62);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(80, 25);
            this.lblKeyword.TabIndex = 11;
            this.lblKeyword.Text = "Từ khóa:";
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRecord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(360, 484);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(99, 33);
            this.btnRecord.TabIndex = 45;
            this.btnRecord.Text = "Ghi";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(498, 484);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 33);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMaphieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphieu.Location = new System.Drawing.Point(140, 381);
            this.txtMaphieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(165, 31);
            this.txtMaphieu.TabIndex = 43;
            // 
            // lblIDUser
            // 
            this.lblIDUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIDUser.AutoSize = true;
            this.lblIDUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUser.Location = new System.Drawing.Point(32, 387);
            this.lblIDUser.Name = "lblIDUser";
            this.lblIDUser.Size = new System.Drawing.Size(90, 25);
            this.lblIDUser.TabIndex = 42;
            this.lblIDUser.Text = "Mã phiếu:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(661, 57);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 33);
            this.btnTim.TabIndex = 39;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(140, 435);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 31);
            this.txtID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID:";
            // 
            // dgvDSPhieuUV
            // 
            this.dgvDSPhieuUV.AllowUserToAddRows = false;
            this.dgvDSPhieuUV.AllowUserToDeleteRows = false;
            this.dgvDSPhieuUV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPhieuUV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhieuUV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuUV.Location = new System.Drawing.Point(-3, 110);
            this.dgvDSPhieuUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSPhieuUV.MultiSelect = false;
            this.dgvDSPhieuUV.Name = "dgvDSPhieuUV";
            this.dgvDSPhieuUV.ReadOnly = true;
            this.dgvDSPhieuUV.RowHeadersWidth = 51;
            this.dgvDSPhieuUV.RowTemplate.Height = 24;
            this.dgvDSPhieuUV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhieuUV.Size = new System.Drawing.Size(979, 254);
            this.dgvDSPhieuUV.TabIndex = 36;
            this.dgvDSPhieuUV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuUV_CellClick);
            this.dgvDSPhieuUV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuUV_CellContentDoubleClick);
            this.dgvDSPhieuUV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuUV_CellDoubleClick);
            // 
            // txtNgaylap
            // 
            this.txtNgaylap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNgaylap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaylap.Location = new System.Drawing.Point(498, 381);
            this.txtNgaylap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaylap.Name = "txtNgaylap";
            this.txtNgaylap.Size = new System.Drawing.Size(197, 31);
            this.txtNgaylap.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày lập:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(498, 432);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(197, 31);
            this.txtMaNV.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã NV xét duyệt:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(770, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Trạng thái:";
            // 
            // radioInvalid
            // 
            this.radioInvalid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioInvalid.AutoSize = true;
            this.radioInvalid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInvalid.Location = new System.Drawing.Point(855, 413);
            this.radioInvalid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioInvalid.Name = "radioInvalid";
            this.radioInvalid.Size = new System.Drawing.Size(81, 27);
            this.radioInvalid.TabIndex = 52;
            this.radioInvalid.TabStop = true;
            this.radioInvalid.Text = "Invalid";
            this.radioInvalid.UseVisualStyleBackColor = true;
            // 
            // radioValid
            // 
            this.radioValid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioValid.AutoSize = true;
            this.radioValid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioValid.Location = new System.Drawing.Point(775, 413);
            this.radioValid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioValid.Name = "radioValid";
            this.radioValid.Size = new System.Drawing.Size(68, 27);
            this.radioValid.TabIndex = 51;
            this.radioValid.TabStop = true;
            this.radioValid.Text = "Valid";
            this.radioValid.UseVisualStyleBackColor = true;
            // 
            // radioPending
            // 
            this.radioPending.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioPending.AutoSize = true;
            this.radioPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPending.Location = new System.Drawing.Point(800, 441);
            this.radioPending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPending.Name = "radioPending";
            this.radioPending.Size = new System.Drawing.Size(93, 27);
            this.radioPending.TabIndex = 53;
            this.radioPending.TabStop = true;
            this.radioPending.Text = "Pending";
            this.radioPending.UseVisualStyleBackColor = true;
            // 
            // fGhiNhanTVUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 542);
            this.Controls.Add(this.radioPending);
            this.Controls.Add(this.radioInvalid);
            this.Controls.Add(this.radioValid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgaylap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.lblIDUser);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSPhieuUV);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fGhiNhanTVUV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGhiNhanTVUV";
            this.Load += new System.EventHandler(this.fGhiNhanTVUV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label lblIDUser;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSPhieuUV;
        private System.Windows.Forms.TextBox txtNgaylap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioInvalid;
        private System.Windows.Forms.RadioButton radioValid;
        private System.Windows.Forms.RadioButton radioPending;
    }
}