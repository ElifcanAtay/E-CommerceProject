using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_WebProject.ViewComponents
{
    public class AdminGetList:ViewComponent
    {
        IAdminService _adminService;

        public AdminGetList(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IViewComponentResult Invoke()
        {
            #region Eski Kod
            //AdminRepository adminRepository = new AdminRepository();
            //var adminList = adminRepository.TList();
            //return View(adminList);
            #endregion

            var adminList = _adminService.GetList();
            
            return View(adminList);

        }
    }
}
