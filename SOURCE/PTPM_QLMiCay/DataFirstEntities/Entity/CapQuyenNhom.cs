using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{

    [Table("CapQuyenNhom")]
    public class CapQuyenNhom
    {
        [Key]
        [Column(Order = 1)]
        public string NQ_Id { get; set; }
        [ForeignKey("NQ_Id")]
        public virtual NhomQuyen NhomQuyen { get; set; }

        [Key]
        [Column(Order = 2)]
        public string MH_Id { get; set; }
        [ForeignKey("MH_Id")]
        public virtual ManHinh ManHinh { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Quyen_Id { get; set; }
        [ForeignKey("Quyen_Id")]
        public virtual Quyen Quyen { get; set; }
    }
}
