using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("LoaiTinTuc")]
    public class LoaiTinTuc
    {
        [Key]
        public int LoaiTin_Id { get; set; }
        public string TenLoaiTin { get; set; }
    }
}
