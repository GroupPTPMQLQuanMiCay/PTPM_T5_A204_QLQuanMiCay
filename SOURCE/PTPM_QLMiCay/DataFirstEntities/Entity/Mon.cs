using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("Mon")]
    public class Mon
    {
        [Key]
        public string M_Ten { get; set; }

        public int DM_Id { get;set; }
        [ForeignKey("DM_Id")]
        public virtual DanhMuc DanhMuc { get; set; }   
        public int M_Gia { get; set; }
        public string M_IMG { get; set; }

    }
}
