using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int HD_Id { get;set; }

        public string NV_Id { get; set; }
        [ForeignKey("NV_Id")]
        public virtual NhanVien NhanVien { get; set; }

        public int B_SoBan { get; set; }
        [ForeignKey("B_SoBan")]
        public virtual Ban Ban { get; set; }

        public int HD_ThanhTien { get;set; }   
        public DateTime HD_NgayXuat { get; set; }

        public int HD_TrangThai { get; set; }

    }
}
