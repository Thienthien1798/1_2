using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyRapChieuPhim.Entitiies;
using QuanLyRapChieuPhim.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhomKNTT_QLRapChieuPhim.Controllers
{
    public class RapController : Controller
    {
        private readonly MyDbContext _context;

        public RapController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.raps.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Rap model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var loai = await _context.raps.FirstOrDefaultAsync(m => m.MaRap == id);
            if (loai == null)
            {
                return NotFound();
            }
            return View(loai);
        }
    }
}
