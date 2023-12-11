using AlmacenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmacenAPI.Context
{
    public class ApplicationDbContext: DbContext
    {

        public DbSet<Product> Product { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

    }
}
