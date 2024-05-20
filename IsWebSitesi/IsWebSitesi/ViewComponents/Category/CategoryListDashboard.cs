using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.TGetList();
            return View(values);
        }
    }
}
