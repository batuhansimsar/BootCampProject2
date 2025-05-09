using BootcampProject.Business.Interfaces;
using BootcampProject.Entities;
using BootcampProject.Repositories.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampProject.Business.Managers
{
    // ApplicationManager, IApplicationService arayüzünü uygular
    // Başvuru (Application) işlemlerinin iş mantığını içerir
    public class ApplicationManager : IApplicationService
    {
        private readonly IRepository<Application> _repository; // Generic repository bağımlılığı

        // Constructor, repository'yi DI (Dependency Injection) ile alır
        public ApplicationManager(IRepository<Application> repository)
        {
            _repository = repository;
        }

        // Tüm başvuruları getirir
        public async Task<IEnumerable<Application>> GetAllApplicationsAsync()
        {
            return await _repository.GetAllAsync(); // Veritabanından tüm başvuruları alır
        }

        // ID'ye göre başvuru getirir
        public async Task<Application> GetApplicationByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id); // Belirtilen ID’ye ait başvuruyu getirir
        }

        // Yeni başvuru oluşturur
        public async Task CreateApplicationAsync(Application application)
        {
            await _repository.AddAsync(application); // Veritabanına yeni başvuru ekler
        }

        // Başvuruyu siler
        public async Task DeleteApplicationAsync(int id)
        {
            var application = await _repository.GetByIdAsync(id); // Önce var mı diye kontrol eder
            if (application != null)
            {
                await _repository.DeleteAsync(application); // Varsa siler
            }
        }

        // Başvuruyu günceller
        public async Task UpdateApplicationAsync(Application application)
        {
            await _repository.UpdateAsync(application); // Başvuruyu günceller
        }
    }
}

