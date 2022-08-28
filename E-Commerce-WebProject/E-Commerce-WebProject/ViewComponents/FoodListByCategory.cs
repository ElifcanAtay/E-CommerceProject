using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_WebProject.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        IFoodService _foodService;

        public FoodListByCategory(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var foodList = _foodService.GetList().Where(x => x.CategoryId == id);

            return View(foodList);
        }
    }
}
