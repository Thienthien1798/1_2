using Microsoft.EntityFrameworkCore;
using NhomKNTT_QLRapChieuPhim.Entitity;
using QuanLyRapChieuPhim.Entitiies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim.Entitites
{
    public class MyDbContext:DbContext
    {
        public DbSet<DanhSachPhim> danhSachPhims { get; set; }
        public DbSet<LichChieuPhim> lichChieuPhims { get; set; }
        public DbSet<Rap> raps { get; set; }
        public DbSet<DatVeXemPhim> datVeXemPhims { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
