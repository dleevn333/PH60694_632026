using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH60694_632026
{
    public class NhanVienService
    {
        private List<NhanVien> listNhanVien = new List<NhanVien>()
        { 
        new NhanVien() { maNV = "NV01", Ten = "Nguyen Van A", luong = 5000, soNamLamViec = 5, phongBan = "IT" },
        new NhanVien() { maNV = "NV02", Ten = "Tran Thi B", luong = 6000, soNamLamViec = 3, phongBan = "HR" },
        new NhanVien() { maNV = "NV03", Ten = "Le Van C", luong = 5500, soNamLamViec = 7, phongBan = "IT" },
        };
        public bool KiemTraToiTaiRoi(string maNV)
        {
            return listNhanVien.Any(nv => nv.maNV == maNV);
        }
        public bool SuaNhanVien(NhanVien nhanVienMoi)
        {
            if(nhanVienMoi == null || string.IsNullOrEmpty(nhanVienMoi.maNV)) return false;
            var nhanVienSua = listNhanVien.FirstOrDefault(nv => nv.maNV == nhanVienMoi.maNV);
            if(nhanVienSua == null) return false;
            if(nhanVienMoi.luong < 0 || nhanVienMoi.soNamLamViec < 0) return false;
            nhanVienSua.Ten = nhanVienMoi.Ten;
            nhanVienSua.luong = nhanVienMoi.luong;
            nhanVienSua.soNamLamViec = nhanVienMoi.soNamLamViec;
            nhanVienSua.phongBan = nhanVienMoi.phongBan;
            return true;
        }
        public NhanVien? GetByMaNhanVien(string ma) 
        { 
        return listNhanVien.FirstOrDefault(nv => nv.maNV == ma);
        }
    }
}
