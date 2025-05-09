using BootcampProject.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampProject.Repositories.Repositories
{
    public class EfApplicationRepository : IApplicationRepository
    {
        private readonly BootcampDbContext _context;

        public EfApplicationRepository(BootcampDbContext context)
        {
            _context = context;
        }

        public List<Application> GetAll()
        {
            return _context.Applications.ToList();
        }

        public void Add(Application application)
        {
            _context.Applications.Add(application);
            _context.SaveChanges();
        }
    }

}
