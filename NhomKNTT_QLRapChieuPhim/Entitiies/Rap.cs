    using QuanLyRapChieuPhim.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Entitiies
{
    [Table("Rap")]
    public class Rap
    {
        [Key]
        public int MaRap { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenRap { get; set; }
        public double SoChoTrong { get; set; }
        public ICollection<LichChieuPhim> lichChieuPhims { get; set; }
        public ICollection<DanhSachPhim> danhSachPhims { get; set; }
    }
}
