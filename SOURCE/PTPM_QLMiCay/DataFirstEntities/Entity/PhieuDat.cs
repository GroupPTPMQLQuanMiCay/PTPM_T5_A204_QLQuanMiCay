using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataFirstEntities.Entity
{
    [Table("PhieuDat")]
    public class PhieuDat
    {
        [Key]
        public int PD_Id { get;set; }
        public DateTime PD_Date { get;set; }
        public string PD_TrangThai { get;set; }
        public string createdBy { get; set; }
        public DateTime createdAt { get; set; }
        public string updatedBy { get; set; }
        public DateTime updatedAt { get; set; }
        public bool isDeleted { get; set; }
        public bool isSentSupplier { get; set ; }
        public string sentSupplierBy { get; set; }
    }
}
