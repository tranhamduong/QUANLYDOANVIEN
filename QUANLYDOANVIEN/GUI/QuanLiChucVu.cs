using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYDOANVIEN.BUS;
using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;

namespace QUANLYDOANVIEN.GUI
{
    public partial class QuanLiChucVu : Form
    {
        private QLDOANVIEN_DATABASE db = new QLDOANVIEN_DATABASE();
        private ChucVuBUS chucVuBUS = new ChucVuBUS();
        private ChiTietChucVuBUS ChiTietChucVuBUS = new ChiTietChucVuBUS();
        private string maChucVu, maChiTiet,cap;

        public QuanLiChucVu()
        {
            InitializeComponent();
        }

        private void QuanLiChucVu_Load(object sender, EventArgs e)
        {
            // Tab Quản lí chức vụ
            // Load Combobox Doan Khoa
            LoadCbbDoanKhoa();
            LoadCbbChiDoan();
            LoadDgvDoanVien();
            PreProcessing();    
        }

        private void PreProcessing()
        {
            dgvDoanVien_CTCV.Columns[0].HeaderText = "Mã Chi Tiết Chức Vụ";
            dgvDoanVien_CTCV.Columns[1].HeaderText = "Mã Đoàn Viên";
            dgvDoanVien_CTCV.Columns[2].HeaderText = "Tên Đoàn Viên";
            dgvDoanVien_CTCV.Columns[3].Visible = false;
            dgvDoanVien_CTCV.Columns[4].Visible = false;
            dgvDoanVien_CTCV.Columns[5].HeaderText = "Chức Vụ";
            dgvDoanVien_CTCV.Columns[6].Visible = false;

            dgvDoanVien_CTCV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDoanVien_CTCV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDoanVien_CTCV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDoanVien_CTCV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void LoadCbbDoanKhoa()
        {
            cbbDoanKhoa_CTCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDoanKhoa_CTCV.DataSource = db.DOANKHOAs.ToList();
            cbbDoanKhoa_CTCV.DisplayMember = "TenDoanKhoa";
            cbbDoanKhoa_CTCV.ValueMember = "MaDoanKhoa";
            cbbDoanKhoa_CTCV.SelectedIndex = 0;
            cbbDoanKhoa_CTCV.Invalidate();
        }

        private void LoadCbbChiDoan()
        {
            cbbChiDoan_CTCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChiDoan_CTCV.DataSource = db.CHIDOANs.Where(p=>p.MaDoanKhoa == cbbDoanKhoa_CTCV.SelectedValue.ToString()).ToList();
            cbbChiDoan_CTCV.DisplayMember = "TenChiDoan";
            cbbChiDoan_CTCV.ValueMember = "MaChiDoan";
            cbbChiDoan_CTCV.SelectedIndex = 0;
            cbbChiDoan_CTCV.Invalidate();
        }

        private void LoadDgvDoanVien()
        {
            if (cbbChiDoan_CTCV.SelectedItem == null) return;
         
            var data = db.DOANVIENs.Join(
               db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true),
               d => d.MaDoanVien,
               f => f.MaDoanVien,
               (d, f) => new { MaChiTiet = f.MaChiTiet, MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan})
               .Where(p => p.MaChiDoan == cbbChiDoan_CTCV.SelectedValue.ToString()).Join(
               db.CHUCVUs.Where(p => p.IsDeleted != true),
               d => d.MaChucVu,
               f => f.MaChucVu,
               (d, f) => new { MaChiTiet = d.MaChiTiet, MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan, ChucVu = f.TenChucVu, Cap = f.Cap}).ToList();
           
            dgvDoanVien_CTCV.DataSource = data;

        }

        private void cbbDoanKhoa_CTCV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var dataChiDoan = db.CHIDOANs.Where(p => p.MaDoanKhoa == cbbDoanKhoa_CTCV.SelectedValue.ToString()).ToList();

