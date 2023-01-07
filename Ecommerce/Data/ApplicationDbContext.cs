using Ecommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<Ecommerce.Models.Adresse> Adresse { get; set; }
        public DbSet<Ecommerce.Models.Client> Client { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
    }
}