using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("TinhTrangThucHien")]
    public class TinhTrangThucHien
    {
        [Key]
        public int Ma_TT { get; set; }
        public string Ma_DienGiai { get;set; }
    }
}
