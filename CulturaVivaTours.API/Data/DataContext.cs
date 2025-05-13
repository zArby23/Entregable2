using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.Shared.Entities;
namespace CulturaVivaTours.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Guia> Guias { get; set; }

        public DbSet<RutaAsignada> RutasAsignadas { get; set; }
   
        public DbSet<Turista> Turistas { get; set; }

        public DbSet<Calificacion> Calificaciones { get; set; }
        
        public DbSet<Ruta> Rutas { get; set; }     

        public DbSet<PuntoInteres> PuntosInteres { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}