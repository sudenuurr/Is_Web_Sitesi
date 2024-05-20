using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IsWebSitesi.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        AdvertManager _advertManager = new AdvertManager(new EfAdvertRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _advertManager.TGetList().Count();
            ViewBag.v2 = c.Companies.Count();
            ViewBag.v3 = c.Applications.Count();

            // OpenWeatherMap API anahtarını tanımlıyoruz
            string api = "ce084d428b5097732b37d52be800d560";

            // OpenWeatherMap API'ye bağlanmak için URL oluşturuyoruz.
            // İstanbul şehri için hava durumu bilgilerini XML formatında, Türkçe dilinde ve metrik birimlerde almak üzere istek yapıyoruz

            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            // Belirtilen URL'den XML dökümanını yüklüyoruz.
            XDocument document = XDocument.Load(connection);

            // XML dökümanından "temperature" (sıcaklık) elementini buluyoruz ve ilk elementin "value" (değer) attribute'unu alıyoruz.
            // Bu değeri ViewBag.v3 değişkenine atıyoruz, böylece bu veri ViewBag aracılığıyla görünümde (view) kullanılabilir.
            ViewBag.v3 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
