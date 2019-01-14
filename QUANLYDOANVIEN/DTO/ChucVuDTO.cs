using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DTO
{
    public class ChucVuDTO
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string Cap { get; set; }
        public bool? IsDeleted { get; set; }

        //Constructor
        public ChucVuDTO()
        {
            MaChucVu = "";
            TenChucVu = "";
            Cap = "";
            IsDeleted = false;
        }

        public ChucVuDTO(string MaChucVu, string TenChucVu, string Cap, bool? IsDeleted)
        {
            this.MaChucVu = MaChucVu;
            this.TenChucVu = TenChucVu;
            this.Cap = Cap;
            this.IsDeleted = IsDeleted;
        }


    }
}
