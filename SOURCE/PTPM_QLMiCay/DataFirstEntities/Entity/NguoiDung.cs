using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NguoiDung")]
    public class NguoiDung 
    {
        [Key]
        public string NG_Id { get; set; }
        [MaxLength(50)]
        public string NG_DiaChi { get; set;}
        [MaxLength(50)]
        public string NG_PhongBan { get; set; }
        [MaxLength(20)]
        public string NG_MatKhau { get; set; }
    }
}
