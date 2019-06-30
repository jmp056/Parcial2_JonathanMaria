using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class Inscripciones
    {
        public int InscripcionId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public decimal Precio { get; set; }
        public virtual List<InscripcionDetalle> Detalle { get; set; }
        public int EstudianteId { get; set; }
        [ForeignKey("EstudiantId")]
        public virtual Estudiantes Estudiante{ get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            FechaInscripcion = DateTime.Now;
            Precio = 0;
            Detalle = new List<InscripcionDetalle>();
            EstudianteId = 0;
        }
    }
}
