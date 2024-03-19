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
    public class EfAdvertRepository : GenericRepository<Advert>, IAdvertDal
    {
        public List<Advert> GetListCategoryandCompany()
        {
            using (var c = new Context())
            {
                return c.Adverts.Include(x => x.Company).Include(x => x.Category).ToList();             
            }
        }

    }
 
}

