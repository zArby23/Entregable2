using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class RutaGuia
    {
        [JsonIgnore]
        public Ruta Ruta { get; set; }
        public int RutaId { get; set; }

        [JsonIgnore]
        public Guia Guia { get; set; }

    }
}
