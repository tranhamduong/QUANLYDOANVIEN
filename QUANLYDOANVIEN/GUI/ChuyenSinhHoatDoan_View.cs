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
    public partial class ChuyenSinhHoatDoan_View : Form
    {
        private string tenDoanVien;
        public QL_DoanVien_View mainForm;
        public ChuyenSinhHoatDoan_View()
        {
            InitializeComponent();
        }

        public ChuyenSinhHoatDoan_View(QL_DoanVien_View mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ChuyenSinhHoatDoan_View_Load(object sender, EventArgs e)
        {
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
            DoanVienDAO doanVienDAO = new DoanVienDAO();
            tenDoanVien = doanVienDAO.getTenDoanVienTuMa(QL_DoanVien_View.selectedDoanVien);
            this.comboDSDonViChuyenDen.DataSource = chiDoanDAO.getTatCaTenChiDoan();
            this.lbTenDoanVien.Text = tenDoanVien;
            this.lbThongTintenDoanVien.Text = tenDoanVien;
            this.lbThongTinCDChuyenDi.Text = chiDoanDAO.getTenChiDoanTuMaChiDoan(doanVienDAO.getMaChiDoanTuMaDoanVien(QL_DoanVien_View.selectedDoanVien));
        }

        private void radioCoSoDoanBenNgoai_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioCoSoDoanBenNgoai.Checked == true)
            {
                txtDonViChuyenDen.Enabled = true;
                comboDSDonViChuyenDen.Enabled = false;
            }else
            {
                txtDonViChuyenDen.Enabled = false;
                comboDSDonViChuyenDen.Enabled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ChiTietChuyenSinhHoatDoanDAO dao = new ChiTietChuyenSinhHoatDoanDAO();
            ChiTietChuyenSinhHoatDoanDTO dto = new ChiTietChuyenSinhHoatDoanDTO();
            DoanVienDAO doanVienDAO = new DoanVienDAO();

            dto.setMaDoanVien(doanVienDAO.getMaDoanVienTuTenDoanVien(tenDoanVien));
            dto.setDonViChuyenDen(this.lbTTChiDoanChuyenDen.Text);
            dto.setThoiGianChuyen(this.dateThoiGianChuyen.Value);
            dto.setLyDoChuyen(this.txtLyDoChuyen.Text);
            if (this.radioCoSoDoanNoiBo.Checked)
            {
                ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                doanVienDAO.ThayDoiChiDoanCuaMotDoanVien(dto.getMaDoanVien(), chiDoanDAO.getMaChiDoanBangTen(this.lbTTChiDoanChuyenDen.Text));
                dao.luuChiTietChuyenSinhHoatDoan(dto);
            }
            else
            {
                dao.luuChiTietChuyenSinhHoatDoan(dto);
                doanVienDAO.KetThucSinhHoatDoanMotDoanVien(QL_DoanVien_View.selectedDoanVien);
            }
            
            this.Close();

        }

        private void txtDonViChuyenDen_TextChanged(object sender, EventArgs e)
        {
            this.lbTTChiDoanChuyenDen.Text = this.txtDonViChuyenDen.Text;
        }

        private void comboDSDonViChuyenDen_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbTTChiDoanChuyenDen.Text = this.comboDSDonViChuyenDen.SelectedItem.ToString();
        }
    }
}
