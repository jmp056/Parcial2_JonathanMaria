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
        [ForeignKey("AsignaturaId")]     
        public virtual Asignaturas Asignatura { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public decimal Precio { get; set; }

        public InscripcionDetalle()
        {

        }
        public InscripcionDetalle(int asignaturaId, Asignaturas asignatura, string descripcion, int creditos, decimal valor)
        {
            AsignaturaId = asignaturaId;
            Asignatura = asignatura;
            Descripcion = descripcion;
            Creditos = creditos;
            Precio = valor;
        }
    }
}
