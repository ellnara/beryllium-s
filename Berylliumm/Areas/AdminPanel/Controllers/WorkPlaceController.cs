using Berylliumm.DAL;
using Berylliumm.Models;
using Berylliumm.Helpers;
using Berylliumm.ViewModels.Category;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berylliumm.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class WorkPlaceController : Controller
    {
        
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public WorkPlaceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.WorkPlaces);
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(WorkPlaceCreateVM model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    };
        //}
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var Sliderr = _context.Slides.Find(id);
        //    if (Sliderr == null)
        //    {
        //        return NotFound();
        //    }
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    var path = Helper.GetPath(_env.WebRootPath, "img", "slide", Sliderr.Image);
        //    if (System.IO.File.Exists(path))
        //    {
        //        System.IO.File.Delete(path);
        //    }
        //    _context.Slides.Remove(Sliderr);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //public IActionResult Update(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var Slide = _context.Slides.Find(id);
        //    return View(Slide);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UpdateAsync(int? id, Slide slide)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var Slider = _context.Slides.Find(id);
        //    if (Slider == null)
        //    {
        //        return NotFound();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    if (!slide.Photo.CheckFileSize(200))
        //    {
        //        ModelState.AddModelError("Photo", "Max size image must be less than 200kb");
        //        return View();
        //    }
        //    if (!slide.Photo.CheckFileType("image/"))
        //    {
        //        ModelState.AddModelError("Photo", "Type of file must be image");
        //        return View();
        //    }
        //    slide.Image = await slide.Photo.SaveFileAsync(_env.WebRootPath, "img", "slide");
        //    var path = Helper.GetPath(_env.WebRootPath, "img", "slide", Slider.Image);
        //    if (System.IO.File.Exists(path))
        //    {
        //        System.IO.File.Delete(path);
        //    }
        //    Slider.Image = slide.Image;
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
