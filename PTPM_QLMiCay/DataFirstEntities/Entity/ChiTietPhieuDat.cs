using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("CTPhieuDat")]
    public class ChiTietPhieuDat
    {
        [Key]
        [Column(Order = 1)]
        public int PD_Id { get; set; }
        [ForeignKey("PD_Id")]
        public virtual PhieuDat PhieuDat { get; set; }

        [Key]
        [Column(Order = 2)]
        public int NL_Id { get; set; }
        [ForeignKey("NL_Id")]
        public virtual NguyenLieu NguyenLieu { get; set; }

        public int soluong { get; set; }
        public int DaGiao { get; set; }
    }
}
