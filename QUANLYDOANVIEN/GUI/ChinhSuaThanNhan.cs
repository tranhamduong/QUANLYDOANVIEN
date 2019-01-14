using QUANLYDOANVIEN.DAO;
using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
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
    public partial class ChinhSuaThanNhan : Form
    {
        private QL_DoanVien_View qL_DoanVien_View;
        private string maDoanVien;
        private string selected;
        public ChinhSuaThanNhan()
        {
            InitializeComponent();
        }

        public ChinhSuaThanNhan(QL_DoanVien_View qL_DoanVien_View)
        {
            InitializeComponent();
            this.qL_DoanVien_View = qL_DoanVien_View;
            maDoanVien = QL_DoanVien_View.selectedDoanVien;
        }

        private void ChinhSuaThanNhan_Load(object sender, EventArgs e)
        {
            ThanNhanDAO thanNhanDAO = new ThanNhanDAO();
            DoanVienDAO doanVienDAO = new DoanVienDAO();
            this.dataGridView.DataSource = thanNhanDAO.layTatCaThanNhan(maDoanVien).ToList();
            this.dataGridView.MultiSelect = false;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.lbTenDoanVien.Text = doanVienDAO.getTenDoanVienTuMa(maDoanVien);
            this.groupBox1.Enabled = false;

            this.comboMoiQuanHe.SelectedIndex = 0;
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThanNhanDAO thanNhanDAO = new ThanNhanDAO();
            thanNhanDAO.xoa(selected);
            this.dataGridView.DataSource = thanNhanDAO.layTatCaThanNhan(maDoanVien).ToList();

        }

        public IEnumerable<Control> GetAllControlByType(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControlByType(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count > 0)
            {
                this.selected = this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Xác nhận";
                btnThem.BackColor = Color.Green;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                groupBox1.Enabled = true;
            }
            else
            {
                ThanNhanDAO thanNhanDAO = new ThanNhanDAO();

                bool flag = false;
                var listInput = GetAllControlByType(this.groupBox1, this.txtGhiChu.GetType());
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
                    ThanNhanDTO dto = new ThanNhanDTO();
                    dto.setMaDoanVien(maDoanVien);
                    dto.setHoTen(this.txtHoTen.Text);
                    dto.setMoiQuanHe(this.comboMoiQuanHe.Text);
                    dto.setNgheNghiep(this.txtNgheNghiep.Text);
                    dto.setDanToc(this.txtDanToc.Text);
                    dto.setTonGiao(this.txtTonGiao.Text);
                    dto.setQuocTich(this.txtQuocTich.Text);
                    dto.setGhiChu(this.txtGhiChu.Text);
                    dto.setQueQuan(this.txtQueQuan.Text);

                    thanNhanDAO.themThanNhan(dto);
                    MessageBox.Show("Thêm thân nhân thành công!");
                    this.dataGridView.DataSource = thanNhanDAO.layTatCaThanNhan(maDoanVien).ToList();

                }
                groupBox1.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Text = "Thêm";
                btnThem.BackColor = SystemColors.Control;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.btnSua.Text == "Sửa")
            {
                btnSua.Text = "Xác nhận";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                groupBox1.Enabled = true;
                btnSua.BackColor = Color.Green;

                ThanNhanDAO dao = new ThanNhanDAO();
                ThanNhanDTO dto = new ThanNhanDTO();
                THANNHAN tn = dao.layMotThanNhanTuMa(selected);
                dto = ThanNhanDTO.reConvertToDTO(tn);

                this.txtHoTen.Text = dto.getHoTen();
                this.comboMoiQuanHe.Text = dto.getMoiQuanHe();
                this.txtQueQuan.Text = dto.getQueQuan();
                this.txtDanToc.Text = dto.getDanToc();
                this.txtQuocTich.Text = dto.getQuocTich();
                this.txtTonGiao.Text = dto.getTonGiao();
                this.txtGhiChu.Text = dto.getGhiChu();
                this.txtNgheNghiep.Text = dto.getNgheNghiep();
            }
            else
            {
                ThanNhanDAO thanNhanDAO = new ThanNhanDAO();

                bool flag = false;
                var listInput = GetAllControlByType(this.groupBox1, this.txtGhiChu.GetType());
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
                    ThanNhanDTO dto = new ThanNhanDTO();
                    dto.setMaDoanVien(maDoanVien);
                    dto.setHoTen(this.txtHoTen.Text);
                    dto.setMoiQuanHe(this.comboMoiQuanHe.Text);
                    dto.setNgheNghiep(this.txtNgheNghiep.Text);
                    dto.setDanToc(this.txtDanToc.Text);
                    dto.setTonGiao(this.txtTonGiao.Text);
                    dto.setQuocTich(this.txtQuocTich.Text);
                    dto.setGhiChu(this.txtGhiChu.Text);
                    dto.setQueQuan(this.txtQueQuan.Text);
                    dto.setMaThanNhan(selected);

                    thanNhanDAO.suaNhanVien(dto);
                    MessageBox.Show("Sửa thân nhân thành công!");
                    this.dataGridView.DataSource = thanNhanDAO.layTatCaThanNhan(maDoanVien).ToList();

                }

                groupBox1.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Text = "Sửa";
                btnSua.BackColor = SystemColors.Control;
            }
        }
    }
}
