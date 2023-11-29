using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_Order
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        public DAL_Order()
        {

        }
        //private int GenerateUniqueHD_Id()
        //{
        //    // Lấy ID lớn nhất hiện tại trong bảng HOADON
        //    int soBan;
        //    // Kiểm tra xem có hóa đơn nào cho số bàn này chưa
        //    var existingHoaDon = _context.HoaDons.FirstOrDefault(hd => hd.B_SoBan == soBan && hd.HD_TrangThai==0);
        //    int currentMaxId = _context.HoaDons.Max(hd => (int?)hd.HD_Id) ?? 0;

        //    // Sinh HD_Id mới là ID lớn nhất hiện tại + 1
        //    int newHD_Id = currentMaxId + 1;

        //    // Thêm hóa đơn mới vào bảng HOADON
        //    HoaDon newHoaDon = new HoaDon
        //    {
        //        HD_Id = newHD_Id,
        //        HD_TrangThai = 0,
        //        HD_NgayXuat = DateTime.Now
               
        //    };

        //    _context.HoaDons.InsertOnSubmit(newHoaDon);
        //    _context.SubmitChanges();

        //    return newHD_Id;
        //}
        //public void inserNewOrder(string tenMon,int donGia, int sl, int gia, string ghiChu, DateTime thoiGian)
        //{
        //    int newHD_Id = GenerateUniqueHD_Id();
        //    OrDer o = new OrDer
        //    {
        //        M_Ten = tenMon,
        //        HD_Id = newHD_Id,
        //        O_DonGia = donGia,
        //        O_SoLuong = sl,
        //        O_Gia = gia,
        //        O_GhiChu = ghiChu,
        //        O_ThoiGian = thoiGian
        //    };
        //    _context.OrDers.InsertOnSubmit(o);
        //    _context.SubmitChanges();
        //}
    }
}
