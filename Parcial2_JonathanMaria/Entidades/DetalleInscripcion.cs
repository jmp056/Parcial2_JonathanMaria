using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class InscripcionDetalle
    {
        [Key]
        public int IDID { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public decimal Precio { get; set; }

        public InscripcionDetalle(int iDID, int inscripcionId, int asignaturaId, string descripcion, int creditos, decimal precio)
        {
            IDID = iDID;
            InscripcionId = inscripcionId;
            AsignaturaId = asignaturaId;
            Descripcion = descripcion;
            Creditos = creditos;
            Precio = precio;
        }
    }
}
