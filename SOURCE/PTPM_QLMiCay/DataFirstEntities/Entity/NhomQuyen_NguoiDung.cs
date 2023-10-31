using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NhomQuyen_NguoiDung")]
    public class NhomQuyen_NguoiDung
    {
        [Key]
        [Column(Order = 1)]
        public string NG_Id { get; set; }
        [MaxLength(50)]
        [ForeignKey("NG_Id")]
        public virtual NguoiDung NguoiDung { get; set; }

        [Key]
        [Column(Order = 2)]
        public string NQ_Id { get; set; }
        [ForeignKey("NQ_Id")]
        public virtual NhomQuyen NhomQuyen { get; set; }
    }
}
