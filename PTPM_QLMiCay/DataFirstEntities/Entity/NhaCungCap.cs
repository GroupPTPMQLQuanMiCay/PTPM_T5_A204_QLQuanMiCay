using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        [Key]
        public int NCC_Id { get; set; }
        [MaxLength(50)]
        public string NCC_Ten { get; set; }
        public string NCC_SDT { get; set; }
        [MaxLength(50)]
        public string NCC_DiaChi { get; set; }

    }
}
