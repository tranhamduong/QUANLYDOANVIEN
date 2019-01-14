using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class ChiTietChuyenSinhHoatDoanDAO
    {
        QLDOANVIEN_DATABASE db;
        public ChiTietChuyenSinhHoatDoanDAO()
        {
            db = new QLDOANVIEN_DATABASE();
        }
        public void luuChiTietChuyenSinhHoatDoan(ChiTietChuyenSinhHoatDoanDTO dto)
        {
            CHITIETCHUYENSINHHOATDOAN entity =  dto.ConvertToEntity();
            entity.MaChiTiet = taoMaChuyenSinhHoatDoan();
            db.CHITIETCHUYENSINHHOATDOANs.Add(entity);
            db.SaveChanges();
        }

        public string taoMaChuyenSinhHoatDoan()
        {
            int temp = db.CHITIETCHUYENSINHHOATDOANs.Count();
            string ma = "CSHD" + temp;
            return ma;
        }
    }
}
