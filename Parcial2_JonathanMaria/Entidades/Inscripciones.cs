﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades
{
    public class Inscripciones
    {
        public int InscripcionId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int EstudianteId { get; set; }
        public List<AsignaturasDetalle> asignaturasDetalle { get; set; }
        public decimal Monto { get; set; }
        public Inscripciones()
        {
            InscripcionId = 0;
            FechaInscripcion = DateTime.Now;
            EstudianteId = 0;
            this.asignaturasDetalle = new List<AsignaturasDetalle>();
            Monto = 0;
        }
    }
}