using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace IsWebSitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        CompanyManager _companyManager = new CompanyManager(new EfCompanyRepository());

        public IActionResult Index(int page=1)
        {
            var values = _companyManager.TGetCompanyListWithCityandUser().ToPagedList(page, 5);
            return View(values);
        }
        public IActionResult DeleteCompany(int id)
        {
            var value = _companyManager.TGetByID(id);
            _companyManager.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
