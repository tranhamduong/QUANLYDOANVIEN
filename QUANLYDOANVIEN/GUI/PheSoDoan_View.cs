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
    public partial class PheSoDoan_View : Form
    {
        private QL_DoanVien_View qL_DoanVien_View;
        private string selectedMaDoanVien;
        private string maTaiKhoan;
        private string maDonVi;
        private string selected;
        private string seleted2;

        public PheSoDoan_View()
        {
            InitializeComponent();
        }

        public PheSoDoan_View(QL_DoanVien_View qL_DoanVien_View)
        {
            InitializeComponent();
            this.qL_DoanVien_View = qL_DoanVien_View;
            selectedMaDoanVien = QL_DoanVien_View.selectedDoanVien;
            maTaiKhoan = "15521016";
            this.dataGridView.MultiSelect = false;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void PheSoDoan_View_Load(object sender, EventArgs e)
        {
            HoatDongDanhGia_DoanVienDAO dao = new HoatDongDanhGia_DoanVienDAO();
            DoanVienDAO doanVienDAO = new DoanVienDAO();
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
            maDonVi = doanVienDAO.getMaChiDoanTuMaDoanVien(maTaiKhoan);

            this.comboDotDanhGia.DataSource = dao.LayDSDotDanhGia(maDonVi).ToList();
            this.lbCoSo.Text = chiDoanDAO.getTenChiDoanTuMaChiDoan(maDonVi);
            this.lbTenNguoiDanhGia.Text = doanVienDAO.getTenDoanVienTuMa(maTaiKhoan);
            this.lbTenDVDanhGia.Text = doanVienDAO.getTenDoanVienTuMa(selectedMaDoanVien);

            ChiTietDanhGia_DoanVienDAO chiTietDAO = new ChiTietDanhGia_DoanVienDAO();
            this.dataGridView.DataSource = chiTietDAO.layDSChiTietCuaMotDoanVien(selectedMaDoanVien).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            ChiTietDanhGia_DoanVienDAO chiTietDAO = new ChiTietDanhGia_DoanVienDAO();

            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Xác nhận";
                btnThem.BackColor = Color.Green;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                groupTTPheSoDoan.Enabled = true;
            }
            else
            {
                ThanNhanDAO thanNhanDAO = new ThanNhanDAO();

                bool flag = false;
                var listInput = GetAllControlByType(this.groupTTPheSoDoan, this.txtDRL.GetType());
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Không được để trống ô ký tự");
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    ChiTietDanhGia_DoanVienDTO dto = new ChiTietDanhGia_DoanVienDTO();
                    HoatDongDanhGia_DoanVienDAO hoatDongDAO = new HoatDongDanhGia_DoanVienDAO();
                    dto.setMaHDDG(hoatDongDAO.layMaHoatDongTuMaDonViVaNamHoc(maDonVi, this.comboDotDanhGia.Text));
                    if (chiTietDAO.kiemTraTrung(this.selectedMaDoanVien, this.comboDotDanhGia.Text))
                    {
                        MessageBox.Show("Đã tồn tại đánh giá này. Bạn cần xóa đánh giá này trước khi thêm mới");
                    }
                    dto.setMaDoanVien(this.selectedMaDoanVien);
                    dto.setNhanXetBiThuChiDoan(this.txtNhanXetBiThu.Text);
                    dto.setXepLoai(this.txtXepLoai.Text);
                    dto.setDRL(Int32.Parse(this.txtDRL.Text));

                    chiTietDAO.ThemChiTiet(dto);

                    MessageBox.Show("Thêm chi tiết thành công!");
                    this.dataGridView.DataSource = chiTietDAO.layTatCaChiTietTuMotDoanVien(this.selectedMaDoanVien).ToList();

                }
                groupTTPheSoDoan.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Text = "Thêm";
                btnThem.BackColor = SystemColors.Control;
            }

            this.dataGridView.DataSource = chiTietDAO.layDSChiTietCuaMotDoanVien(selectedMaDoanVien).ToList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietDanhGia_DoanVienDAO dao = new ChiTietDanhGia_DoanVienDAO();
            dao.xoaChiTiet(this.selected);

            this.dataGridView.DataSource = dao.layDSChiTietCuaMotDoanVien(selectedMaDoanVien).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public IEnumerable<Control> GetAllControlByType(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControlByType(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void txtDRL_TextChanged(object sender, EventArgs e)
        {
            string value = this.txtDRL.Text;
            int n;
            bool isNumeric = int.TryParse(value, out n);
            if (isNumeric)
            {
                n = Int32.Parse(value);
                if (n < 30)
                {
                    this.txtXepLoai.Text = "Kém";
                }
                else if (30 <= n && n < 50)
                    this.txtXepLoai.Text = "Yếu";
                else if (50 <= n && n < 60)
                    this.txtXepLoai.Text = "Trung Bình";
                else if (60 <= n && n < 70)
                    this.txtXepLoai.Text = "Trung Bình Khá";
                else if (70 <= n && n < 80)
                    this.txtXepLoai.Text = "Khá";
                else this.txtXepLoai.Text = "Xuất Sắc";
            }

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 0)
            {
                this.selected = this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
