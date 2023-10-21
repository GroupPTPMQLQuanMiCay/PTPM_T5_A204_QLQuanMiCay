using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataFirstEntities.Entity
{
    [Table("TinTuc")]
    public class TinTuc
    {
        [Key]
        public int TinTuc_Id { get; set; }

        public DateTime NgayDang { get; set; }
        public string NoiDung { get; set; }
        public string NV_Id { get; set; }
        [ForeignKey("NV_Id")]
        public virtual NhanVien nhanVien { get; set; }
        public int LoaiTin_Id { get; set; }
        [ForeignKey("LoaiTin_Id")]
        public virtual LoaiTinTuc loaiTin { get; set; }
    }
}
