using System.Collections.Generic;                          // Koleksiyonlar için
using System.Threading.Tasks;                              // Asenkron işlemler için
using BootcampProject.Business.Interfaces;                 // IBlacklistService arayüzüne erişim
using BootcampProject.Entities;                            // Blacklist entity'si için
using BootcampProject.Repositories.Repositories;           // IRepository arayüzü için

namespace BootcampProject.Business.Managers
{
    // BlacklistManager, kara liste işlemleri için iş mantığını içerir
    public class BlacklistManager : IBlacklistService
    {
        // Kara liste veritabanı işlemleri için generic repository
        private readonly IRepository<Blacklist> _blacklistRepository;

        // Constructor: repository bağımlılığı dışarıdan enjekte edilir (Dependency Injection)
        public BlacklistManager(IRepository<Blacklist> blacklistRepository)
        {
            _blacklistRepository = blacklistRepository;
        }

        // Tüm kara liste kayıtlarını getirir
        public async Task<IEnumerable<Blacklist>> GetAllAsync()
        {
            return await _blacklistRepository.GetAllAsync();
        }

        // Belirli bir ID’ye sahip kara liste kaydını getirir
        public async Task<Blacklist> GetByIdAsync(int id)
        {
            return await _blacklistRepository.GetByIdAsync(id);
        }

        // Yeni bir kara liste kaydı ekler
        public async Task AddAsync(Blacklist blacklist)
        {
            await _blacklistRepository.AddAsync(blacklist); // `AddAsyncs` değil `AddAsync` olmalı
        }

        // ID ile kara liste kaydını siler
        public async Task DeleteAsync(int id)
        {
            var entity = await _blacklistRepository.GetByIdAsync(id);

            if (entity != null)
            {
                await _blacklistRepository.DeleteAsync(entity); // ID değil, entity silinmeli
            }
        }
    }
}
