using System.Windows.Forms;

namespace QUANLYDOANVIEN.GUI
{
    partial class ThemChiTietChucVu
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
            this.dtvSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenDoanVien = new System.Windows.Forms.Label();
            this.lblMaDoanVien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbChiDoan = new System.Windows.Forms.ComboBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbDoanKhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCap = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayBatĐau = new System.Windows.Forms.DateTimePicker();
            this.tbxNamNhiemKy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvSinhVien
            // 
            this.dtvSinhVien.AllowUserToAddRows = false;
            this.dtvSinhVien.AllowUserToDeleteRows = false;
            this.dtvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSinhVien.Location = new System.Drawing.Point(29, 31);
            this.dtvSinhVien.Name = "dtvSinhVien";
            this.dtvSinhVien.ReadOnly = true;
            this.dtvSinhVien.RowTemplate.Height = 28;
            this.dtvSinhVien.Size = new System.Drawing.Size(1002, 289);
            this.dtvSinhVien.TabIndex = 0;
            this.dtvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvSinhVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đoàn Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đoàn Viên :";
            // 
            // lblTenDoanVien
            // 
            this.lblTenDoanVien.AutoSize = true;
            this.lblTenDoanVien.Location = new System.Drawing.Point(184, 385);
            this.lblTenDoanVien.Name = "lblTenDoanVien";
            this.lblTenDoanVien.Size = new System.Drawing.Size(0, 20);
            this.lblTenDoanVien.TabIndex = 3;
            // 
            // lblMaDoanVien
            // 
            this.lblMaDoanVien.AutoSize = true;
            this.lblMaDoanVien.Location = new System.Drawing.Point(184, 422);
            this.lblMaDoanVien.Name = "lblMaDoanVien";
            this.lblMaDoanVien.Size = new System.Drawing.Size(0, 20);
            this.lblMaDoanVien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chức Vụ :";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(466, 533);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 46);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = " Ngày Bắt Đầu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đoàn Khoa :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chi Đoàn :";
            // 
            // cbbChiDoan
            // 
            this.cbbChiDoan.FormattingEnabled = true;
            this.cbbChiDoan.Location = new System.Drawing.Point(551, 342);
            this.cbbChiDoan.Name = "cbbChiDoan";
            this.cbbChiDoan.Size = new System.Drawing.Size(480, 28);
            this.cbbChiDoan.TabIndex = 16;
            this.cbbChiDoan.SelectionChangeCommitted += new System.EventHandler(this.cbbChiDoan_SelectionChangeCommitted);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(551, 456);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(480, 28);
            this.cbbChucVu.TabIndex = 17;
            // 
            // cbbDoanKhoa
            // 
            this.cbbDoanKhoa.FormattingEnabled = true;
            this.cbbDoanKhoa.Location = new System.Drawing.Point(179, 342);
            this.cbbDoanKhoa.Name = "cbbDoanKhoa";
            this.cbbDoanKhoa.Size = new System.Drawing.Size(274, 28);
            this.cbbDoanKhoa.TabIndex = 18;
            this.cbbDoanKhoa.SelectionChangeCommitted += new System.EventHandler(this.cbbDoanKhoa_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cấp :";
            // 
            // cbbCap
            // 
            this.cbbCap.FormattingEnabled = true;
            this.cbbCap.Location = new System.Drawing.Point(179, 456);
            this.cbbCap.Name = "cbbCap";
            this.cbbCap.Size = new System.Drawing.Size(169, 28);
            this.cbbCap.TabIndex = 20;
            this.cbbCap.SelectionChangeCommitted += new System.EventHandler(this.cbbCap_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nhiệm Kỳ:";
            // 
            // dtpNgayBatĐau
            // 
            this.dtpNgayBatĐau.Location = new System.Drawing.Point(179, 491);
            this.dtpNgayBatĐau.Name = "dtpNgayBatĐau";
            this.dtpNgayBatĐau.Size = new System.Drawing.Size(274, 26);
            this.dtpNgayBatĐau.TabIndex = 23;
            // 
            // tbxNamNhiemKy
            // 
            this.tbxNamNhiemKy.Location = new System.Drawing.Point(551, 490);
            this.tbxNamNhiemKy.Name = "tbxNamNhiemKy";
            this.tbxNamNhiemKy.Size = new System.Drawing.Size(279, 26);
            this.tbxNamNhiemKy.TabIndex = 24;
            // 
            // ThemChiTietChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 600);
            this.Controls.Add(this.tbxNamNhiemKy);
            this.Controls.Add(this.dtpNgayBatĐau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbCap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbDoanKhoa);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.cbbChiDoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaDoanVien);
            this.Controls.Add(this.lblTenDoanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvSinhVien);
            this.Name = "ThemChiTietChucVu";
            this.Text = "Thêm Chi Tiết Chức Vụ";
            this.Load += new System.EventHandler(this.ThemChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenDoanVien;
        private System.Windows.Forms.Label lblMaDoanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbChiDoan;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.ComboBox cbbDoanKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbCap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayBatĐau;
        private System.Windows.Forms.TextBox tbxNamNhiemKy;
    }
}