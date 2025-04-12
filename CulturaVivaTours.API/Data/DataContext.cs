using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.Shared.Entites;
namespace CulturaVivaTours.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Turista> Turistas { get; set; }

        public DbSet<Calificacion> calificacions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }






    }
}

 
