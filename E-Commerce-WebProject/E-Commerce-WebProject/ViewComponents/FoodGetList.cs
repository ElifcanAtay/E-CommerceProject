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
    public class FoodGetList:ViewComponent
    {
        IFoodService _foodService;

        public FoodGetList(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public IViewComponentResult Invoke()
        {
            var foodList = _foodService.GetList();
            return View(foodList);

        }


    }
}
