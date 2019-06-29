using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class InscripcionDetalle
    {
        [Key]
        public int InscripcionDetalleId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; } 
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public decimal Precio { get; set; }

        public InscripcionDetalle(int inscripcionDetalleId, int asignaturaId, string descripcion, int creditos, decimal precio)
        {
            InscripcionDetalleId = inscripcionDetalleId;
            AsignaturaId = asignaturaId;
            Descripcion = descripcion;
            Creditos = creditos;
            Precio = precio;
        }
    }
}
