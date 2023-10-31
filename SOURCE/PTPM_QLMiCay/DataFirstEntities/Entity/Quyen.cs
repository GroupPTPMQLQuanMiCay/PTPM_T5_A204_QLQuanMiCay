using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("Quyen")]
    public class Quyen
    {
        [Key]
        public string Quyen_Id { get; set; }

        public string DienGiai { get; set; }
    }
}
