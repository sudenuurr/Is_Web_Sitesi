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
    public class EfCompanyRepository : GenericRepository<Company>, ICompanyDal
    {
        public List<Company> GetListCityandUser()
        {
             using (var c = new Context())
            {
                return c.Companies.Include(x => x.City).Include(x => x.AppUser).ToList();
            }
        }


    }
}
