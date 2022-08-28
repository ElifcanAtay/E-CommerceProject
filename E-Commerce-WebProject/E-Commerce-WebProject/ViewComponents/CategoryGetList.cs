//using CoreAndFood.Repositories;
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_WebProject.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryGetList(ICategoryService category)
        {
            _categoryService = category;
        }

        public IViewComponentResult Invoke()
        {

            var categoryList = _categoryService.GetList();

            return View(categoryList);

        }
    }
}
