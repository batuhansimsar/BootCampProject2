using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampProject.Entities;

namespace BootcampProject.Business.Interfaces
{
    public interface IBlacklistService
    {
        Task<List<Blacklist>> GetAllAsync(); //Kara listedeki tüm kayıtları getirir
        Task<List<Blacklist>> GetByIdAync(int id);//Id'ye göre kara liste kaydı getirir
        Task AddAsync(Blacklist blacklist);//Kara listeye yeni kayıt ekler
        Task UpdateAsync(Blacklist blacklist);//Kara liste kaydını güncelle
        Task DeleteAsync(int id); //Kara liste kaydını sil
    }
}
