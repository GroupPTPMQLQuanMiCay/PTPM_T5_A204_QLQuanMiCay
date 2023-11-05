using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstEntities.Entity
{
    [Table("ManHinh")]
    public class ManHinh
    {
        [Key]
        public string MH_Id { get; set; }

        public string MH_HienThi { get; set; }
    }
}
