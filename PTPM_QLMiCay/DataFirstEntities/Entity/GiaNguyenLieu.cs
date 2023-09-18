using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("GiaNguyenLieu")]
    public class GiaNguyenLieu
    {
        [Key]
        [Column(Order = 1)]
        public int NL_Id { get; set; }
        [ForeignKey("NL_Id")]
        public virtual NguyenLieu NguyenLieu { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayThayDoi { get; set;}

        public int NL_Gia { get; set; }

        public string NV_Id { get; set; }
        [ForeignKey("NV_Id")]
        public virtual NhanVien NhanVien { get; set; }


    }
}
