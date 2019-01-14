using QUANLYDOANVIEN.DAO;
using QUANLYDOANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.BUS
{
    public class ChucVuBUS
    {
        private ChucVuDAL ChucVuDAL = new ChucVuDAL();

        public List<ChucVuDTO> GetListChucVu()
        {
            return ChucVuDAL.GetListChucVu();
        }

        public List<ChucVuDTO> GetListChucVuByCap(string maCap)
        {
            return ChucVuDAL.GetListChucVuByCap(maCap);
        }

        public int GetIndexMaChucVu(string maChucVu, string maCap)
        {
            return ChucVuDAL.GetIndexMaChucVu(maChucVu, maCap);
        }

    }
}
