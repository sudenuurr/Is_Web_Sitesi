using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using IsWebSitesi.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace IsWebSitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdvertController : Controller
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        CompanyManager _companyManager = new CompanyManager(new EfCompanyRepository());
        Context c=new Context();
        public IActionResult ExportExcelAdvertList()
        {
            // Veri tabanından ilanları al
            List<Advert> adverts = AdvertList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("İlan Listesi");
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Departman";
                worksheet.Cell(1, 3).Value = "Çalışma Türü";
                worksheet.Cell(1, 4).Value = "Açıklama";
                worksheet.Cell(1, 5).Value = "Gereklilikler";
                worksheet.Cell(1, 6).Value = "Deneyim";
                worksheet.Cell(1, 7).Value = "İlan Tarihi";
                worksheet.Cell(1, 8).Value = "Son Başvuru Tarihi";
                worksheet.Cell(1, 9).Value = "CompanyID";
                worksheet.Cell(1, 10).Value = "CategoryID";

                int AdvertRowCount = 2;
                foreach (var item in adverts)
                {
                    worksheet.Cell(AdvertRowCount, 1).Value = item.AdvertID;
                    worksheet.Cell(AdvertRowCount, 2).Value = item.Department;
                    worksheet.Cell(AdvertRowCount, 3).Value = item.JobType;
                    worksheet.Cell(AdvertRowCount, 4).Value = item.Description;
                    worksheet.Cell(AdvertRowCount, 5).Value = item.Required;
                    worksheet.Cell(AdvertRowCount, 6).Value = item.Experience;
                    worksheet.Cell(AdvertRowCount, 7).Value = item.PostedDate.ToShortDateString();
                    worksheet.Cell(AdvertRowCount, 8).Value = item.ApplicationDeadline.ToShortDateString();
                    worksheet.Cell(AdvertRowCount, 9).Value = item.CompanyID;
                    worksheet.Cell(AdvertRowCount, 10).Value = item.CategoryID;
                    AdvertRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Ilanlar.xlsx");
                }
            }
        }

        public List<Advert> AdvertList()
        {
            List<Advert> adverts = new List<Advert>();
            using (var c = new Context())
            {
                adverts = c.Adverts.ToList();
            }
            return adverts;
        }

        public IActionResult Index(int page = 1)
        {
            var values = _advertManager.GetAdvertListWithCategoryCompany().ToPagedList(page, 10);
            return View(values);
        }
        public IActionResult DeleteAdvert(int id)
        {
            var value = _advertManager.TGetByID(id);
            _advertManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAdvert(int id)
        {
            var value = _advertManager.TGetByID(id);
            List<SelectListItem> categoryvalues = (from x in _categoryManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(value);
        }
        [HttpPost]
        public IActionResult EditAdvert(Advert p)
        {
            //p.CompanyID = 1;
            _advertManager.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddAdvert()
        {
            List<SelectListItem> categoryvalues = (from x in _categoryManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            List<SelectListItem> companyvalues = (from x in _companyManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CompanyID.ToString()

                                                   }).ToList();
            ViewBag.co = companyvalues;
            return View();
        } 
        [HttpPost]
        public IActionResult AddAdvert(Advert p)
        {
            AdvertValidator validationRules = new AdvertValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                p.PostedDate = DateTime.Now;
                _advertManager.TAdd(p);
                return RedirectToAction("Index", "Advert");
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

    }
}

