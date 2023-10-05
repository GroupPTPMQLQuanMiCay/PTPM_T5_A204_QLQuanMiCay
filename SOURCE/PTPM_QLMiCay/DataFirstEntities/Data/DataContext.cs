using DataFirstEntities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Server=DESKTOP-U88ERP0;Database=QLQuanMiCay;Trusted_Connection=True;")
        {
        
        }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<QuanAn> QuanAns { get; set; }
        public DbSet<NguyenLieu>NguyenLieus { get; set; }
        public DbSet<NhaCungCap>NhaCungCaps { get; set; }
        public DbSet<PhieuDat> phieuDats { get; set; }
        public DbSet<ChiTietPhieuDat>ChiTietPhieuDats { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<ChiTietNhap> ChiTietNhaps { get; set; }    
        public DbSet<GiaNguyenLieu> GiaNguyenLieus { get;set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<QuanLyBep> QuanLyBeps { get; set; }
        public DbSet<NLTuongDong> NLTuongDongs { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<TinhTrangThucHien>TinhTrangThucHiens { get; set; }
        public DbSet<TinhTrangMon>TinhTrangMons { get; set; }
        public DbSet<Mon> Mons { get;set; }
        public DbSet<OrDer> orDers { get; set; }
        public DbSet<MonCoNguyenLieu> MonCoNguyenLieus { get; set; }
    }
}
