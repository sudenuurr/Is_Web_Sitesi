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
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;

        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public void TAdd(Application t)
        {
            _applicationDal.Insert(t);
        }

        public void TDelete(Application t)
        {
            _applicationDal.Delete(t);
        }

        public Application TGetByID(int id)
        {
            return _applicationDal.GetByID(id);
        }

        public List<Application> TGetList()
        {
            return _applicationDal.GetListAll();
        }

        public List<Application> TGetListApplicationAppUserandAdvert()
        {
            return _applicationDal.GetListApplicationAppUserandAdvert();
        }

        public List<Application> TGetListApplicationDetail(int id)
        {
            return _applicationDal.GetListApplicationDetail(id);
        }

        public List<Application> TGetListApplicationWithAdvert(int id)
        {
            return _applicationDal.GetListApplicationWithAdvert(id);
        }

        public List<Application> TGetListApplicationWithUser(int id)
        {
            return _applicationDal.GetListApplicationWithUser(id);
        }

        public List<Application> TGetListApplicationWithUserApproval(int id)
        {
            return _applicationDal.GetListApplicationWithUserApproval(id);

        }

        public List<Application> TGetListApplicationWithUserByWaitApproval(int id)
        {
            return _applicationDal.GetListApplicationWithUserByWaitApproval(id);

        }

        public List<Application> TGetListApplicationWithUserRejected(int id)
        {
            return _applicationDal.GetListApplicationWithUserRejected(id);
        }

        public void TUpdate(Application t)
        {
            _applicationDal.Update(t);
        }
    }
}
