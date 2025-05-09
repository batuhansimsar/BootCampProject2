using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampProject.Repositories.Repositories
{
    // Bootcamp entity'si için veri erişim işlemlerini tanımlar.
    public interface IBootcampRepository : IRepository<Bootcamp>
    {
        Task<Bootcamp> GetByNameAsync(string name);  // Bootcamp'i isme göre arar
    }
}
