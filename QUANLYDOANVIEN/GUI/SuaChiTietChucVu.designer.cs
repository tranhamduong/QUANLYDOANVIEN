namespace QUANLYDOANVIEN.BUS
{
    partial class SuaChiTietChucVu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCap = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTenDoanVien = new System.Windows.Forms.Label();
            this.lblMaDoanVien = new System.Windows.Forms.Label();
            this.lblChiDoan = new System.Windows.Forms.Label();
            this.lblDoanKhoa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.cbbNhiemKy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đoàn Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đoàn Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi Đoàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đoàn Khoa :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức Vụ :";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(157, 261);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(441, 28);
            this.cbbChucVu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cấp :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCap
            // 
            this.cbbCap.FormattingEnabled = true;
            this.cbbCap.Location = new System.Drawing.Point(157, 217);
            this.cbbCap.Name = "cbbCap";
            this.cbbCap.Size = new System.Drawing.Size(116, 28);
            this.cbbCap.TabIndex = 7;
            this.cbbCap.SelectionChangeCommitted += new System.EventHandler(this.cbbCap_SelectionChangeCommitted);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(168, 430);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 56);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(350, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 56);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblTenDoanVien
            // 
            this.lblTenDoanVien.AutoSize = true;
            this.lblTenDoanVien.Location = new System.Drawing.Point(180, 55);
            this.lblTenDoanVien.Name = "lblTenDoanVien";
            this.lblTenDoanVien.Size = new System.Drawing.Size(0, 20);
            this.lblTenDoanVien.TabIndex = 10;
            // 
            // lblMaDoanVien
            // 
            this.lblMaDoanVien.AutoSize = true;
            this.lblMaDoanVien.Location = new System.Drawing.Point(180, 99);
            this.lblMaDoanVien.Name = "lblMaDoanVien";
            this.lblMaDoanVien.Size = new System.Drawing.Size(0, 20);
            this.lblMaDoanVien.TabIndex = 11;
            // 
            // lblChiDoan
            // 
            this.lblChiDoan.AutoSize = true;
            this.lblChiDoan.Location = new System.Drawing.Point(180, 142);
            this.lblChiDoan.Name = "lblChiDoan";
            this.lblChiDoan.Size = new System.Drawing.Size(0, 20);
            this.lblChiDoan.TabIndex = 12;
            // 
            // lblDoanKhoa
            // 
            this.lblDoanKhoa.AutoSize = true;
            this.lblDoanKhoa.Location = new System.Drawing.Point(180, 185);
            this.lblDoanKhoa.Name = "lblDoanKhoa";
            this.lblDoanKhoa.Size = new System.Drawing.Size(0, 20);
            this.lblDoanKhoa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nhiệm Kì :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày Bắt Đầu :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày Kết Thúc :";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(157, 306);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(441, 26);
            this.dtpNgayBatDau.TabIndex = 17;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(157, 351);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(441, 26);
            this.dtpNgayKetThuc.TabIndex = 18;
            // 
            // cbbNhiemKy
            // 
            this.cbbNhiemKy.FormattingEnabled = true;
            this.cbbNhiemKy.Location = new System.Drawing.Point(157, 396);
            this.cbbNhiemKy.Name = "cbbNhiemKy";
            this.cbbNhiemKy.Size = new System.Drawing.Size(116, 28);
            this.cbbNhiemKy.TabIndex = 19;
            // 
            // SuaChiTietChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 516);
            this.Controls.Add(this.cbbNhiemKy);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDoanKhoa);
            this.Controls.Add(this.lblChiDoan);
            this.Controls.Add(this.lblMaDoanVien);
            this.Controls.Add(this.lblTenDoanVien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbbCap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaChiTietChucVu";
            this.Text = "Sửa Chi Tiết Chức Vụ";
            this.Load += new System.EventHandler(this.SuaChucVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTenDoanVien;
        private System.Windows.Forms.Label lblMaDoanVien;
        private System.Windows.Forms.Label lblChiDoan;
        private System.Windows.Forms.Label lblDoanKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.ComboBox cbbNhiemKy;
    }
}