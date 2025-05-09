using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampProject.Repositories.Repositories
{
    //Generic repository interface'i, CRUD işlemleri için
    public interface IRepository<T> where T : class
    {
        Task AddAsyncs(T entity); //Veritababnına yeni bir entity ekler
        Task UpdateAsync(T entity); //Var olan bir entity'i günceller
        Task DeleteAsync(int id); //Entity'i siler
        Task<List<T>> GetByIdAsync(int id); //Id'ye göre entity'i siler
        Task<List<T>> GetAllAsync(); //Tüm entityleri getirir
    }
}
