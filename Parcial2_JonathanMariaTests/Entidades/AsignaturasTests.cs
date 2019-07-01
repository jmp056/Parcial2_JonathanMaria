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
    public class AsignaturasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = 1;
            asignatura.Descripcion = "Programacion Aplicada";
            asignatura.Creditos = 1;
            Assert.IsTrue(repositorio.Guardar(asignatura));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = 1;
            asignatura.Descripcion = "Lab. Programacion Aplicada 1";
            asignatura.Creditos = 1;
            Assert.IsTrue(repositorio.Modificar(asignatura));
        }
        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            List<Asignaturas> lista = new List<Asignaturas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}