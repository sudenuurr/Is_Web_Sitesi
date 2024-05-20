using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfApplicationRepository : GenericRepository<Application>, IApplicationDal
    {
        public List<Application> GetListApplicationWithAdvert(int id)
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).Where(x => x.AdvertID == id).ToList();
            }
        }
        public List<Application> GetListApplicationWithUser(int id)
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).Where(x => x.AppUserId == id).ToList();
            }
        }

        public List<Application> GetListApplicationWithUserApproval(int id)
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).Where(x => x.Status == "Başvurunuz Onaylandı." && x.AppUserId == id).ToList();
            }
        }

        public List<Application> GetListApplicationWithUserByWaitApproval(int id)
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).Where(x => x.Status == "Başvuru Yapıldı. Onay Bekleniyor" && x.AppUserId == id).ToList();
            }
        }

        public List<Application> GetListApplicationWithUserRejected(int id)
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).Where(x => x.Status == "Başvurunuz Kabul Edilmedi." && x.AppUserId == id).ToList();
            }
        }
        public List<Application> GetListApplicationDetail(int id)
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).Where(x => x.ApplicationID == id).ToList();
            }
        }
        public List<Application> GetListApplicationAppUserandAdvert()
        {
            using (var c = new Context())
            {
                return c.Applications.Include(x => x.Advert).Include(x => x.AppUser).ToList();
            }
        }

    }
}
