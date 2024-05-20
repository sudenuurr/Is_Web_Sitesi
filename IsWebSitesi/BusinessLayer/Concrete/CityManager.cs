﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void TAdd(City t)
        {
            _cityDal.Insert(t);
        }

        public void TDelete(City t)
        {
            throw new NotImplementedException();
        }

        public City TGetByID(int id)
        {
            return _cityDal.GetByID(id);
        }

        public List<City> TGetList()
        {
            return _cityDal.GetListAll();
        }

        public void TUpdate(City t)
        {
            throw new NotImplementedException();
        }
    }
}
