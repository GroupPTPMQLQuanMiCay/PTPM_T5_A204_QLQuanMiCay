using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("HoaDonNhap")]
    public class HoaDonNhap
    {
        [Key]
        public int HDN_Id { get; set; }

        public string NV_Id { get; set; }
        [ForeignKey("NV_Id")]
        public virtual NhanVien NhanVien { get; set; }

        public DateTime HDN_Ngaynhap { get; set; }
        public int HDN_ThanhTien { get; set; }

        public int PD_Id { get; set; }
        [ForeignKey("PD_Id")]
        public virtual PhieuDat PhieuDat { get; set; }
    }
}
