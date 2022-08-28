using BusinessLayer.Abstract;
using DataAccessLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace E_Commerce_WebProject.Controllers
{
    [Authorize(Roles = "A")]
    public class FoodController : Controller
    {
        IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            //c = context;
            _foodService = foodService;
        }

        public IActionResult Index(int page = 1)
        {
            var x = _foodService.GetList().ToPagedList(page, 3);
            return View(x);
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(UrunEkle p)
        {
            Food f = new Food();
            if (p.ImageURL != null)
            {
                var extension = Path.GetExtension(p.ImageURL.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/resimler/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageURL.CopyTo(stream);
                f.ImageURL = newimagename;
            }
            f.Name = p.Name;
            f.Price = p.Price;
            f.Stock = p.Stock;
            f.CategoryId = p.CategoryId;
            f.Description = p.Description;
            _foodService.TAdd(f);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
            _foodService.TDelete(new Food { FoodId = id });
            return RedirectToAction("Index");
        }
        public IActionResult FoodGet(int id)
        {
            Context c = new Context();
            var x = _foodService.GetById(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Food f = new Food()
            {
                FoodId = x.FoodId,
                CategoryId = x.CategoryId,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
                Description = x.Description,
                ImageURL = x.ImageURL
            };
            return View(f);
        }
        public IActionResult FoodUpdate(Food p)
        {
            var x = _foodService.GetById(p.FoodId);
            x.Name = p.Name;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.Description = p.Description;
            x.ImageURL = p.ImageURL;
            x.CategoryId = p.CategoryId;
            _foodService.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
