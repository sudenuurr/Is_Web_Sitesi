using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;

        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public List<Advert> GetAdvertListWithCategoryCompany()
        {
            return _advertDal.GetListCategoryandCompany();
        }
        public List<Advert> CategoryListByCompany(int id)
        {
            return _advertDal.GetListCategoryByCompany(id);
        }

        public List<Advert> GetAdvertByID(int id)
        {
            return _advertDal.GetListAll(x => x.AdvertID == id);
        }


        public void TAdd(Advert t)
        {
            _advertDal.Insert(t);
        }

        public void TDelete(Advert t)
        {
            _advertDal.Delete(t);

        }

        public void TUpdate(Advert t)
        {
            _advertDal.Update(t);
        }

        public List<Advert> TGetList()
        {
            return _advertDal.GetListAll();
        }

        public Advert TGetByID(int id)
        {
            return _advertDal.GetByID(id);
        }

        public List<Advert> GetAdvertListByCompany(int id)
        {
            return _advertDal.GetListAll(x => x.CompanyID == id);
        }

        public List<Advert> AdvertFilterList(int? categoryId, string? jobType, int? cityId, string? postedDate)
        {
            return _advertDal.AdvertFilterList(categoryId, jobType, cityId, postedDate);
        }
    }
}
