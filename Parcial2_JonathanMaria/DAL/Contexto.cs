using Parcial2_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.DAL
{
    public class Contexto : DbContext
    {
        //public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
