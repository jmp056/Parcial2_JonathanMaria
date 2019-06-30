using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class Inscripciones
    {
        public int InscripcionId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public virtual List<InscripcionDetalle> Detalle{ get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            FechaInscripcion = DateTime.Now;
            Detalle = new List<InscripcionDetalle>();
        }
    }
}
