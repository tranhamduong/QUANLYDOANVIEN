using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class ChiDoanDAO
    {
        QLDOANVIEN_DATABASE db;

        public ChiDoanDAO()
        {
            db = new QLDOANVIEN_DATABASE();
        }

        public List<string> getTatCaTenChiDoan()
        {
            db = new QLDOANVIEN_DATABASE();
            return db.CHIDOANs.Where(x => x.IsDeleted == false ).OrderBy(x => x.TenChiDoan).Select(x => x.TenChiDoan).ToList<string>();
        }

        public string getMaChiDoanBangTen(string tenChiDoan)
        {
            db = new QLDOANVIEN_DATABASE();
            return db.CHIDOANs.Where(x => x.TenChiDoan == tenChiDoan).Select(x => x.MaChiDoan).FirstOrDefault();
        }

        internal List<string> getTenChiDoanBangMa(string v)
        {
            db = new QLDOANVIEN_DATABASE();
            return db.CHIDOANs.Where(x => x.MaChiDoan == v && x.IsDeleted == false).OrderBy(x=>x.TenChiDoan).Select(x => x.TenChiDoan).ToList<string>();
        }

        public List<string> getTatCaTenChiDoanThuocMotDoanKhoa(string tenDoanKhoa)
        {
            db = new QLDOANVIEN_DATABASE();
            DoanKhoaDAO dao = new DoanKhoaDAO();
            string maDoanKhoa = dao.getMaDoanKhoaTuTenDoanKhoa(tenDoanKhoa);
            List<string> list = new List<string>();
            list =  db.CHIDOANs.Where(x => x.MaDoanKhoa == maDoanKhoa && x.IsDeleted == false).OrderBy(x => x.TenChiDoan).Select(x => x.TenChiDoan).ToList<string>();
            list.Add("Tất cả Chi Đoàn");
            return list;
        }

        public string getMaDoanKhoaTuMaChiDoan(string maChiDoan)
        {
            db = new QLDOANVIEN_DATABASE();
            return db.CHIDOANs.Where(x => x.MaChiDoan == maChiDoan && (x.IsDeleted == false || x.IsDeleted == true)).Select(x => x.MaDoanKhoa).FirstOrDefault();
        }

        public string getSoLuongDoanVienTuTenChiDoan(string tenChiDoan)
        {
            db = new QLDOANVIEN_DATABASE();
            string maChiDoan = db.CHIDOANs.Where(x => x.TenChiDoan == tenChiDoan && x.IsDeleted == false).Select(x => x.MaChiDoan).FirstOrDefault().ToString();
            return db.DOANVIENs.Where(x => x.MaChiDoan == maChiDoan && x.IsDeleted == false).Count().ToString();
        }

        public string getSoLuongNamTuChiDoan(string tenChiDoan)
        {
            string maChiDoan = db.CHIDOANs.Where(x => x.TenChiDoan == tenChiDoan && x.IsDeleted == false).Select(x => x.MaChiDoan).FirstOrDefault().ToString();
            return db.DOANVIENs.Where(x => x.MaChiDoan == maChiDoan && x.GioiTinh == true && x.IsDeleted == false).Count().ToString();
        }

        public string getSoLuongNuTuChiDoan(string tenChiDoan)
        {
            string maChiDoan = db.CHIDOANs.Where(x => x.TenChiDoan == tenChiDoan && x.IsDeleted == false).Select(x => x.MaChiDoan).FirstOrDefault().ToString();
            return db.DOANVIENs.Where(x => x.MaChiDoan == maChiDoan && x.GioiTinh == false && x.IsDeleted == false).Count().ToString();
        }

        public string getTenChiDoanTuMaChiDoan(string maChiDoan)
        {
            return db.CHIDOANs.Where(x => x.MaChiDoan == maChiDoan &&  x.IsDeleted == false).Select(x => x.TenChiDoan).FirstOrDefault().ToString();
        }
    }
}
