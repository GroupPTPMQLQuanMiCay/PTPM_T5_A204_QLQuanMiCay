using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("Mon_Co_NL")]
    public class MonCoNguyenLieu
    {
        [Key]
        [Column(Order = 1)]
        public int NL_Id { get; set; }
        [ForeignKey("NL_Id")]
        public virtual NguyenLieu NguyenLieu { get; set; }

        [Key]
        [Column(Order = 2)]
        public string M_Ten { get; set; }
        [ForeignKey("M_Ten")]
        public virtual Mon Mon { get; set; }

        public string MNL_DonViTinh { get;set; }
        public int MNL_SoLuong { get; set; }
    }
}
