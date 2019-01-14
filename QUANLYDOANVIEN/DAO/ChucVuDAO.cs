using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;

namespace QUANLYDOANVIEN.DAO
{
    public class ChucVuDAL
    {
        private QLDOANVIEN_DATABASE db = new QLDOANVIEN_DATABASE();

        public List<ChucVuDTO> GetListChucVu()
        {
            var data = db.CHUCVUs.Where(p=>p.IsDeleted!=true)
                .Select(p => new ChucVuDTO() {
                MaChucVu = p.MaChucVu,
                TenChucVu = p.TenChucVu,
                Cap = p.Cap,
                IsDeleted = p.IsDeleted }).ToList();
            return data;
        }

        public List<ChucVuDTO> GetListChucVuByCap(string maCap = "")
        {
            if (maCap == "") return GetListChucVu();
            var data = db.CHUCVUs.Where(p => p.IsDeleted != true && p.Cap == maCap)
                .Select(p => new ChucVuDTO()
                {
                    MaChucVu = p.MaChucVu,
                    TenChucVu = p.TenChucVu,
                    Cap = p.Cap,
                    IsDeleted = p.IsDeleted
                }).ToList();
            return data;
        }

        public int GetIndexMaChucVu(string maChucVu = "", string maCap = "")
        {
            int num = 0;
            if (maChucVu == "") return num;
            if (maCap == "")
            {
                num = db.CHUCVUs.ToList().FindIndex(p => p.MaChucVu == maChucVu);
            }
            else
            {
                num = db.CHUCVUs.Where(p => p.Cap == maCap).ToList().FindIndex(p => p.MaChucVu == maChucVu);
            }
            return num;
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
