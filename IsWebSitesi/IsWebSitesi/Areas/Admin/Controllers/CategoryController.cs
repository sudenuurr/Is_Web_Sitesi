using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace IsWebSitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var values = _categoryManager.TGetList().ToPagedList(page,10);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
         [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                _categoryManager.TAdd(p);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryManager.TGetByID(id);
            _categoryManager.TDelete(value);
            return RedirectToAction("Index");
        }

    }
}
