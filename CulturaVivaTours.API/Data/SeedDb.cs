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
            await CheckCalificacion();
            await CheckProveedor();
            await CheckTurista();
            await CheckPuntoInteres();
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

        public async Task CheckCalificacion()
        {
            if (!_context.Calificaciones.Any())
            {
                _context.Calificaciones.Add(new Calificacion
                {
                    Grade = "4.5",
                    Comment = "Muy bonito",
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
                    Contacto = "calisto123@gamil.com",
                    Disponible = true
                });

            }




            await _context.SaveChangesAsync();


        }

        public async Task CheckPuntoInteres()
        {
            if (!_context.PuntosInteres.Any())
            {
                _context.PuntosInteres.Add(new PuntoInteres
                {
                    Descripcion = "Mirador con vistas a un lago",
                    Ubicacion = "Pereira",
                    TipoActividad = "Caminata",
                    HorarioEstimado = DateTime.Parse("2025-10-05 10:35:00")
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
                    Disponibility = DateTime.Parse("2025-10-05 10:35:00"),
                });

            }




            await _context.SaveChangesAsync();


        }
    }
}