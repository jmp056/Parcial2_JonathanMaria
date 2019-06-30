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
        public static bool Guardar(Inscripciones Inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Inscripciones.Add(Inscripcion) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static Inscripciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripciones Inscripcion = new Inscripciones();
            try
            {
                Inscripcion = db.Inscripciones.Find(id);
                Inscripcion.Detalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Inscripcion;
        }
    }
}
