using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("DanhMuc")]
    public class DanhMuc
    {
        [Key]
        public int DM_Id { get; set; }
        public string DM_Ten { get; set;}
        public string QA_DiaChi { get; set;}
        [ForeignKey("QA_DiaChi")]
        public virtual QuanAn QuanAn { get; set; }
    }
}
