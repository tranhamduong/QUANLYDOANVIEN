using QUANLYDOANVIEN.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYDOANVIEN.Entity;

namespace QUANLYDOANVIEN.GUI
{
    public partial class ThemChiTietChucVu : Form
    {
        private ChucVuBUS chucVuBUS = new ChucVuBUS();
        private ChiTietChucVuBUS chiTietChucVuBUS = new ChiTietChucVuBUS();
        private QLDOANVIEN_DATABASE db = new QLDOANVIEN_DATABASE();
        private string maDoanKhoa_CTCV;
        private string maChiDoan_CTCV;
        private const float soLuongDVCD_Chuan = 50;
        private const float soLuongDVDK_Chuan = 700;

        public ThemChiTietChucVu(string maDoanKhoa = "", string maChiDoan = "")
        {
            InitializeComponent();
            maDoanKhoa_CTCV = maDoanKhoa;
            maChiDoan_CTCV = maChiDoan;
        }

        private void ThemChucVu_Load(object sender, EventArgs e)
        {
            //Load du lieu cbb Doan Khoa/ Chi doan / Cap
            LoadCbbDoanKhoa();
            LoadCbbChiDoan();
            LoadCbbCap();
            // Load du lieu gridview
            LoadDgvDoanVien();
        }

        private void LoadCbbChucVu(string maCap = "")
        {
            cbbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChucVu.DataSource = chucVuBUS.GetListChucVuByCap(maCap);
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
            cbbChucVu.Invalidate();
        }

        private void LoadCbbCap()
        {
            cbbCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCap.Items.Add("DT");
            cbbCap.Items.Add("DK");
            cbbCap.Items.Add("CD");
            cbbCap.SelectedIndex = 2;
            LoadCbbChucVu("CD");
        }

        private void LoadCbbDoanKhoa()
        {
            cbbDoanKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDoanKhoa.DataSource = db.DOANKHOAs.ToList();
            cbbDoanKhoa.DisplayMember = "TenDoanKhoa";
            cbbDoanKhoa.ValueMember = "MaDoanKhoa";
            if (maDoanKhoa_CTCV != "")
                cbbDoanKhoa.SelectedValue = maDoanKhoa_CTCV;
            cbbDoanKhoa.Invalidate();
        }

        private void LoadDgvDoanVien()
        {
            var data = db.DOANVIENs.Where(p => p.MaChiDoan == maChiDoan_CTCV).ToList();
            dtvSinhVien.DataSource = data;
        }

        private void LoadCbbChiDoan()
        {
            cbbChiDoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChiDoan.DataSource = db.CHIDOANs.Where(p => p.MaDoanKhoa == maDoanKhoa_CTCV).ToList();
            cbbChiDoan.DisplayMember = "TenChiDoan";
            cbbChiDoan.ValueMember = "MaChiDoan";
            if (maChiDoan_CTCV != "") cbbChiDoan.SelectedValue = maChiDoan_CTCV;
            cbbChiDoan.Invalidate();
        }

        private void dtvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dtvSinhVien.Rows[e.RowIndex].Selected = true;
            var dataRow = db.DOANVIENs.ToList()[e.RowIndex];
            lblTenDoanVien.Text = dataRow.HoTen;
            lblMaDoanVien.Text = dataRow.MaDoanVien;

        }

