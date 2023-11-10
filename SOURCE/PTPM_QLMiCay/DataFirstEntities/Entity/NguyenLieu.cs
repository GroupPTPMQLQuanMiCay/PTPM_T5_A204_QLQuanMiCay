using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NguyenLieu")]
    public class NguyenLieu
    {
        [Key]
        public int NL_Id { get; set; }
        [MaxLength(50)]
        public string NL_Ten { get; set; }
        public string NL_DonViTinh { get; set; }
        public int NL_SoLuong { get; set; }
        public int NCC_Id { get; set; }
        [ForeignKey("NCC_Id")]
        public virtual NhaCungCap NhaCungCap { get; set; }
        public string createdBy { get; set; }
        public DateTime createdAt { get; set; }
        public string updatedBy { get; set; }
        public DateTime updatedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
