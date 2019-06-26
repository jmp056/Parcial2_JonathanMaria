using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_JonathanMaria.BLL;
using Parcial2_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.Entidades.Tests
{
    [TestClass()]
    public class EstudiantesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Estudiantes> repositorio  = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 1;
            estudiante.FechaIngreso = DateTime.Now;
            estudiante.Nombre = "Jonathan Maria Parra";
            estudiante.Balance = 0;
            Assert.IsTrue(repositorio.Guardar(estudiante));
        }
    }
}