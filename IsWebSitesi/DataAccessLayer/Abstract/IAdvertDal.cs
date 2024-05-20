using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAdvertDal : IGenericDal<Advert>
    {
         List<Advert> GetListCategoryandCompany();
         List<Advert> GetListCategoryByCompany(int id);
         List<Advert> AdvertFilterList(int? categoryId, string? jobType, int? cityId, string? postedDate);

    }
}
