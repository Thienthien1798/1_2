using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Entitites
{
    [Table("DanhSachPhim")]
    public class DanhSachPhim
    {

        [Key]
        public int MaPhim { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenPhim { get; set; }
        public double ThoiLuong { get; set; }
    }
}
