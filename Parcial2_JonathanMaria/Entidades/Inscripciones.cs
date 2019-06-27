using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int EstudianteId { get; set; }
        [ForeignKey("EstudianteId")]
        public virtual Estudiantes Estudiante { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            FechaInscripcion = DateTime.Now;
            Detalle = new List<InscripcionDetalle>();
            Valor = 0;
        }
        public Inscripciones(int estudianteId, Estudiantes estudiante, decimal balance)
        {
            EstudianteId = estudianteId;
            Estudiante = estudiante;
            Balance = balance;
        }
    }
}
