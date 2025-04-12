using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class RutaAsignada
    {
        public int id { get; set; }

        [JsonIgnore]
        public Ruta ruta { get; set; }

        [JsonIgnore]
        public Guia guia { get; set; }
    }
}
