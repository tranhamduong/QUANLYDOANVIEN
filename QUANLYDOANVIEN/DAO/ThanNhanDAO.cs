using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class ThanNhanDAO
    {
        QLDOANVIEN_DATABASE db;
        public ThanNhanDAO()
        {
            db = new QLDOANVIEN_DATABASE();
        }

        public IQueryable<object> layTatCaThanNhan(string maDoanVien)
        {
            var array = from c in db.THANNHANs
                        where c.IsDeleted == false && c.MaDoanVien == maDoanVien
                        select new
                        {
                            c.MaThanNhan,
                            c.MoiQuanHe,
                            c.HoTen,
                            c.QueQuan,
                            c.QuocTich,
                            c.NgheNghiep,
                            c.TonGiao,
                            c.GhiChu
                        };
            return array;
        }

        public void themThanNhan(ThanNhanDTO dto)
        {
            THANNHAN entity = new THANNHAN();
            entity = dto.ConvertToEntity();
            entity.MaThanNhan = taoMaThanNhan();
            entity.IsDeleted = false;
            db.THANNHANs.Add(entity);
            db.SaveChanges();
        }

        private string taoMaThanNhan()
        {
            string ma = "";
            string count = db.THANNHANs.Count().ToString();
            int tienTo = 5 - db.THANNHANs.Count().ToString().Length;
            if (tienTo < 0) { }
            else
            {
                for (int i = 1; i <= tienTo; i++)
                {
                    ma = "0" + ma;
                }
            }
            return "TN" + count;
        }

        internal void xoa(string selected)
        {
            var res = db.THANNHANs.Where(x => x.IsDeleted == false && x.MaThanNhan == selected).FirstOrDefault();
            res.IsDeleted = true;
            db.SaveChanges();
        }

        internal void suaNhanVien(ThanNhanDTO dto)
        {
            string maThanNhan = dto.getMaThanNhan();
            var res = db.THANNHANs.Where(x => x.IsDeleted == false && x.MaThanNhan == maThanNhan).FirstOrDefault();

            res.HoTen = dto.getHoTen();
            res.MoiQuanHe = dto.getMoiQuanHe();
            res.NgheNghiep = dto.getNgheNghiep();
            res.QueQuan = dto.getQueQuan();
            res.QuocTich = dto.getQuocTich();
            res.TonGiao = dto.getTonGiao();
            res.DanToc = dto.getDanToc();
            res.GhiChu = dto.getGhiChu();

            db.SaveChanges();
        }

        public THANNHAN layMotThanNhanTuMa(string maThanNhan)
        {
            THANNHAN tn = db.THANNHANs.Where(x => x.IsDeleted == false && x.MaThanNhan == maThanNhan).FirstOrDefault();

            return tn;
        }
    }
}
