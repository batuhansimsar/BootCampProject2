using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampProject.Entities;


namespace BootcampProject.Business.Interfaces
{
    //Bootcamp işlemleri için servis arayüzü
    public interface IBootcampService
    {
        Task<List<Bootcamp>> GetAllAsync(); //Tüm bootcampler gelir
        Task<Bootcamp> GetAsync(int id);//ID'ye göre bootcamp gelir
        Task AddAsync(Bootcamp bootcamp);//Yeni bootcamp ekler
        Task UpdateAsync(Bootcamp bootcamp); //Bootcamp'i günceller
        Task DeleteAsync(int id); //Bootcampi siler
    }
}
