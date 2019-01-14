using QUANLYDOANVIEN.DAO;
using QUANLYDOANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYDOANVIEN.GUI
{
    public partial class TaoDotDanhGia : Form
    {
        QL_DoanVien_View qL_DoanVien_View;
        string maDonVi;
        public TaoDotDanhGia(QL_DoanVien_View _qL_DoanVien_View)
        {
            QL_DoanVien_View qL_DoanVien_View = _qL_DoanVien_View;
            InitializeComponent();
        }

        private void TaoDotDanhGia_Load(object sender, EventArgs e)
        {
            this.dateNamDot.Format = DateTimePickerFormat.Custom;
            this.dateNamDot.CustomFormat = "yyyy";
            this.dateNamDot.ShowUpDown = true;

            string MaDoanVienDanhGia = "15521016";

            HoatDongDanhGia_DoanVienDAO dao = new HoatDongDanhGia_DoanVienDAO();
            DoanVienDAO doanVienDAO = new DoanVienDAO();
            string tenNguoiDanhGia = doanVienDAO.getTenDoanVienTuMa(MaDoanVienDanhGia);
            maDonVi = doanVienDAO.getMaChiDoanTuMaDoanVien(doanVienDAO.getMaDoanVienTuTenDoanVien(tenNguoiDanhGia));

            this.comboDotDanhGia.DataSource = dao.LayDSDotDanhGia(maDonVi).ToList();
        }

        private void btnTaoDotDanhGia_Click(object sender, EventArgs e)
        {
            if (dateNamDot.Text == "" || dateNgayDanhGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đợt đánh giá");
            }else
            {
                HoatDongDanhGia_DoanVienDAO dao = new HoatDongDanhGia_DoanVienDAO();
                bool checker = dao.kiemTraTrungDotDanhGia(dateNamDot.Text);
                if (checker)
                {
                    MessageBox.Show("");
                }
                else
                {
                    HoatDongDanhGiaDoanVienDTO dto = new HoatDongDanhGiaDoanVienDTO();
                    DoanVienDAO doanVienDAO = new DoanVienDAO();
                    dto.setNamHoc(this.dateNamDot.Text);
                    dto.setThoiGianDanhGia(this.dateNgayDanhGia.Value);
                    dto.setMaDoanVienDanhGia("15521016");
                    dto.setSoLuongDV_XuatSac(0);
                    dto.setSoLuongDV_Kha(0);
                    dto.setSoLuongDV_TrungBinhKha(0);
                    dto.setSoLuongDV_Kem(0);
                    dto.setSoLuongDV_Yeu(0);
                    dto.setSoLuongDV_TrungBinhG(0);
                    dto.setMaDonVi(doanVienDAO.getMaChiDoanTuMaDoanVien(dto.getMaDoanVienDanhGia()));

                    dao.themDotDanhGia(dto);
                }
                this.comboDotDanhGia.DataSource = dao.LayDSDotDanhGia(maDonVi).ToList();

            }

        }

        private void btnXemChiTietDanhGia_Click(object sender, EventArgs e)
        {
            string namHoc = comboDotDanhGia.SelectedItem.ToString();

            HoatDongDanhGia_DoanVienDAO dao = new HoatDongDanhGia_DoanVienDAO();
            HoatDongDanhGiaDoanVienDTO dto = dao.layMotDotDanhGia(namHoc, maDonVi);
            this.lbCTNguoiDanhGia.Text = dto.getMaDoanVienDanhGia();
            this.lbDotDanhGia.Text = dto.getNamHoc();
            this.lbNgayDanhGia.Text = dto.getThoiGianDanhGia().ToShortDateString().ToString();
            this.lbSLXS.Text = dto.getSoLuongDV_XuatSac().ToString();
            this.lbSLDVTBKha.Text = dto.getSoLuongDV_TrungBinhKha().ToString();
            this.lbSLTB.Text = dto.getSoLuongDV_TrungBinh().ToString();
            this.lbSLDVTBYeu.Text = dto.getSoLuongDV_Yeu().ToString();
            this.lbSLDVKem.Text = dto.getSoLuongDV_Kem().ToString();

            int TongSoDanhGia = dto.getSoLuongDV_XuatSac() + dto.getSoLuongDV_TrungBinhKha() + dto.getSoLuongDV_TrungBinh() + dto.getSoLuongDV_Yeu() + dto.getSoLuongDV_Kem();
            this.lbTongSoLuong.Text = TongSoDanhGia.ToString();

            this.a1.Text = tinhPhanTram(dto.getSoLuongDV_XuatSac(), TongSoDanhGia).ToString();
            this.a2.Text = tinhPhanTram(dto.getSoLuongDV_Kha(), TongSoDanhGia).ToString(); 
            this.a3.Text = tinhPhanTram(dto.getSoLuongDV_TrungBinhKha(), TongSoDanhGia).ToString(); 
            this.a4.Text = tinhPhanTram(dto.getSoLuongDV_TrungBinh(), TongSoDanhGia).ToString(); 
            this.a5.Text = tinhPhanTram(dto.getSoLuongDV_Yeu(), TongSoDanhGia).ToString(); 
            this.a6.Text = tinhPhanTram(dto.getSoLuongDV_Kem(), TongSoDanhGia).ToString(); 

        }

        private int tinhPhanTram(int soLuong, int tongSo)
        {
            float a = (float)soLuong;
            float b = (float)tongSo;
            float res = a / b * 100;
            int abc = (int)res;
            if (abc <= 0)
                return 0;
            return abc;
        }
    }
}
