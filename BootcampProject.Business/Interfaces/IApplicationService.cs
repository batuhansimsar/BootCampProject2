using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampProject.Entities;

namespace BootcampProject.Business.Interfaces
{
    //Application için yapılacak işlemleri tanımlayan interface
    public interface IApplicationService
    {
        Task<List<Application>> GetApplicationsAsync();
        Task<Application> GetApplicationByIdAsync(int id);
        Task CreateApplicationAsync(Application application);
        Task UpdateApplicationAsync(Application application);
        Task DeleteApplicationAsync(int id);
    }

}
