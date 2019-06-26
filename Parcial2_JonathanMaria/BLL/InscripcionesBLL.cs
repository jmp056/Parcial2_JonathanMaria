using Parcial2_JonathanMaria.DAL;
using Parcial2_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.BLL
{
    public class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto _contexto = new Contexto();
            try
            {
                if (_contexto.Inscripciones.Add(inscripcion) != null)
                {
                    foreach(var item in inscripcion.asignaturasDetalle)
                    {
                        _contexto.Estudiantes.Find(item.EstudianteId).Balance += item.Valor;
                    }
                }
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }
    }
}
