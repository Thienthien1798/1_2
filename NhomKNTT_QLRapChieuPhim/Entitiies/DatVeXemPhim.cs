using QuanLyRapChieuPhim.Entitiies;
using QuanLyRapChieuPhim.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NhomKNTT_QLRapChieuPhim.Entitity
{
    [Table("DatVe")]
    public class DatVeXemPhim
    {
        [Key]
        public int MaDatVe { get; set; }
        [Required]
        [MaxLength(50)]
        public double SoDienThoai { get; set; }
        public string LichChieuPhim { get; set; }
        public string  SoLuongChoTrong{ get; set; }
        public Rap rap;
        public LichChieuPhim lichChieuPhim;
    }
}
