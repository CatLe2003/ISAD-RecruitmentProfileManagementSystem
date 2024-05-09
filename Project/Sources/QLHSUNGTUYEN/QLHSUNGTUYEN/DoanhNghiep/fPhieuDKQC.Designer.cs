namespace QLHSUNGTUYEN
{
    partial class fPhieuDKQC
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
            this.lblKeyword = new System.Windows.Forms.Label();
            this.cbbMaDT = new System.Windows.Forms.ComboBox();
            this.cbbMaHT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaHDong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblNgaylap = new System.Windows.Forms.Label();
            this.mtbNgayLap = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(39, 87);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(136, 25);
            this.lblKeyword.TabIndex = 10;
            this.lblKeyword.Text = "Mã đăng tuyển:";
            // 
            // cbbMaDT
            // 
            this.cbbMaDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaDT.FormattingEnabled = true;
            this.cbbMaDT.Location = new System.Drawing.Point(190, 85);
            this.cbbMaDT.Name = "cbbMaDT";
            this.cbbMaDT.Size = new System.Drawing.Size(314, 31);
            this.cbbMaDT.TabIndex = 32;
            // 
            // cbbMaHT
            // 
            this.cbbMaHT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaHT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaHT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHT.FormattingEnabled = true;
            this.cbbMaHT.Location = new System.Drawing.Point(190, 40);
            this.cbbMaHT.Name = "cbbMaHT";
            this.cbbMaHT.Size = new System.Drawing.Size(314, 31);
            this.cbbMaHT.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hình thức:";
            // 
            // cbbMaHDong
            // 
            this.cbbMaHDong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaHDong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaHDong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHDong.FormattingEnabled = true;
            this.cbbMaHDong.Location = new System.Drawing.Point(190, 130);
            this.cbbMaHDong.Name = "cbbMaHDong";
            this.cbbMaHDong.Size = new System.Drawing.Size(314, 31);
            this.cbbMaHDong.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã hợp đồng:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(190, 226);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 33);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(308, 226);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 33);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblNgaylap
            // 
            this.lblNgaylap.AutoSize = true;
            this.lblNgaylap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaylap.Location = new System.Drawing.Point(39, 177);
            this.lblNgaylap.Name = "lblNgaylap";
            this.lblNgaylap.Size = new System.Drawing.Size(87, 25);
            this.lblNgaylap.TabIndex = 39;
            this.lblNgaylap.Text = "Ngày lập:";
            // 
            // mtbNgayLap
            // 
            this.mtbNgayLap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNgayLap.Location = new System.Drawing.Point(190, 175);
            this.mtbNgayLap.Mask = "00/00/0000";
            this.mtbNgayLap.Name = "mtbNgayLap";
            this.mtbNgayLap.Size = new System.Drawing.Size(167, 30);
            this.mtbNgayLap.TabIndex = 41;
            this.mtbNgayLap.ValidatingType = typeof(System.DateTime);
            // 
            // fPhieuDKQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 302);
            this.Controls.Add(this.mtbNgayLap);
            this.Controls.Add(this.lblNgaylap);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbbMaHDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMaHT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMaDT);
            this.Controls.Add(this.lblKeyword);
            this.Name = "fPhieuDKQC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fThemPhieuDKQC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.ComboBox cbbMaDT;
        private System.Windows.Forms.ComboBox cbbMaHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaHDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblNgaylap;
        private System.Windows.Forms.MaskedTextBox mtbNgayLap;
    }
}