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
        public decimal PrecioCreditos { get; set; }
        public decimal Valor { get; set; }
        public virtual List<InscripcionDetalle> Detalle { get; set; }
        public int EstudianteId { get; set; }
        [ForeignKey("EstudiantId")]
        public virtual Estudiantes Estudiante{ get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            FechaInscripcion = DateTime.Now;
            PrecioCreditos = 0;
            Valor = 0;
            Detalle = new List<InscripcionDetalle>();
            EstudianteId = 0;
        }
    }
}
