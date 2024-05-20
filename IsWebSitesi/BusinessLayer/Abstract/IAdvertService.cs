using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdvertService : IGenericService<Advert>
    {
        List<Advert> GetAdvertListWithCategoryCompany();
        List<Advert> GetAdvertListByCompany(int id);
        List<Advert> AdvertFilterList(int? categoryId, string? jobType, int? cityId, string? postedDate);


    }
}
