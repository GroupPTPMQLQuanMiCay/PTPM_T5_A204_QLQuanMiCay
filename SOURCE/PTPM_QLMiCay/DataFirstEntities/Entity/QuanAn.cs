using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("QuanAn")]
    public class QuanAn
    {
        [Key]
        [MaxLength(50)]
        public string QA_DiaChi { get; set; }
        public string QA_Chu { get; set; }
        public string QA_Ten { get; set; }
        public string QA_TK { get; set; }
        public string QA_MK { get; set; }
    }
}
