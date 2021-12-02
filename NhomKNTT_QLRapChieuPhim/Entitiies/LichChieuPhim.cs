using QuanLyRapChieuPhim.Entitiies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Entitites
{
    [Table("LichChieuPhim")]
    public class LichChieuPhim
    {

        [Key]
        public int MaLichChieu { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenPhim { get; set; }
        public string TenRap { get; set; }
        public DateTime GioCongChieu { get; set; }
        public Rap rap;
        public DanhSachPhim phim;
    }
}
