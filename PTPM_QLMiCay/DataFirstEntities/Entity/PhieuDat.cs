using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("PhieuDat")]
    public class PhieuDat
    {
        [Key]
        public int PD_Id { get;set; }
        public DateTime PD_Date { get;set; }
        public string PD_TrangThai { get;set; }
    }
}
