namespace QUANLYDOANVIEN.GUI
{
    partial class PheSoDoan_View
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
            this.comboDotDanhGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupTTPheSoDoan = new System.Windows.Forms.GroupBox();
            this.txtDRL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTenNguoiDanhGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhanXetBiThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTenDVDanhGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupTTPheSoDoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDotDanhGia
            // 
            this.comboDotDanhGia.FormattingEnabled = true;
            this.comboDotDanhGia.Location = new System.Drawing.Point(147, 31);
            this.comboDotDanhGia.Margin = new System.Windows.Forms.Padding(4);
            this.comboDotDanhGia.Name = "comboDotDanhGia";
            this.comboDotDanhGia.Size = new System.Drawing.Size(160, 24);
            this.comboDotDanhGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn đợt đánh giá";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(615, 150);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // groupTTPheSoDoan
            // 
            this.groupTTPheSoDoan.Controls.Add(this.txtXepLoai);
            this.groupTTPheSoDoan.Controls.Add(this.txtDRL);
            this.groupTTPheSoDoan.Controls.Add(this.label6);
            this.groupTTPheSoDoan.Controls.Add(this.lbTenNguoiDanhGia);
            this.groupTTPheSoDoan.Controls.Add(this.label4);
            this.groupTTPheSoDoan.Controls.Add(this.label3);
            this.groupTTPheSoDoan.Controls.Add(this.txtNhanXetBiThu);
            this.groupTTPheSoDoan.Controls.Add(this.label2);
            this.groupTTPheSoDoan.Controls.Add(this.label1);
            this.groupTTPheSoDoan.Controls.Add(this.comboDotDanhGia);
            this.groupTTPheSoDoan.Enabled = false;
            this.groupTTPheSoDoan.Location = new System.Drawing.Point(25, 259);
            this.groupTTPheSoDoan.Name = "groupTTPheSoDoan";
            this.groupTTPheSoDoan.Size = new System.Drawing.Size(615, 208);
            this.groupTTPheSoDoan.TabIndex = 3;
            this.groupTTPheSoDoan.TabStop = false;
            this.groupTTPheSoDoan.Text = "Thông tin Đánh giá";
            // 
            // txtDRL
            // 
            this.txtDRL.Location = new System.Drawing.Point(81, 143);
            this.txtDRL.Name = "txtDRL";
            this.txtDRL.Size = new System.Drawing.Size(82, 22);
            this.txtDRL.TabIndex = 8;
            this.txtDRL.TextChanged += new System.EventHandler(this.txtDRL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "ĐRL";
            // 
            // lbTenNguoiDanhGia
            // 
            this.lbTenNguoiDanhGia.AutoSize = true;
            this.lbTenNguoiDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiDanhGia.Location = new System.Drawing.Point(450, 140);
            this.lbTenNguoiDanhGia.Name = "lbTenNguoiDanhGia";
            this.lbTenNguoiDanhGia.Size = new System.Drawing.Size(136, 17);
            this.lbTenNguoiDanhGia.TabIndex = 5;
            this.lbTenNguoiDanhGia.Text = "  lbNguoiDanhGia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Người đánh giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xếp loại";
            // 
            // txtNhanXetBiThu
            // 
            this.txtNhanXetBiThu.Location = new System.Drawing.Point(11, 83);
            this.txtNhanXetBiThu.Multiline = true;
            this.txtNhanXetBiThu.Name = "txtNhanXetBiThu";
            this.txtNhanXetBiThu.Size = new System.Drawing.Size(592, 49);
            this.txtNhanXetBiThu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhận xếp Bí thư";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đoàn viên";
            // 
            // lbTenDVDanhGia
            // 
            this.lbTenDVDanhGia.AutoSize = true;
            this.lbTenDVDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDVDanhGia.Location = new System.Drawing.Point(119, 183);
            this.lbTenDVDanhGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenDVDanhGia.Name = "lbTenDVDanhGia";
            this.lbTenDVDanhGia.Size = new System.Drawing.Size(59, 17);
            this.lbTenDVDanhGia.TabIndex = 5;
            this.lbTenDVDanhGia.Text = "lbCoSo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cơ sở";
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoSo.Location = new System.Drawing.Point(343, 183);
            this.lbCoSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(59, 17);
            this.lbCoSo.TabIndex = 7;
            this.lbCoSo.Text = "lbCoSo";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(125, 215);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(228, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 29);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(25, 215);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 29);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(81, 168);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.ReadOnly = true;
            this.txtXepLoai.Size = new System.Drawing.Size(82, 22);
            this.txtXepLoai.TabIndex = 9;
            // 
            // PheSoDoan_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 479);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbCoSo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTenDVDanhGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupTTPheSoDoan);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PheSoDoan_View";
            this.Text = "Phê sổ đoàn";
            this.Load += new System.EventHandler(this.PheSoDoan_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupTTPheSoDoan.ResumeLayout(false);
            this.groupTTPheSoDoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDotDanhGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupTTPheSoDoan;
        private System.Windows.Forms.Label lbTenNguoiDanhGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhanXetBiThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTenDVDanhGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCoSo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDRL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXepLoai;
    }
}