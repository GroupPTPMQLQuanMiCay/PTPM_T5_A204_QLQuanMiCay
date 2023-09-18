using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("Ban")]
    public class Ban
    {
        [Key]
        public int B_SoBan { get; set; }

        public string B_ViTri { get; set;}
    }
}
