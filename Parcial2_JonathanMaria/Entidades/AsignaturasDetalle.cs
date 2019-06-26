using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class AsignaturasDetalle
    {
        public int AsignaturaDetalleId { get; set; }
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }

        [ForeignKey("EstudianteId")]
        public virtual Estudiantes Estudiante { get; set; }
        public decimal Balance { get; set; }

        public AsignaturasDetalle(int estudianteId, Estudiantes estudiante, decimal balance)
        {
            EstudianteId = estudianteId;
            Estudiante = estudiante;
            Balance = balance;
        }
    }
}
