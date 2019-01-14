using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;

namespace QUANLYDOANVIEN.BUS
{
    public partial class SuaChiTietChucVu : Form
    {
        private QLDOANVIEN_DATABASE db = new QLDOANVIEN_DATABASE();
        private ChucVuBUS chucVuBUS = new ChucVuBUS();
        private ChiTietChucVuBUS chiTietChucVuBUS = new ChiTietChucVuBUS();

        private string maDoanVien, tenDoanVien, maChiDoan, maDoanKhoa, cap, maChucVu, maChiTiet, ngayBatDau, ngayKetThuc;

        private void cbbCap_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbChucVu.DataSource = chucVuBUS.GetListChucVuByCap(cbbCap.SelectedItem.ToString());

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime? ngayKetThuc;
            if(DateTime.Compare(dtpNgayBatDau.Value.Date,dtpNgayKetThuc.Value.Date)>0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Cảnh báo");
                return;
            }
            if (DateTime.Compare(dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date) == 0)
            {
                ngayKetThuc = null;
            }
            else
            {
                ngayKetThuc = dtpNgayKetThuc.Value;
            }

            if(MessageBox.Show("Bạn có chắc chắn chỉnh sửa chưa ?","Cảnh báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                chiTietChucVuBUS.Update(new ChiTietChucVuDTO()
                {
                    MaChiTiet = this.maChiTiet,
                    MaDoanVien = this.maDoanVien,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = ngayKetThuc,
                    NhiemKy = dtpNgayBatDau.Value.Year.ToString() + "-" + (dtpNgayBatDau.Value.Year + int.Parse(cbbNhiemKy.SelectedItem.ToString())),
                    MaChucVu = cbbChucVu.SelectedValue.ToString()
                });
                return;
            }
            else
            {
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SuaChiTietChucVu(string maChiTiet = "",string maDoanVien = "", string tenDoanVien ="", string maChiDoan ="", string maDoanKhoa = "", string cap ="", string maChucVu ="", string ngayBatDau = null, string ngayKetThuc ="")
        {
            InitializeComponent();
            this.maChiTiet = maChiTiet;
            this.maDoanVien = maDoanVien;
            this.tenDoanVien = tenDoanVien;
            this.maChiDoan = maChiDoan;
            this.maDoanKhoa = maDoanKhoa;
            this.cap = cap;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.maChucVu = maChucVu;

        }

        private void SuaChucVu_Load(object sender, EventArgs e)
        {
            lblMaDoanVien.Text = maDoanVien;
            lblTenDoanVien.Text = tenDoanVien;
            lblChiDoan.Text = db.CHIDOANs.Where(p=>p.IsDeleted!=true).ToList().Find(p=>p.MaChiDoan==maChiDoan).TenChiDoan;
            lblDoanKhoa.Text = db.DOANKHOAs.Where(p => p.IsDeleted != true).ToList().Find(p => p.MaDoanKhoa == maDoanKhoa).TenDoanKhoa;
            LoadCbbCap();
           
            LoadCbbNhiemKy();

            dtpNgayBatDau.Value = Convert.ToDateTime(ngayBatDau);
            if(ngayKetThuc.Length != 0)
            dtpNgayKetThuc.Value = Convert.ToDateTime(ngayKetThuc);
        }

        private void LoadCbbNhiemKy()
        {
            cbbNhiemKy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNhiemKy.Items.Add("4");
            cbbNhiemKy.Items.Add("2");
            cbbNhiemKy.Items.Add("1");
            cbbNhiemKy.SelectedIndex = 0; ;
        }

        private void LoadCbbCap()
        {
            cbbCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCap.Items.Add("DT");
            cbbCap.Items.Add("DK");
            cbbCap.Items.Add("CD");
            cbbCap.SelectedItem = cap;
            LoadCbbChucVu(cap);
        }
        
        private void LoadCbbChucVu(string maCap = "")
        {
            cbbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChucVu.DataSource = chucVuBUS.GetListChucVuByCap(maCap);
            int num = chucVuBUS.GetIndexMaChucVu(maChucVu,maCap);
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
            cbbChucVu.SelectedIndex = num;
            cbbChucVu.Invalidate();
        }
    }
}