        // Chưa check bản tham số để load chức vụ lên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lblMaDoanVien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đoàn viên", "Cảnh báo");
                return;
            }
            if (tbxNamNhiemKy.Text.Length > 9 || tbxNamNhiemKy.Text.Length< 0)
            {
                MessageBox.Show("Nhập nhiệm kì sai theo dạng YYYY-YYYY", "Cảnh báo");
                return;
            }
            if(tbxNamNhiemKy.Text.Substring(4,1)!="-")
            {
                MessageBox.Show("Nhập nhiệm kì sai theo dạng YYYY-YYYY", "Cảnh báo");
                return;
            }

            if (!checkData()) return;

            //int year = dtpNgayBatĐau.Value.Year;
            //if (chiTietChucVuBUS.Insert(new ChiTietChucVuDTO()
            //{
            //    MaChucVu = cbbChucVu.SelectedValue.ToString(),
            //    MaDoanVien = lblMaDoanVien.Text,
            //    NgayBatDau = dtpNgayBatĐau.Value,
            //    NhiemKy = tbxNamNhiemKy.Text,
            //    IsDeleted = false              
            //}))
            //{
            //    MessageBox.Show("Thêm chức vụ thành công", "Thông báo");
            //}
          
            //tbxNhiemKi.Clear();

        }

        private bool checkData()
        {
            // Check kiêm nhiêm vị trí cùng cấp
            checkKiemNhiem();



                //if(cbbCap.SelectedItem.ToString()=="CD")
                //{
                //    Check so luong uv trong chi đoàn
                //    if (!checkSoLuongUV(0)) return false;
                //    if (!checkKiemNhiem(0)) return false;
                //}
                //if (cbbCap.SelectedItem.ToString() == "DK")
                //{
                //    // Check so luong uv trong chi đoàn
                //    if (!checkSoLuongUV(1)) return false;
                //}
                //if (cbbCap.SelectedItem.ToString() == "DT")
                //{
                //    // Check so luong uv trong chi đoàn
                //    if (!checkSoLuongUV(2)) return false;
                //}

                return true;
        }

        private bool checkSoLuongUV(int ma = 0)
        {
            switch(ma)
            {
                // Chi Doan
                case 0:
                    {
                        // Check so luong uv trong chi đoàn
                        float numDV = db.DOANVIENs.Where(p => p.IsDeleted != false).ToList().Count();
                        float numUV = db.CHITIETCHUCVUs.Join(
                            db.DOANVIENs.Where(p => p.IsDeleted != true && p.MaChiDoan == cbbChiDoan.SelectedValue.ToString()),
                            d => d.MaDoanVien,
                            f => f.MaDoanVien,
                            (d, f) => new
                            {
                                MaCTCV = d.MaChiTiet,
                                MaDoanVien = d.MaDoanVien,
                                MaChucVu = d.MaChucVu,
                            }).Join(
                                db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "CD"),
                                d => d.MaChucVu,
                                f => f.MaChucVu,
                                (d, f) => d
                            ).ToList().Count();
                        float numUV_Chuan = 0;
                        if (numDV < soLuongDVCD_Chuan)
                        {
                            numUV_Chuan = float.Parse(db.THAMSOes.ToList()[0].SoLuongUVBCHChiDoan_max1.ToString());
                        }
                        else
                        {
                            numUV_Chuan = float.Parse(db.THAMSOes.ToList()[0].SoLuongUVBCHCHiDoan_max2.ToString());
                        }
                        if (numUV >= soLuongDVCD_Chuan)
                        {
                            MessageBox.Show("Đã đủ số lượng ban chấp hàng chi đoàn", "Cảnh báo");
                            return false;
                        }
                        break;
                    }
                // Doan Khoa
                case 1:
                    {
                        //Check so luong uv trong đoàn khoa
                        float numDV = db.DOANVIENs.Where(p => p.IsDeleted != false).ToList().Count();
                        float numUV = db.CHITIETCHUCVUs.Join(
                            db.DOANVIENs.Where(p => p.IsDeleted != true && p.MaDoanKhoa == cbbDoanKhoa.SelectedValue.ToString()),
                            d => d.MaDoanVien,
                            f => f.MaDoanVien,
                            (d, f) => new
                            {
                                MaCTCV = d.MaChiTiet,
                                MaDoanVien = d.MaDoanVien,
                                MaChucVu = d.MaChucVu,
                            }).Join(
                                db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "DK"),
                                d => d.MaChucVu,
                                f => f.MaChucVu,
                                (d, f) => d
                            ).ToList().Count();
                        float numUV_Chuan = 0;
                        if (numDV < soLuongDVDK_Chuan)
                        {
                            numUV_Chuan = float.Parse(db.THAMSOes.ToList()[0].SoLuongUVBCHDoanKhoa_max1.ToString());
                        }
                        else
                        {
                            numUV_Chuan = float.Parse(db.THAMSOes.ToList()[0].SoLuongUVBCHDoanKhoa_max2.ToString());
                        }
                        if (numUV >= numUV_Chuan)
                        {
                            MessageBox.Show("Đã đủ số lượng ban chấp hàng đoàn khoa", "Cảnh báo");
                            return false;
                        }
                        break;
                    }
                // Doan Truong
                case 2:
                    {
                        // Check so luong uv trong đoàn trường
                        float numDV = db.DOANVIENs.Where(p => p.IsDeleted != false).ToList().Count();
                        float numUV = db.CHITIETCHUCVUs.Join(
                            db.DOANVIENs.Where(p => p.IsDeleted != true),
                            d => d.MaDoanVien,
                            f => f.MaDoanVien,
                            (d, f) => new
                            {
                                MaCTCV = d.MaChiTiet,
                                MaDoanVien = d.MaDoanVien,
                                MaChucVu = d.MaChucVu,
                            }).Join(
                                db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "DT"),
                                d => d.MaChucVu,
                                f => f.MaChucVu,
                                (d, f) => d
                            ).ToList().Count();

                        float numUV_Chuan = float.Parse(db.THAMSOes.ToList()[0].SoLuongUVBCHDoanTruong_max.ToString());

                    
                        if (numUV >= numUV_Chuan)
                        {
                            MessageBox.Show("Đã đủ số lượng ban chấp hàng chi đoàn", "Cảnh báo");
                            return false;
                        }
                        break;
                    }
                default:
                    break;
            }
            return true;
        }

        private bool checkKiemNhiem()
        {
            if (cbbCap.SelectedItem.ToString() == "CD")
            {
                // Check so luong uv trong chi đoàn
                float numUV = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true && p.MaDoanVien == lblMaDoanVien.Text.ToString())
                    .Join(
                        db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "CD"),
                        d => d.MaChucVu,
                        f => f.MaChucVu,
                        (d, f) =>d).ToList().Count;
                if (numUV > 0)
                {
                    MessageBox.Show("Đoàn viên không được kiêm nhiệm chức vụ trong chi đoàn", "Cảnh báo");
                    return false;
                }

            }
            if (cbbCap.SelectedItem.ToString() == "CD")
            {
                // Check so luong uv trong chi đoàn
                float numUV = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true && p.MaDoanVien == lblMaDoanVien.Text.ToString())
                    .Join(
                        db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "DK"),
                        d => d.MaChucVu,
                        f => f.MaChucVu,
                        (d, f) => d).ToList().Count;
                if (numUV > 0)
                {
                    MessageBox.Show("Đoàn viên không được kiêm nhiệm chức vụ trong đoàn khoa", "Cảnh báo");
                    return false;
                }

            }
            if (cbbCap.SelectedItem.ToString() == "DT")
            {
                // Check so luong uv trong đoàn trường
                float numUV = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true && p.MaDoanVien == lblMaDoanVien.Text.ToString())
                    .Join(
                        db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "DT"),
                        d => d.MaChucVu,
                        f => f.MaChucVu,
                        (d, f) => d).ToList().Count;
                if (numUV > 0)
                {
                    MessageBox.Show("Đoàn viên không được kiêm nhiệm chức vụ trong đoàn trường", "Cảnh báo");
                    return false;
                }

            }
            return true;
        }

        private bool checkTrungNhiemKy()
        {
            //string nhiemKy = dtpNgayBatĐau.Value.Year.ToString() + "" + (dtpNgayBatĐau.Value.Year + float.Parse(cbbNamNhiemKy.SelectedItem.ToString()));


            return true;
        }

        private bool checkChucVu_NhiemKi (int ma = 0)
        {
            switch (ma)
            {
                // Chi Doan
                case 0:
                    {
                        // Check so luong uv trong chi đoàn
                        float num = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true && p.MaDoanVien == lblMaDoanVien.Text.ToString())
                            .Join(
                                db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "CD"),
                                d => d.MaChucVu,
                                f => f.MaChucVu,
                                (d, f) => d).ToList().Count;
                        if (num > 0)
                        {
                            MessageBox.Show("Đoàn viên không được kiêm nhiệm chức vụ trong chi đoàn", "Cảnh báo");
                            return false;
                        }
                        break;
                    }
                // Doan Khoa
                case 1:
                    {
                        // Check so luong uv trong chi đoàn
                        float num = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true && p.MaDoanVien == lblMaDoanVien.Text.ToString())
                            .Join(
                                db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "DK"),
                                d => d.MaChucVu,
                                f => f.MaChucVu,
                                (d, f) => d).ToList().Count;
                        if (num > 0)
                        {
                            MessageBox.Show("Đoàn viên không được kiêm nhiệm chức vụ trong đoàn khoa", "Cảnh báo");
                            return false;
                        }
                        break;
                    }
                // Doan Truong
                case 2:
                    {
                        // Check so luong uv trong chi đoàn
                        float num = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true && p.MaDoanVien == lblMaDoanVien.Text.ToString())
                            .Join(
                                db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == "DT"),
                                d => d.MaChucVu,
                                f => f.MaChucVu,
                                (d, f) => d).ToList().Count;
                        if (num > 0)
                        {
                            MessageBox.Show("Đoàn viên không được kiêm nhiệm chức vụ trong đoàn trường", "Cảnh báo");
                            return false;
                        }
                        break;
                    }
                default:
                    break;
            }
            return true;
        }

        private void cbbDoanKhoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var dataChiDoan = db.CHIDOANs.Where(p => p.MaDoanKhoa == cbbDoanKhoa.SelectedValue.ToString()).ToList();

            //Load du lieu cbb Chi Doan
            cbbChiDoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChiDoan.DataSource = dataChiDoan;
            cbbChiDoan.DisplayMember = "TenChiDoan";
            cbbChiDoan.ValueMember = "MaChiDoan";
            //cbbChiDoan.Invalidate();
            if(dataChiDoan.Count!=0)
            {
                var maChiDoan = dataChiDoan[0].MaChiDoan;
                var data = db.DOANVIENs.Where(p => p.MaChiDoan == maChiDoan).ToList();
                dtvSinhVien.DataSource = data;
            }
       
        }

        private string CreateID(String Id = "ID")
        {
            string stringID = Id;
            var num = db.CHITIETCHUCVUs.ToList().Count() + 1;
            stringID += num.ToString("000");
            return stringID;
        }

        private void cbbChiDoan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(e.ToString() != null)
            {
                var data = db.DOANVIENs.Where(p => p.MaChiDoan == cbbChiDoan.SelectedValue.ToString()).ToList();
                dtvSinhVien.DataSource = data;
            }
           
        }

        private void cbbCap_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCbbChucVu(cbbCap.SelectedItem.ToString());
        }
    }

 
}
