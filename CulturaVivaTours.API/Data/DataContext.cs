using CulturaVivaTours.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace CulturaVivaTours.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PuntoInteres> PuntosInteres { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
