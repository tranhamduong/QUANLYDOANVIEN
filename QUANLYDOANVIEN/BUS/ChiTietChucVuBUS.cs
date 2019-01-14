using QUANLYDOANVIEN.DAO;
using QUANLYDOANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.BUS
{
    public class ChiTietChucVuBUS
    {
        private ChiTietChucVuDAL ChiTietChucVuDAL = new ChiTietChucVuDAL();

        public List<ChiTietChucVuDTO> GetListChiTietChucVu()
        {
            return ChiTietChucVuDAL.GetListChiTietChucVu();
        }

        public bool Insert(ChiTietChucVuDTO chiTietChucVuDTO)
        {
            return ChiTietChucVuDAL.Insert(chiTietChucVuDTO);
        }

        public bool Update(ChiTietChucVuDTO chiTietChucVuDTO)
        {
            return ChiTietChucVuDAL.Update(chiTietChucVuDTO);
        }

        public bool Remove(ChiTietChucVuDTO chiTietChucVuDTO)
        {
            return ChiTietChucVuDAL.Remove(chiTietChucVuDTO);
        }
    }
}
