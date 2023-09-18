using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NL_TuongDong")]
    public class NLTuongDong
    {
        [Key]
        public int STT { get; set; }

        public int NL_Id { get; set; }
        [ForeignKey("NL_Id")]
        public virtual NguyenLieu NguyenLieu { get; set; }

        public string NL_DonViTinh { get; set; }
        public int NL_SoLuong { get; set; }

        public int STT_ThayCho { get; set; }

    }
}
