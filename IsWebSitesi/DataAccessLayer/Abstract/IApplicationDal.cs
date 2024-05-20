using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IApplicationDal : IGenericDal<Application>
    {
        List<Application> GetListApplicationWithUser(int id);      
        List<Application> GetListApplicationWithUserApproval(int id);      
        List<Application> GetListApplicationWithUserRejected(int id);
        List<Application> GetListApplicationWithUserByWaitApproval(int id);
        List<Application> GetListApplicationWithAdvert(int id);                   
        List<Application> GetListApplicationDetail(int id);                   
        List<Application> GetListApplicationAppUserandAdvert();                   
    }
}
