using QUANLYDOANVIEN.DAO;
using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYDOANVIEN.GUI
{
    public partial class QL_DoanVien_View : Form
    {
        private string selected;
        private string excelFilePath = "";
        public static string selectedDoanVien = "";
        public static string chiDoanHuongDen = "";
        public static string maTaiKhoan = "";
        public QL_DoanVien_View()
        {
            InitializeComponent();
        }

        private void txtSucKhoe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDanToc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            if (this.btnThemMoi.Text == "Thêm mới")
            {
                this.groupLiLichBanThan.Enabled = true;
                this.groupQuaTrinhCongTac.Enabled = true;
                this.groupSinhHoatDoan.Enabled = true;
                this.btnSua.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnThemMoi.Text = "Xác nhận";
                this.btnThemMoi.BackColor = Color.Green;
            }
            else
            {
                DoanVienDAO dao = new DoanVienDAO();

                //kiểm thử dữ liệu đầu vào
                bool flag = false;

                var listInput = GetAllControlByType(this.groupLiLichBanThan, this.txtHoVaTen.GetType());
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Dữ liệu " + item.Tag + " không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                        break;
                    }
                }
                var listInput2 = GetAllControlByType(this.groupQuaTrinhCongTac, this.txtHoVaTen.GetType());
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Dữ liệu " + item.Tag + " không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                        break;
                    }
                }
                var listInput3 = GetAllControlByType(this.groupSinhHoatDoan, this.txtHoVaTen.GetType());
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Dữ liệu " + item.Tag + " không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                        break;
                    }
                }
                if (this.comboGioiTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Dữ liệu Giới tính không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                }
                //kết thúc kiểm thử dữ liệu đầu vào

                if (!flag)
                {

                    DoanVienDTO doanvien = new DoanVienDTO();
                    doanvien.setHoVaTen(this.txtHoVaTen.Text);
                    doanvien.setTenGoiKhac(this.txtTenGoiKhac.Text);
                    if (this.comboGioiTinh.Text == "Nam")
                        doanvien.setGioiTinh(true);
                    else
                        doanvien.setGioiTinh(false);
                    doanvien.setDanToc(this.txtDanToc.Text);
                    doanvien.setQueQuan(this.txtQueQuan.Text);
                    doanvien.setNgheNghiepBanThan(this.txtNgheNghiep.Text);
                    doanvien.setTrinhDoHocVan(this.txtTrinhDoHocVan.Text);
                    doanvien.setNoiVaoDoan(this.txtNoiVaoDoan.Text);
                    doanvien.setSucKhoe(this.txtSucKhoe.Text);
                    doanvien.setNuocDaDi(this.txtNuocDaDi.Text);
                    doanvien.setLiDoDi(this.txtNuocDaDi.Text);
                    doanvien.setNgaySinh(this.dateNgayThangNamSinh.Value);
                    doanvien.setNgayVaoDoan(this.dateNgayVaoDoan.Value);
                    doanvien.setChuyenMonNghiepVu(this.txtChuyenMon.Text);
                    doanvien.setTonGiao(this.txtTonGiao.Text);
                    doanvien.setNgoaiNgu(this.txtNgoaiNgu.Text);
                    doanvien.setLiLuanChinhTri(this.txtLyLuanChinhTri.Text);
                    doanvien.setQuaTrinhCongTac(this.txtQuaTrinhCongTac.Text);
                    doanvien.setKhenThuong(this.txtKhenThuong.Text);
                    doanvien.setKyLuat(this.txtKyLuat.Text);
                    doanvien.setNangKhieu(this.txtNangKhieu.Text);
                    doanvien.setSoTruong(this.txtSoTruong.Text);
                    doanvien.setTamTru(this.txtTamTru.Text);
                    doanvien.setThuongTru(this.txtThuongTru.Text);
                    doanvien.setSucKhoe(this.txtSucKhoe.Text);
                    doanvien.setNamBDSinhHoat(this.txtNamBDSinhHoat.Text);
                    doanvien.setTinhTrangSinhHoatDoan("Đang sinh hoạt");

                    ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                    string temp = chiDoanDAO.getMaChiDoanBangTen(this.comboChiDoan.Text);
                    if (temp != null)
                    {
                        doanvien.setMaChiDoan(temp);
                        DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
                        doanvien.setMaDoanKhoa(doanKhoaDAO.getMaDoanKhoaTuTenDoanKhoa(this.lbTenDoanKhoa.Text));
                        bool res = dao.themDoanVien(doanvien);
                    }
                    else
                        MessageBox.Show("Mã chi đoàn không hợp lệ");

                    
                    refreshDataGrid();

                }


                //xác nhận
                this.groupLiLichBanThan.Enabled = false;
                this.groupQuaTrinhCongTac.Enabled = false;
                this.groupSinhHoatDoan.Enabled = false;
                foreach (var item in listInput)
                {
                    item.Text = String.Empty;
                }
                foreach (var item in listInput2)
                {
                    item.Text = String.Empty;
                }
                foreach (var item in listInput3)
                {
                    item.Text = String.Empty;
                }
                this.btnThemMoi.Text = "Thêm mới";
                this.btnThemMoi.BackColor = SystemColors.Control;
                this.btnDelete.Enabled = true;
                this.btnSua.Enabled = true;
                //kết thúc xác nhận


            }
        }

        private void QL_DoanVien_View_Load(object sender, EventArgs e)
        {
            DoanVienDAO dao = new DoanVienDAO();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DataSource = dao.listAll().ToList();

            dataGridView.MultiSelect = false;
            this.dataGridView.Rows[0].Selected = true;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);

            //
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
            comboChiDoan.DataSource = chiDoanDAO.getTatCaTenChiDoan();

            DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
            this.comboDoanKhoaSearchField.DataSource = doanKhoaDAO.getTatCaTenDoanKhoa();
            this.comboDoanKhoaSearchField.SelectedIndex = this.comboDoanKhoaSearchField.Items.Count - 1;
            dataGridView.DataSource = dao.listAll().ToList();

            lbTenCoSo.Text = "Trường Đại học Công nghệ Thông tin ĐHQG-HCM";
            lbSoLuongCoSo.Text = dao.getSoLuongDoanTruong();
            lbSoLuongNam.Text = dao.getSoLuongNamDoanTruong();
            lbSoLuongNu.Text = dao.getSoLuongNuDoanTruong();

            comboNangCao_DoanKhoa.DataSource = doanKhoaDAO.getTatCaTenDoanKhoa();
            this.comboNangCao_DoanKhoa.SelectedIndex = this.comboNangCao_DoanKhoa.Items.Count - 1;

            this.comboNangCao_DanToc.SelectedIndex = 0;
            this.comboNangCao_TonGiao.SelectedIndex = 0;
            this.comboNangCao_GioiTinh.SelectedIndex = 2;

            refreshDataGrid();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 0)
            {
                this.selected = this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        public IEnumerable<Control> GetAllControlByType(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControlByType(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoanVienDAO dao = new DoanVienDAO();
            dao.xoaDoanVien(this.selected);
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            DoanVienDAO doanVienDAO = new DoanVienDAO();
            DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();

            

            if (comboDoanKhoaSearchField.SelectedValue.ToString() == "Tất cả Đoàn Khoa")
            {
                this.dataGridView.DataSource = doanVienDAO.listAll().ToList();
                lbTenCoSo.Text = "Trường Đại học Công nghệ Thông tin ĐHQG-HCM";
                lbSoLuongCoSo.Text = doanVienDAO.getSoLuongDoanTruong();
                lbSoLuongNam.Text = doanVienDAO.getSoLuongNamDoanTruong();
                lbSoLuongNu.Text = doanVienDAO.getSoLuongNuDoanTruong();
            }
            else
            {
                if (comboChiDoanSearchField.SelectedValue.ToString() == "Tất cả Chi Đoàn")
                {
                    this.dataGridView.DataSource = doanVienDAO.getDSDoanVienTuMotDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString()).ToList();
                    this.lbTenCoSo.Text = this.comboDoanKhoaSearchField.SelectedValue.ToString();
                    this.lbSoLuongCoSo.Text = doanKhoaDAO.getSoLuongDoanVienTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString().Trim());
                    this.lbSoLuongNam.Text = doanKhoaDAO.getSoLuongDoanVienNamTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString());
                    this.lbSoLuongNu.Text = doanKhoaDAO.getSoLuongDoanVienNuTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString());
                }
                else
                {
                    this.dataGridView.DataSource = doanVienDAO.getDSDoanVienTuMotChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString()).ToList();
                    this.lbTenCoSo.Text = this.comboChiDoanSearchField.SelectedValue.ToString();
                    this.lbSoLuongCoSo.Text = chiDoanDAO.getSoLuongDoanVienTuTenChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString().Trim());
                    this.lbSoLuongNam.Text = chiDoanDAO.getSoLuongNamTuChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString());
                    this.lbSoLuongNu.Text = chiDoanDAO.getSoLuongNuTuChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString());
                }
            }

            //this.dataGridView.Rows[0].Selected = true;
        }

        #region excel
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                excelFilePath = textBox1.Text;
                if (excelFilePath != "")
                {
                    loadExcelImportedFile(excelFilePath);
                }
            }

            refreshDataGrid();
            MessageBox.Show("Import thành công!");
        }

        private void loadExcelImportedFile(string excelFilePath)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelFilePath);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            try
            {
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                DoanVienDTO dv = null;
                DoanVienDAO dao = new DoanVienDAO();
                for (int i = 2; i <= rowCount; i++)
                {
                    dv = new DoanVienDTO(i, xlRange);
                    if (dv != null)
                        dao.themDoanVien(dv);
                    dv = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            refreshDataGrid();
        }
        #endregion excel

        private void btnSua_Click(object sender, EventArgs e)
        {
            DoanVienDAO dao = new DoanVienDAO();
            DOANVIEN res = dao.getByMaDoanVien(this.selected);

            if (this.btnSua.Text == "Sửa")
            {
                if (res != null) //ton tai
                {
                    DoanVienDTO doanvien = new DoanVienDTO();
                    doanvien = DoanVienDTO.reConvertToDTO(res);
                    this.groupLiLichBanThan.Enabled = true;
                    this.groupQuaTrinhCongTac.Enabled = true;
                    this.groupSinhHoatDoan.Enabled = true;
                    this.btnThemMoi.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnSua.Text = "Xác nhận";
                    this.btnSua.BackColor = Color.Green;


                    this.txtHoVaTen.Text = doanvien.getHoVaTen();
                    this.txtTenGoiKhac.Text = doanvien.getTenGoiKhac();
                    this.dateNgayThangNamSinh.Value = doanvien.getNgaySinh();
                    if (doanvien.getGioiTinh() == true)
                        this.comboGioiTinh.SelectedIndex = 0;
                    else
                        this.comboGioiTinh.SelectedIndex = 1;
                    this.txtQueQuan.Text = doanvien.getQueQuan();
                    this.txtDanToc.Text = doanvien.getDanToc();
                    this.txtNgheNghiep.Text = doanvien.getNgheNghiepBanThan();
                    this.txtTrinhDoHocVan.Text = doanvien.getTrinhDoHocVan();
                    this.txtChuyenMon.Text = doanvien.getChuyenMonNghiepVu();
                    this.txtNoiVaoDoan.Text = doanvien.getNoiVaoDoan();
                    this.dateNgayVaoDoan.Value = doanvien.getNgayVaoDoan();
                    this.txtNuocDaDi.Text = doanvien.getNuocDaDi();
                    this.txtSucKhoe.Text = doanvien.getSucKhoe();
                    this.txtLyLuanChinhTri.Text = doanvien.getLiLuanChinhTri();
                    this.txtNgoaiNgu.Text = doanvien.getNgoaiNgu();
                    this.txtTamTru.Text = doanvien.getTamTru();
                    this.txtThuongTru.Text = doanvien.getThuongTru();
                    this.txtQuaTrinhCongTac.Text = doanvien.getQuaTrinHCongTac();
                    this.txtKhenThuong.Text = doanvien.getKhenThuong();
                    this.txtKyLuat.Text = doanvien.getKyLuat();
                    this.txtSoTruong.Text = doanvien.getSoTruong();
                    this.txtNangKhieu.Text = doanvien.getNangKhieu();
                    this.txtNamBDSinhHoat.Text = doanvien.getNamBDSinhHoat();
                    this.txtNgoaiNgu.Text = doanvien.getNgoaiNgu();
                    this.txtTonGiao.Text = doanvien.getTonGiao();

                    ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                    this.comboChiDoan.DataSource = chiDoanDAO.getTatCaTenChiDoan();
                }
                else
                {
                    MessageBox.Show("Không tồn tại đoàn viên");
                }
            }
            else
            {
                //Đoạn code edit giống đoạn code thêm mới
                //kiểm thử dữ liệu đầu vào
                bool flag = false;
                var listInput = GetAllControlByType(this.groupLiLichBanThan, this.txtHoVaTen.GetType());
                foreach (var item in listInput)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Dữ liệu " + item.Tag + " không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                        break;
                    }
                }

                if (this.comboGioiTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Dữ liệu Giới tính không được để trống!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = true;
                }
                //kết thúc kiểm thử dữ liệu đầu vào

                if (!flag)
                {
                    bool result = false;
                    DoanVienDTO doanvien = new DoanVienDTO();
                    doanvien.setMaDoanVien(this.selected);
                    doanvien.setHoVaTen(this.txtHoVaTen.Text);
                    doanvien.setTenGoiKhac(this.txtTenGoiKhac.Text);
                    doanvien.setDanToc(this.txtDanToc.Text);
                    doanvien.setQueQuan(this.txtQueQuan.Text);
                    doanvien.setNgheNghiepBanThan(this.txtNgheNghiep.Text);
                    doanvien.setTrinhDoHocVan(this.txtTrinhDoHocVan.Text);
                    doanvien.setNoiVaoDoan(this.txtNoiVaoDoan.Text);
                    doanvien.setSucKhoe(this.txtSucKhoe.Text);
                    doanvien.setNuocDaDi(this.txtNuocDaDi.Text);
                    doanvien.setLiDoDi(this.txtNuocDaDi.Text);
                    doanvien.setNgaySinh(this.dateNgayThangNamSinh.Value);
                    doanvien.setNgayVaoDoan(this.dateNgayVaoDoan.Value);
                    doanvien.setChuyenMonNghiepVu(this.txtChuyenMon.Text);
                    doanvien.setTonGiao(this.txtTonGiao.Text);
                    doanvien.setNgoaiNgu(this.txtNgoaiNgu.Text);
                    doanvien.setLiLuanChinhTri(this.txtLyLuanChinhTri.Text);
                    doanvien.setQuaTrinhCongTac(this.txtQuaTrinhCongTac.Text);
                    doanvien.setKhenThuong(this.txtKhenThuong.Text);
                    doanvien.setKyLuat(this.txtKyLuat.Text);
                    doanvien.setNangKhieu(this.txtNangKhieu.Text);
                    doanvien.setSoTruong(this.txtSoTruong.Text);
                    doanvien.setTamTru(this.txtTamTru.Text);
                    doanvien.setThuongTru(this.txtThuongTru.Text);
                    doanvien.setSucKhoe(this.txtSucKhoe.Text);
                    doanvien.setNamBDSinhHoat(this.txtNamBDSinhHoat.Text);
                    doanvien.setTinhTrangSinhHoatDoan("Đang sinh hoạt");
                    
                    ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                    string temp = chiDoanDAO.getMaChiDoanBangTen(this.comboChiDoan.Text);
                    if (temp != null)
                    {
                        doanvien.setMaChiDoan(temp);
                        DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
                        doanvien.setMaDoanKhoa(doanKhoaDAO.getMaDoanKhoaTuTenDoanKhoa(this.lbTenDoanKhoa.Text));
                        result = dao.suaDoanVien(doanvien);
                    }
                    else
                        MessageBox.Show("Mã chi đoàn không hợp lệ");

                    if (result == false)
                        MessageBox.Show("Chỉnh sửa thất bại!");
                }


                //xác nhận
                this.groupLiLichBanThan.Enabled = false;
                this.groupQuaTrinhCongTac.Enabled = false;
                this.groupSinhHoatDoan.Enabled = false;
                foreach (var item in listInput)
                {
                    item.Text = String.Empty;
                }
                this.btnThemMoi.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSua.Text = "Sửa";
                this.btnSua.BackColor = SystemColors.Control;

                refreshDataGrid();
            }
        }

        private void comboDoanKhoaSearchField_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboDoanKhoaSearchField.SelectedIndex >= 0)
            {
                comboChiDoanSearchField.DataSource = null;

                if (comboDoanKhoaSearchField.SelectedValue.ToString() == "Tất cả Đoàn Khoa")
                {
                    comboChiDoanSearchField.Enabled = false;
                    DoanVienDAO doanVienDAO = new DoanVienDAO();
                    dataGridView.DataSource = doanVienDAO.listAll().ToList();
                    lbTenCoSo.Text = "Trường Đại học Công nghệ Thông tin ĐHQG-HCM";
                    lbSoLuongCoSo.Text = doanVienDAO.getSoLuongDoanTruong();
                    lbSoLuongNam.Text = doanVienDAO.getSoLuongNamDoanTruong();
                    lbSoLuongNu.Text = doanVienDAO.getSoLuongNuDoanTruong();

                }
                else
                {
                    comboChiDoanSearchField.Enabled = true;

                    ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                    comboChiDoanSearchField.DataSource = chiDoanDAO.getTatCaTenChiDoanThuocMotDoanKhoa((string)comboDoanKhoaSearchField.SelectedItem);
                }
            }
        }

        
        private void comboChiDoan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboChiDoan.SelectedIndex >= 0)
            {
                DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
                lbTenDoanKhoa.Text = doanKhoaDAO.getTenDoanKhoaTuTenMotChiDoan(this.comboChiDoan.SelectedValue.ToString());
            }
        }

        private void comboChiDoanSearchField_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboChiDoanSearchField.SelectedIndex >= 0)
            {
                if (comboChiDoanSearchField.SelectedValue.ToString() == "Tất cả Chi Đoàn")
                {
                    DoanVienDAO doanVienDAO = new DoanVienDAO();
                    DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
                    string maDoanKhoa = doanKhoaDAO.getMaDoanKhoaTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString());
                    this.dataGridView.DataSource = doanVienDAO.getDSDoanVienTuMotDoanKhoa(maDoanKhoa).ToList();
                    this.lbTenCoSo.Text = this.comboDoanKhoaSearchField.SelectedValue.ToString();
                    this.lbSoLuongCoSo.Text = doanKhoaDAO.getSoLuongDoanVienTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString().Trim());
                    this.lbSoLuongNam.Text = doanKhoaDAO.getSoLuongDoanVienNamTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString());
                    this.lbSoLuongNu.Text = doanKhoaDAO.getSoLuongDoanVienNuTuTenDoanKhoa(this.comboDoanKhoaSearchField.SelectedValue.ToString());
                }
                else
                {
                    DoanVienDAO doanVienDAO = new DoanVienDAO();
                    ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                    string maChiDoan = chiDoanDAO.getMaChiDoanBangTen(this.comboChiDoanSearchField.SelectedValue.ToString());
                    this.dataGridView.DataSource = doanVienDAO.getDSDoanVienTuMotChiDoan(maChiDoan).ToList();
                    this.lbTenCoSo.Text = this.comboChiDoanSearchField.SelectedValue.ToString();
                    this.lbSoLuongCoSo.Text = chiDoanDAO.getSoLuongDoanVienTuTenChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString().Trim());
                    this.lbSoLuongNam.Text = chiDoanDAO.getSoLuongNamTuChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString());
                    this.lbSoLuongNu.Text = chiDoanDAO.getSoLuongNuTuChiDoan(this.comboChiDoanSearchField.SelectedValue.ToString());

                }
            }
        }

        private void btnSearchTheoTen_Click(object sender, EventArgs e)
        {
            DoanVienDAO doanvienDAO = new DoanVienDAO();
            dataGridView.DataSource = doanvienDAO.timTheoTenDoanVien(this.txtSearchField.Text).ToList();
        }

        private void comboNangCao_DoanKhoa_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboNangCao_DoanKhoa.SelectedIndex >= 0)
            {
                comboNangCao_ChiDoan.DataSource = null;

                if (comboNangCao_DoanKhoa.SelectedValue.ToString() == "Tất cả Đoàn Khoa")
                {
                    comboNangCao_ChiDoan.Enabled = false;
                    DoanVienDAO doanVienDAO = new DoanVienDAO();
                }
                else
                {
                    comboNangCao_ChiDoan.Enabled = true;

                    ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
                    comboNangCao_ChiDoan.DataSource = chiDoanDAO.getTatCaTenChiDoanThuocMotDoanKhoa((string)comboNangCao_DoanKhoa.SelectedItem);
                }
            }
        }

        private void btnTimKiemNangCao_Click(object sender, EventArgs e)
        {
            DoanVienDAO doanVienDAO = new DoanVienDAO();
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
            if (comboNangCao_DoanKhoa.SelectedValue.ToString() == "Tất cả Đoàn Khoa")
            {
                this.dataGridView.DataSource = doanVienDAO.timNangCaoToanTruong(this.txtNangCao_TheoTen.Text, this.comboNangCao_GioiTinh.SelectedItem.ToString(), this.comboNangCao_DanToc.SelectedItem.ToString(), this.comboNangCao_TonGiao.SelectedItem.ToString()).ToList();
            }
            else
            {
                if (comboNangCao_ChiDoan.SelectedValue.ToString() == "Tất cả Chi Đoàn")
                {
                    this.dataGridView.DataSource = doanVienDAO.timNangCaoToanKhoa(this.comboNangCao_DoanKhoa.SelectedItem.ToString(),this.txtNangCao_TheoTen.Text, this.comboNangCao_GioiTinh.SelectedItem.ToString(), this.comboNangCao_DanToc.SelectedItem.ToString(), this.comboNangCao_TonGiao.SelectedItem.ToString()).ToList();
                }else
                {
                    this.dataGridView.DataSource = doanVienDAO.timNangCaoTheoKhoaVaChiDoan(this.comboNangCao_ChiDoan.SelectedItem.ToString(),this.comboNangCao_DoanKhoa.SelectedItem.ToString(), this.txtNangCao_TheoTen.Text, this.comboNangCao_GioiTinh.SelectedItem.ToString(), this.comboNangCao_DanToc.SelectedItem.ToString(), this.comboNangCao_TonGiao.SelectedItem.ToString()).ToList();

                }
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dataGridView.Rows[hti.RowIndex].Selected = true;
                }
                ContextMenuStrip optionRightClick = new ContextMenuStrip();
                if (hti.RowIndex >= 0)
                {
                    optionRightClick.Items.Add("Chuyển sinh hoạt đoàn viên này").Name = "Chuyển";
                    optionRightClick.Items.Add("Chỉnh sửa thân nhân đoàn viên này").Name = "Thân nhân";
                    optionRightClick.Items.Add("Phê đoàn viên này").Name = "Phê";
                    optionRightClick.Show(dataGridView, new Point(e.X, e.Y));
                    optionRightClick.ItemClicked += new ToolStripItemClickedEventHandler(ItemChuyenSinhHoat_Click);
                }
            }
        }

        private void ItemChuyenSinhHoat_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "Chuyển")
            {
                selectedDoanVien = this.selected;
                Form form = new ChuyenSinhHoatDoan_View(this);
                form.Show();
            }
            else if (e.ClickedItem.Name == "Thân nhân")
            {
                selectedDoanVien = this.selected;
                Form form = new ChinhSuaThanNhan(this);
                form.Show();
            }
            else if (e.ClickedItem.Name == "Phê")
            {
                selectedDoanVien = this.selected;
                //here maTaiKhoan = "";
                Form form = new PheSoDoan_View(this);
                form.Show();
            }

        }

        private void btnTaoDotDanhGIa_Click(object sender, EventArgs e)
        {
            Form form = new TaoDotDanhGia(this);
            form.Show();
        }
    }
}
