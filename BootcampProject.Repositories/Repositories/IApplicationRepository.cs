using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampProject.Repositories.Repositories
{
    public interface IApplicationRepository : IRepository<Application>
    {
        Task<Application> GetByApplicationIdAsync(int applicationId);//Başvuran kişinin idsine göre başvuru alınır
        Task<IEnumerable<Application>> GetByBootcampIdAsync(int bootcampId); //Bootcamp idsine göre başvuruları alır
    }

}
