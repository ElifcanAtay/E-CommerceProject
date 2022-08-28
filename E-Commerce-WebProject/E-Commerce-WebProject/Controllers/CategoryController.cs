using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_WebProject.Controllers
{
    [Authorize(Roles = "A")]

    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(_categoryService.GetListAllById(x => x.CategoryName == p));
            }
            return View(_categoryService.GetList());

        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            _categoryService.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryGet(int id)
        {
            var x = _categoryService.GetById(id);
            Category ct = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryId = x.CategoryId
            };
            return View(ct);

        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            var x = _categoryService.GetById(p.CategoryId);
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            //x.Status = true;
            _categoryService.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryDelete(int id)
        {
            _categoryService.TDelete(new Category { CategoryId = id });

            //var x = categoryRepository.TGet(id);
            //x.Status=false;
            //categoryRepository.TUpdate(x);
            return RedirectToAction("Index");

        }
    }
}
