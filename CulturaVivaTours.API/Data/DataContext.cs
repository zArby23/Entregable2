using CulturaVivaTours.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CulturaVivaTours.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Guia> Guias { get; set; }
        public DbSet<RutaAsignada> RutasAsignadas { get; set; }
    }
}
