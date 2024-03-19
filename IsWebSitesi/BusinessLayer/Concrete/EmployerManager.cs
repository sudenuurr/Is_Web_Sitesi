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
    public class EmployerManager : IEmployerService
    {
        IEmployerDal _employerDal;

        public EmployerManager(IEmployerDal employerDal)
        {
            _employerDal = employerDal;
        }

        public void TAdd(Employer t)
        {
            _employerDal.Insert(t);
        }

        public void TDelete(Employer t)
        {
            _employerDal.Delete(t);
        }

        public Employer TGetByID(int id)
        {
            return _employerDal.GetByID(id);
        }

        public List<Employer> TGetList()
        {
            return _employerDal.GetListAll();
        }

        public void TUpdate(Employer t)
        {
            _employerDal.Update(t);
        }
    }
}
