using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdvertRepository : GenericRepository<Advert>, IAdvertDal
    {
        Context c = new Context();
        public List<Advert> AdvertFilterList(int? categoryId, string? jobType, int? cityId, string? postedDate)
        {
            List<Advert> advertList = new();

            var advertCategory = c.Adverts.Include(x => x.Company)
             .Include(x => x.Category)
             .Where(x => x.CategoryID == categoryId &&
             (string.IsNullOrEmpty(jobType) || x.JobType == jobType)).ToList();
            // Eğer jobType null veya boş ise, string.IsNullOrEmpty(jobType) ifadesi true olur ve bu durumda x.JobType == jobType kontrolü yapılmaz, yani jobType kriteri sorguya katılmaz. Eğer jobType seçilmişse sorguya katılır.

            switch (postedDate)
            {
                case "Bugün":
                    var today = DateTime.Today; // Bugünün tarihi
                    advertCategory = c.Adverts.Include(x => x.Company)
                       .Include(x => x.Category)
                       .Where(x => x.CategoryID == categoryId && (string.IsNullOrEmpty(jobType) || x.JobType == jobType) &&
                       x.PostedDate.Day == today.Day &&
                        x.PostedDate.Month == today.Month &&
                        x.PostedDate.Year == today.Year).ToList();
                    break;

                case "Son 2 Gün":
                    DateTime twoDaysAgo = DateTime.Now.AddDays(-2); // Bugünden 2 gün önceki tarih
                    advertCategory = c.Adverts.Include(x => x.Company)
                       .Include(x => x.Category)
                       .Where(x => x.CategoryID == categoryId && (string.IsNullOrEmpty(jobType) || x.JobType == jobType) &&
                       x.PostedDate >= twoDaysAgo).ToList();
                    break;

                case "Son 5 Gün":
                    DateTime fiveDaysAgo = DateTime.Now.AddDays(-5); // Bugünden 5 gün önceki tarih
                    advertCategory = c.Adverts.Include(x => x.Company)
                       .Include(x => x.Category)
                       .Where(x => x.CategoryID == categoryId && (string.IsNullOrEmpty(jobType) || x.JobType == jobType) &&
                       x.PostedDate >= fiveDaysAgo).ToList();
                    break;

                case "Son 10 Gün":
                    DateTime tenDaysAgo = DateTime.Now.AddDays(-10); // Bugünden 10 gün önceki tarih
                    advertCategory = c.Adverts.Include(x => x.Company)
                       .Include(x => x.Category)
                       .Where(x => x.CategoryID == categoryId && (string.IsNullOrEmpty(jobType) || x.JobType == jobType) &&
                       x.PostedDate >= tenDaysAgo).ToList();
                    break;

                case "Son 1 Ay":
                    DateTime oneMonthAgo = DateTime.Now.AddDays(-30); // Bugünden 1 ay önceki tarih
                    advertCategory = c.Adverts.Include(x => x.Company)
                       .Include(x => x.Category)
                       .Where(x => x.CategoryID == categoryId && (string.IsNullOrEmpty(jobType) || x.JobType == jobType) &&
                       x.PostedDate >= oneMonthAgo).ToList();
                    break;

            }

            var companies = c.Companies.Where(x => x.CityID == cityId).ToList();

            foreach (var advert in advertCategory)
            {
                foreach (var company in companies)
                {
                    if (advert.CompanyID == company.CompanyID)
                    {
                        advertList.Add(advert);
                    }
                }
            }

            return advertList;
        }


        public List<Advert> GetListCategoryandCompany()
        {
            using (var c = new Context())
            {
                return c.Adverts.Include(x => x.Company).Include(x => x.Category).ToList();
            }
        }

        public List<Advert> GetListCategoryByCompany(int id)
        {
            using (var c = new Context())
            {
                return c.Adverts.Include(x => x.Company).Include(x => x.Category).Where(x => x.CompanyID == id).ToList();
            }
        }
    }

}

