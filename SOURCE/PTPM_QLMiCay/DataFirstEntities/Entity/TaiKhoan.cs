using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public string TK_Id  { get; set; } 

        public string TK_Ten { get; set; }

        public string TK_MatKhau { get; set;}

        public string TK_NhanVien { get; set; }
        [ForeignKey("TK_NhanVien")]
        public virtual NhanVien NhanVien { get; set; }

        public string TK_NguoiDung { get; set; }
        [ForeignKey("TK_NguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
