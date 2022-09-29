using BulkyBooksweb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooksweb.Data
{
    public class ApplicationDbContext :DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
