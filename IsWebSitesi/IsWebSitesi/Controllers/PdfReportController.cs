using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IsWebSitesi.Controllers
{
    public class PdfReportController : Controller
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExportPdfAdvertList()
        {
            // Veri tabanından ilanları al
            List<Application> applications = ApplicationList();

            // PDF oluşturmak için gerekli işlemler
            using (MemoryStream memoryStream = new MemoryStream())
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                document.Open();
                PdfPTable table = new PdfPTable(5); // Sütun sayısı

                // Tablonun başlık sütunlarını ekle
                table.AddCell("ID");
                table.AddCell("Başvuran");
                table.AddCell("İlan");
                table.AddCell("Durumu");
                table.AddCell("Tarih");

                // Her başvuruyu tabloya ekle
                foreach (var item in applications)
                {
                    table.AddCell(item.ApplicationID.ToString());
                    table.AddCell(item.AppUser.NameSurname);
                    table.AddCell(item.Advert.Department);
                    table.AddCell(item.Status);
                    table.AddCell(item.ApplicationDate.ToShortDateString());
                }
                document.Add(table);
                document.Close();
                var content = memoryStream.ToArray();
                return File(content, "application/pdf", "Ilanlar.pdf");
            }
        }


        public List<Application> ApplicationList()
        {
            List<Application> applications = new List<Application>();
            using (var c = new Context())
            {
                applications = c.Applications.Include(a => a.Advert).Include(a => a.AppUser).ToList();
            }
            return applications;
        }
    }

}



