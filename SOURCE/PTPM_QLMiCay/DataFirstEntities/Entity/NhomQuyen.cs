using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("NhomQuyen")]
    public class NhomQuyen
    {
        [Key]
        public string NQ_Id { get; set; }

        public string NQ_Ten { get; set; }
        [MaxLength(50)]

        public string NQ_HienThi { get; set; }
    }
}
