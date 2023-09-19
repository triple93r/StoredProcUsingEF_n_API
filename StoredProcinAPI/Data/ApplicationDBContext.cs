using Microsoft.EntityFrameworkCore;
using StoredProcinAPI.Models;

namespace StoredProcinAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }
        public virtual DbSet<Patient> Patients { get; set; }
    }
}
