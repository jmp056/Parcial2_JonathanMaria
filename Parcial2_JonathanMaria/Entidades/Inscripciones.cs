using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public List<InscripcionDetalle> Detalle { get; set; }
        public decimal Valor { get; set; }
        public Inscripciones()
        {
            InscripcionId = 0;
            FechaInscripcion = DateTime.Now;
            this.Detalle = new List<InscripcionDetalle>();
            Valor = 0;
        }
    }
}
