using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class Estudiantes
    {
        public int EstudianteId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }
        public Estudiantes()
        {
            EstudianteId = 0;
            FechaIngreso = DateTime.Now;
            Nombre = string.Empty;
            Balance = 0;
        }
    }
}
