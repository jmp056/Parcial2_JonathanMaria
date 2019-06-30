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
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public InscripcionDetalle()
        {
            IDID = 0;
            InscripcionId = 0;
            Descripcion = string.Empty;
            Precio = 0;
        }
        public InscripcionDetalle(int iDID, int inscripcionId, string descripcion, decimal precio)
        {
            IDID = iDID;
            InscripcionId = inscripcionId;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
