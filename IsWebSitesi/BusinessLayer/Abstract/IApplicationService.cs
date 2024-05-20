using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IApplicationService : IGenericService<Application>
    {
        List<Application> TGetListApplicationWithUser(int id);
        List<Application> TGetListApplicationWithUserApproval(int id);
        List<Application> TGetListApplicationWithUserRejected(int id);
        List<Application> TGetListApplicationWithUserByWaitApproval(int id);
        List<Application> TGetListApplicationWithAdvert(int id);
        List<Application> TGetListApplicationDetail(int id);
        List<Application> TGetListApplicationAppUserandAdvert();
        

    }
}
