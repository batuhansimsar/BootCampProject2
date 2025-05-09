using System.Collections.Generic;
using System.Threading.Tasks;
using BootcampProject.Business.Interfaces;
using BootcampProject.Entities;
using BootcampProject.Repositories.Repositories;

namespace BootcampProject.Business.Managers
{
    // BootcampManager, bootcamp ile ilgili iş kurallarını içerir
    public class BootcampManager : IBootcampService
    {
        private readonly IRepository<Bootcamp> _bootcampRepository;

        // Constructor ile repository dependency injection yapılır
        public BootcampManager(IRepository<Bootcamp> bootcampRepository)
        {
            _bootcampRepository = bootcampRepository;
        }

        // Tüm bootcampleri getirir
        public async Task<IEnumerable<Bootcamp>> GetAllAsync()
        {
            return await _bootcampRepository.GetAllAsync();
        }

        // Id’ye göre bootcamp getirir
        public async Task<Bootcamp> GetByIdAsync(int id)
        {
            return await _bootcampRepository.GetByIdAsync(id);
        }

        // Yeni bootcamp ekler
        public async Task AddAsync(Bootcamp bootcamp)
        {
            await _bootcampRepository.AddAsync(bootcamp);
        }

        // Bootcamp günceller
        public async Task UpdateAsync(Bootcamp bootcamp)
        {
            await _bootcampRepository.UpdateAsync(bootcamp);
        }

        // Bootcamp siler
        public async Task DeleteAsync(int id)
        {
            var item = await _bootcampRepository.GetByIdAsync(id);
            if (item != null)
            {
                await _bootcampRepository.DeleteAsync(item);
            }
        }
    }
}
