using CulturaVivaTours.Shared.Entities;

namespace CulturaVivaTours.API.Data
{


    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRuta();
            await CheckGuia();
            await CheckProveedor();
            await CheckTurista();
        }
        public async Task CheckRuta()
        {
            if (!_context.Rutas.Any())
            {
                _context.Rutas.Add(new Ruta
                {
                    FirstName = "3 cruces",
                    Region = "Patagonia",
                    Time = 3,
                    Experience = "Arriesgada",
                    Language = "Español"
                });
            }
            await _context.SaveChangesAsync();
        }

        public async Task CheckGuia()
        {
            if (!_context.Guias.Any())
            {
                _context.Guias.Add(new Guia
                {
                    FirstName = "Arnolfo",
                    LastName = "Iguarán",
                    Cedula = 1033487602,
                    Language = "Español",
                    Experience = 2,
                    Speciality = "Arriesgada"
                });
            }
            await _context.SaveChangesAsync();
        }


        public async Task CheckProveedor()
        {
            if (!_context.Proveedores.Any())
            {
                _context.Proveedores.Add(new Proveedor
                {
                    NombreProveedor = "Calisto",
                    TipoServicio = "Cultural",
                    Contacto = "calisto123@gamil.com"
                });

            }
            await _context.SaveChangesAsync();
        }


        public async Task CheckTurista()
        {
            if (!_context.Turistas.Any())
            {
                _context.Turistas.Add(new Turista
                {
                    FullName = "Jon Jairo Paredas",
                    Nationality = "Veneco",
                    Language = "Chamo",
                    RestringFood = "Ninguna",
                    Disponibility = DateTime.Parse("2025-10-05 10:35:00")
                });
            }
            await _context.SaveChangesAsync();
        }
    }
}