            //Load du lieu cbb Chi Doan
            cbbChiDoan_CTCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChiDoan_CTCV.DataSource = dataChiDoan;
            cbbChiDoan_CTCV.DisplayMember = "TenChiDoan";
            cbbChiDoan_CTCV.ValueMember = "MaChiDoan";
            //cbbChiDoan.Invalidate();
            if (dataChiDoan.Count != 0)
            {
                var maChiDoan = dataChiDoan[0].MaChiDoan;
                var data = db.DOANVIENs.Join(
                db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true),
                d => d.MaDoanVien,
                f => f.MaDoanVien,
                (d, f) => new { MaChiTiet = f.MaChiTiet,MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan })
                .Where(p => p.MaChiDoan == maChiDoan).Join(
                db.CHUCVUs.Where(p => p.IsDeleted != true),
                d => d.MaChucVu,
                f => f.MaChucVu,
                (d, f) => new { MaChiTiet = d.MaChiTiet, MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan, ChucVu = f.TenChucVu }).ToList();
                dgvDoanVien_CTCV.DataSource = data;
            }
        }

        private void cbbChiDoan_CTCV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var data = db.DOANVIENs.Join(
               db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true),
               d => d.MaDoanVien,
               f => f.MaDoanVien,
               (d, f) => new { MaChiTiet = f.MaChiTiet, MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan })
               .Where(p => p.MaChiDoan == cbbChiDoan_CTCV.SelectedValue.ToString()).Join(
               db.CHUCVUs.Where(p => p.IsDeleted != true),
               d => d.MaChucVu,
               f => f.MaChucVu,
               (d, f) => new { MaChiTiet = d.MaChiTiet, MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan, ChucVu = f.TenChucVu, Cap = f.Cap }).ToList();
            dgvDoanVien_CTCV.DataSource = data;
            
        }

        private void dgvDoanVien_CTCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvDoanVien_CTCV.Rows[e.RowIndex].Selected = true;
            var data = db.DOANVIENs.Join(
               db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true),
               d => d.MaDoanVien,
               f => f.MaDoanVien,
               (d, f) => new { MaChiTiet = f.MaChiTiet,MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan, NgayBatDau = f.NgayBatDau, NgayKetThuc = f.NgayKetThuc })
               .Where(p => p.MaChiDoan == cbbChiDoan_CTCV.SelectedValue.ToString()).Join(
               db.CHUCVUs.Where(p => p.IsDeleted != true),
               d => d.MaChucVu,
               f => f.MaChucVu,
               (d, f) => new { MaChiTiet = d.MaChiTiet,MaDoanVien = d.MaDoanVien, HoTen = d.HoTen, MaChucVu = f.MaChucVu, MaChiDoan = d.MaChiDoan, ChucVu = f.TenChucVu , Cap = f.Cap, NgayBatDau = d.NgayBatDau, NgayKetThuc = d.NgayKetThuc }).ToList();
            var dataRow = data[e.RowIndex];
            lblHoTen_CTCV.Text = dataRow.HoTen;
            lblMaDoanVien_CTCV.Text = dataRow.MaDoanVien;
            lblChucVu_CTCV.Text = dataRow.ChucVu;
            lblNgayBatDau_CTCV.Text = dataRow.NgayBatDau.ToString();
            lblNgayKetThuc_CTCV.Text = dataRow.NgayKetThuc.ToString();
            //lblNhiemKy_CTCV.Text = dataRow.NhiemKy;
            this.maChiTiet = dataRow.MaChiTiet;
            this.maChucVu = dataRow.MaChucVu;
            this.cap = dataRow.Cap;
          
        }

        private void btnThem_CTCV_Click(object sender, EventArgs e)
        {
            var maDoanKhoa = cbbDoanKhoa_CTCV.SelectedValue.ToString();
            var maChiDoan = cbbChiDoan_CTCV.SelectedItem !=null ? cbbChiDoan_CTCV.SelectedValue.ToString() : "";
            ThemChiTietChucVu form = new ThemChiTietChucVu(maDoanKhoa,maChiDoan);
            form.ShowDialog();
        }

        private void btnXoa_CTCV_Click(object sender, EventArgs e)
        {
            if(lblHoTen_CTCV.Text =="")
            {
                MessageBox.Show("Vui lòng chọn đoàn viên", "Cảnh báo");
                return;
            }
            if ( MessageBox.Show("Bạn có chăc chắn xóa chức vụ của đoàn viên này không ?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ChiTietChucVuBUS.Remove(new ChiTietChucVuDTO()
                {
                    MaChiTiet = this.maChiTiet,
                    MaChucVu = this.maChucVu,
                    MaDoanVien = lblMaDoanVien_CTCV.Text,
                    //NhiemKy = lblNhiemKy_CTCV.Text
                });
                LoadDgvDoanVien();
            }
            else
            {
                // Đeo OK
            }
        }

        private void btnSua_CTCV_Click(object sender, EventArgs e)
        {
            if(lblHoTen_CTCV.Text=="")
            {
                MessageBox.Show("Vui lòng chọn đoàn viên", "Cảnh báo");
                return;
            }
            var maChiTiet = this.maChiTiet;
            var maDoanKhoa = cbbDoanKhoa_CTCV.SelectedValue.ToString();
            var maChiDoan = cbbChiDoan_CTCV.SelectedItem != null ? cbbChiDoan_CTCV.SelectedValue.ToString() : "";
            var maDoanVien = lblMaDoanVien_CTCV.Text;
            var tenDoanVien = lblHoTen_CTCV.Text;

            SuaChiTietChucVu form = new SuaChiTietChucVu(maChiTiet,maDoanVien,tenDoanVien,maChiDoan,maDoanKhoa,cap,maChucVu,lblNgayBatDau_CTCV.Text,lblNgayKetThuc_CTCV.Text);
            form.ShowDialog();
           
        }
    }
}
