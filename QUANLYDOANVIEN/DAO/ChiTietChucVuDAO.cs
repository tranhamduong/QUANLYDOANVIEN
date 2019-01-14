using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;

namespace QUANLYDOANVIEN.DAO
{
    public class ChiTietChucVuDAL
    {
        private QLDOANVIEN_DATABASE db = new QLDOANVIEN_DATABASE();

        public List<ChiTietChucVuDTO> GetListChiTietChucVu()
        {
            var data = db.CHITIETCHUCVUs.Where(p => p.IsDeleted != true)
            .Select(p => new ChiTietChucVuDTO()
            {
                MaChiTiet = p.MaChiTiet,
                MaDoanVien = p.MaDoanVien,
                MaChucVu = p.MaChucVu,
                //NgayBatDau = p.NgayBatDau,
                //NgayKetThuc = p.NgayKetThuc,
                IsDeleted = p.IsDeleted
            }).ToList();
            return data;
        }

        public bool Insert(ChiTietChucVuDTO chiTietChucVuDTO)
        {
            chiTietChucVuDTO.MaChiTiet = CreateID("CTCV");
            db.CHITIETCHUCVUs.Add(new CHITIETCHUCVU()
            {
                MaChiTiet = chiTietChucVuDTO.MaChiTiet,
                MaDoanVien = chiTietChucVuDTO.MaDoanVien,
                MaChucVu = chiTietChucVuDTO.MaChucVu,
                //NgayBatDau = chiTietChucVuDTO.NgayBatDau,
                NhiemKy = chiTietChucVuDTO.NhiemKy,
                //NgayKetThuc = chiTietChucVuDTO.NgayKetThuc,
                IsDeleted = chiTietChucVuDTO.IsDeleted
            });
            db.SaveChanges();
            return true;
        }

        public bool Update(ChiTietChucVuDTO chiTietChucVuDTO)
        {
            var entity = db.CHITIETCHUCVUs.Find(chiTietChucVuDTO.MaChiTiet);
            if (entity == null)
            {
                return false;
            }
            db.Entry(entity).CurrentValues.SetValues(chiTietChucVuDTO);
            db.SaveChanges();
            return true;
        }

        public bool Remove(ChiTietChucVuDTO chiTietChucVuDTO)
        {
            var entity = db.CHITIETCHUCVUs.Find(chiTietChucVuDTO.MaChiTiet);
            chiTietChucVuDTO.IsDeleted = true;
            if (entity == null)
            {
                return false;
            }
            db.Entry(entity).CurrentValues.SetValues(chiTietChucVuDTO);
            db.SaveChanges();
            return true;
        }

        public bool LaySoLuongUVTrongNhiemKy(string nhiemKy = "", string maCoSoDoan = "")
        {

            return true;
        }

        private string CreateID(string Id)
        {
            string stringID = Id;
            var num = db.CHITIETCHUCVUs.ToList().Count() + 1;
            stringID += num.ToString("000");
            return stringID;
        }
    }
}
