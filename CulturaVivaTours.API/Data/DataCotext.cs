using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.Shared.Entities;

namespace CulturaVivaTours.API.Data
{
    public class DataCotext :DbContext
    {

        public DataCotext(DbContextOptions<DataCotext>options):base(options) 
        {
                

        }
        public DbSet<Turista>Turistas { get; set; }

    }
}
