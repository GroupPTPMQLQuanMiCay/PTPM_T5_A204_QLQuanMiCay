using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("ChiTietNhap")]
    public class ChiTietNhap
    {
        [Key]
        [Column(Order = 1)]
        public int NL_Id { get; set; }
        [ForeignKey("NL_Id")]
        public virtual NguyenLieu NguyenLieu { get; set; }

        [Key]
        [Column(Order = 2)]
        public int HDN_Id{ get; set; }
        [ForeignKey("HDN_Id")]
        public virtual HoaDonNhap HoaDonNhap { get; set; }

        public int CTN_SoLuong { get; set; }

        public int CTN_Gia { get; set; }

    }
}
