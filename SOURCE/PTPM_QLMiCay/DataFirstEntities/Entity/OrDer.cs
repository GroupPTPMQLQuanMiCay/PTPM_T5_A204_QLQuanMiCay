using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("OrDer")]
    public class OrDer
    {
        [Key]
        [Column(Order = 1)]
        public string M_Ten { get; set; }
        [ForeignKey("M_Ten")]
        public virtual Mon Mon { get; set; }


        [Key]
        [Column(Order = 2)]
        public int HD_Id { get; set; }
        [ForeignKey("HD_Id")]
        public virtual HoaDon HoaDon { get; set; }

        public int O_SoLuong { get; set; }
        public int O_Gia { get; set; }  
        public string O_GhiChu { get;set; }
        public DateTime O_ThoiGian { get; set; }
    }
}
