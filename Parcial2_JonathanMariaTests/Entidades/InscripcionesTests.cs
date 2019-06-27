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
    public class InscripcionesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = 1;
            inscripcion.FechaInscripcion = DateTime.Now;
            inscripcion.Detalle.Add(new InscripcionDetalle()
            {
                AsignaturaId = 1,
                Descripcion = "Programacion Aplicada 1",
                Creditos = 1,
                Precio = 560
            }
            );
            inscripcion.EstudianteId = 1;
            inscripcion.Balance = 560;
            Assert.IsTrue(InscripcionesBLL.Guardar(inscripcion));
        }

        [TestMethod()]
        public void Modificar()
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = 1;
            inscripcion.FechaInscripcion = DateTime.Now;
            inscripcion.Detalle.Add(new InscripcionDetalle()
            {
                AsignaturaId = 1,
                Descripcion = "Programacion Aplicada 1",
                Creditos = 1,
                Precio = 560
            }
            );
            inscripcion.EstudianteId = 1;
            inscripcion.Balance = 560;
            Assert.IsTrue(InscripcionesBLL.Modificar(inscripcion));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Inscripciones> repositorio = new RepositorioBase<Inscripciones>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Inscripciones> repositorio = new RepositorioBase<Inscripciones>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Inscripciones> repositorio = new RepositorioBase<Inscripciones>();
            List<Inscripciones> lista = new List<Inscripciones>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}