using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public string NV_Id { get; set; }
        [MaxLength(50)]
        public string NV_Ten { get; set; }

        public string NV_GioiTinh { get; set; }

        public DateTime NV_NgaySinh { get; set; }
        [MaxLength(50)]
        public string NV_DiaChi { get; set; }
        public string NV_SDT { get; set; }
        public string NV_TinhTrang { get; set; }
        [MaxLength(50)]
        public string QA_DiaChiId { get; set; }
        [ForeignKey("QA_DiaChiId")]
        public virtual QuanAn QuanAn { get; set; }


    }
}
