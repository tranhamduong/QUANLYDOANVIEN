namespace QUANLYDOANVIEN.GUI
{
    partial class ChuyenSinhHoatDoan_View
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
            this.lbNoiChuyenDen = new System.Windows.Forms.Label();
            this.radioCoSoDoanNoiBo = new System.Windows.Forms.RadioButton();
            this.radioCoSoDoanBenNgoai = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTenDoanVien = new System.Windows.Forms.Label();
            this.comboDSDonViChuyenDen = new System.Windows.Forms.ComboBox();
            this.txtDonViChuyenDen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLyDoChuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateThoiGianChuyen = new System.Windows.Forms.DateTimePicker();
            this.lbThoiGianChuyen = new System.Windows.Forms.Label();
            this.lbThongTinCDChuyenDi = new System.Windows.Forms.Label();
            this.lbTTChiDoanChuyenDen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThongTintenDoanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNoiChuyenDen
            // 
            this.lbNoiChuyenDen.AutoSize = true;
            this.lbNoiChuyenDen.Location = new System.Drawing.Point(2, 48);
            this.lbNoiChuyenDen.Name = "lbNoiChuyenDen";
            this.lbNoiChuyenDen.Size = new System.Drawing.Size(107, 17);
            this.lbNoiChuyenDen.TabIndex = 0;
            this.lbNoiChuyenDen.Text = "Nơi chuyển đến";
            // 
            // radioCoSoDoanNoiBo
            // 
            this.radioCoSoDoanNoiBo.AutoSize = true;
            this.radioCoSoDoanNoiBo.Location = new System.Drawing.Point(24, 85);
            this.radioCoSoDoanNoiBo.Name = "radioCoSoDoanNoiBo";
            this.radioCoSoDoanNoiBo.Size = new System.Drawing.Size(147, 21);
            this.radioCoSoDoanNoiBo.TabIndex = 1;
            this.radioCoSoDoanNoiBo.TabStop = true;
            this.radioCoSoDoanNoiBo.Text = "Đơn vị chuyển đến";
            this.radioCoSoDoanNoiBo.UseVisualStyleBackColor = true;
            this.radioCoSoDoanNoiBo.CheckedChanged += new System.EventHandler(this.radioCoSoDoanBenNgoai_CheckedChanged);
            // 
            // radioCoSoDoanBenNgoai
            // 
            this.radioCoSoDoanBenNgoai.AutoSize = true;
            this.radioCoSoDoanBenNgoai.Location = new System.Drawing.Point(24, 112);
            this.radioCoSoDoanBenNgoai.Name = "radioCoSoDoanBenNgoai";
            this.radioCoSoDoanBenNgoai.Size = new System.Drawing.Size(228, 21);
            this.radioCoSoDoanBenNgoai.TabIndex = 2;
            this.radioCoSoDoanBenNgoai.TabStop = true;
            this.radioCoSoDoanBenNgoai.Text = "Đơn vị không có trong hệ thống";
            this.radioCoSoDoanBenNgoai.UseVisualStyleBackColor = true;
            this.radioCoSoDoanBenNgoai.CheckedChanged += new System.EventHandler(this.radioCoSoDoanBenNgoai_CheckedChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(5, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(247, 17);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Chuyển sinh hoạt đoàn cho đoàn viên";
            // 
            // lbTenDoanVien
            // 
            this.lbTenDoanVien.AutoSize = true;
            this.lbTenDoanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDoanVien.Location = new System.Drawing.Point(258, 10);
            this.lbTenDoanVien.Name = "lbTenDoanVien";
            this.lbTenDoanVien.Size = new System.Drawing.Size(290, 18);
            this.lbTenDoanVien.TabIndex = 4;
            this.lbTenDoanVien.Text = "Chuyển sinh hoạt đoàn cho đoàn viên";
            // 
            // comboDSDonViChuyenDen
            // 
            this.comboDSDonViChuyenDen.FormattingEnabled = true;
            this.comboDSDonViChuyenDen.Location = new System.Drawing.Point(261, 85);
            this.comboDSDonViChuyenDen.Name = "comboDSDonViChuyenDen";
            this.comboDSDonViChuyenDen.Size = new System.Drawing.Size(493, 24);
            this.comboDSDonViChuyenDen.TabIndex = 5;
            this.comboDSDonViChuyenDen.SelectedValueChanged += new System.EventHandler(this.comboDSDonViChuyenDen_SelectedValueChanged);
            // 
            // txtDonViChuyenDen
            // 
            this.txtDonViChuyenDen.Location = new System.Drawing.Point(261, 116);
            this.txtDonViChuyenDen.Name = "txtDonViChuyenDen";
            this.txtDonViChuyenDen.Size = new System.Drawing.Size(493, 22);
            this.txtDonViChuyenDen.TabIndex = 6;
            this.txtDonViChuyenDen.TextChanged += new System.EventHandler(this.txtDonViChuyenDen_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLyDoChuyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateThoiGianChuyen);
            this.groupBox1.Controls.Add(this.lbThoiGianChuyen);
            this.groupBox1.Controls.Add(this.lbThongTinCDChuyenDi);
            this.groupBox1.Controls.Add(this.lbTTChiDoanChuyenDen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbThongTintenDoanVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 304);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHUYỂN SINH HOẠT ĐOÀN";
            // 
            // txtLyDoChuyen
            // 
            this.txtLyDoChuyen.Location = new System.Drawing.Point(9, 194);
            this.txtLyDoChuyen.Multiline = true;
            this.txtLyDoChuyen.Name = "txtLyDoChuyen";
            this.txtLyDoChuyen.Size = new System.Drawing.Size(724, 52);
            this.txtLyDoChuyen.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lí do Chuyển";
            // 
            // dateThoiGianChuyen
            // 
            this.dateThoiGianChuyen.Location = new System.Drawing.Point(143, 131);
            this.dateThoiGianChuyen.Name = "dateThoiGianChuyen";
            this.dateThoiGianChuyen.Size = new System.Drawing.Size(287, 22);
            this.dateThoiGianChuyen.TabIndex = 13;
            // 
            // lbThoiGianChuyen
            // 
            this.lbThoiGianChuyen.AutoSize = true;
            this.lbThoiGianChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianChuyen.Location = new System.Drawing.Point(6, 137);
            this.lbThoiGianChuyen.Name = "lbThoiGianChuyen";
            this.lbThoiGianChuyen.Size = new System.Drawing.Size(125, 17);
            this.lbThoiGianChuyen.TabIndex = 12;
            this.lbThoiGianChuyen.Text = "Thời gian chuyển: ";
            // 
            // lbThongTinCDChuyenDi
            // 
            this.lbThongTinCDChuyenDi.AutoSize = true;
            this.lbThongTinCDChuyenDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinCDChuyenDi.Location = new System.Drawing.Point(140, 66);
            this.lbThongTinCDChuyenDi.Name = "lbThongTinCDChuyenDi";
            this.lbThongTinCDChuyenDi.Size = new System.Drawing.Size(290, 18);
            this.lbThongTinCDChuyenDi.TabIndex = 11;
            this.lbThongTinCDChuyenDi.Text = "Chuyển sinh hoạt đoàn cho đoàn viên";
            // 
            // lbTTChiDoanChuyenDen
            // 
            this.lbTTChiDoanChuyenDen.AutoSize = true;
            this.lbTTChiDoanChuyenDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTChiDoanChuyenDen.Location = new System.Drawing.Point(140, 99);
            this.lbTTChiDoanChuyenDen.Name = "lbTTChiDoanChuyenDen";
            this.lbTTChiDoanChuyenDen.Size = new System.Drawing.Size(290, 18);
            this.lbTTChiDoanChuyenDen.TabIndex = 8;
            this.lbTTChiDoanChuyenDen.Text = "Chuyển sinh hoạt đoàn cho đoàn viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị Chuyển đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đơn vị Chuyển đi";
            // 
            // lbThongTintenDoanVien
            // 
            this.lbThongTintenDoanVien.AutoSize = true;
            this.lbThongTintenDoanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTintenDoanVien.Location = new System.Drawing.Point(253, 29);
            this.lbThongTintenDoanVien.Name = "lbThongTintenDoanVien";
            this.lbThongTintenDoanVien.Size = new System.Drawing.Size(13, 18);
            this.lbThongTintenDoanVien.TabIndex = 8;
            this.lbThongTintenDoanVien.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chuyển sinh hoạt đoàn cho đoàn viên";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(554, 411);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(184, 41);
            this.btnXacNhan.TabIndex = 16;
            this.btnXacNhan.Text = "Xác nhận Chuyển";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ChuyenSinhHoatDoan_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDonViChuyenDen);
            this.Controls.Add(this.comboDSDonViChuyenDen);
            this.Controls.Add(this.lbTenDoanVien);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.radioCoSoDoanBenNgoai);
            this.Controls.Add(this.radioCoSoDoanNoiBo);
            this.Controls.Add(this.lbNoiChuyenDen);
            this.Name = "ChuyenSinhHoatDoan_View";
            this.Text = "Chuyển sinh hoạt đoàn viên";
            this.Load += new System.EventHandler(this.ChuyenSinhHoatDoan_View_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoiChuyenDen;
        private System.Windows.Forms.RadioButton radioCoSoDoanNoiBo;
        private System.Windows.Forms.RadioButton radioCoSoDoanBenNgoai;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTenDoanVien;
        private System.Windows.Forms.ComboBox comboDSDonViChuyenDen;
        private System.Windows.Forms.TextBox txtDonViChuyenDen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLyDoChuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateThoiGianChuyen;
        private System.Windows.Forms.Label lbThoiGianChuyen;
        private System.Windows.Forms.Label lbThongTinCDChuyenDi;
        private System.Windows.Forms.Label lbTTChiDoanChuyenDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbThongTintenDoanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
    }
}