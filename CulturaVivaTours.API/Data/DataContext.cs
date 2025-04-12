using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.Shared.Entites;
namespace CulturaVivaTours.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Guia> Guias { get; set; }

        public DbSet<RutaAsignada> RutasAsignadas { get; set; }
   
        public DbSet<Turista> Turistas { get; set; }

        public DbSet<Calificacion> calificacions { get; set; }
        
        public DbSet<Ruta> Rutas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }      
    }
}

 
