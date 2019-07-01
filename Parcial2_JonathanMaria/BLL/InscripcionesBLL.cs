using Parcial2_JonathanMaria.DAL;
using Parcial2_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                {
                    db.Estudiantes.Find(Inscripcion.EstudianteId).Balance = Inscripcion.Valor;
                    paso = db.SaveChanges() > 0;
                }
                   
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

        public static bool Modificar(Inscripciones Inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = Buscar(Inscripcion.InscripcionId);
                foreach (var item in Anterior.Detalle)
                {
                    if(!Inscripcion.Detalle.ToList().Exists(p => p.IDID == item.IDID))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in Inscripcion.Detalle)
                {
                    if (item.IDID == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }

                db.Estudiantes.Find(Inscripcion.EstudianteId).Balance = Inscripcion.Valor;
                db.Entry(Inscripcion).State = EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Inscripciones.Find(id);
                Inscripciones Inscripcion = Buscar(eliminar.InscripcionId);
                db.Entry(eliminar).State = EntityState.Deleted;
                db.Estudiantes.Find(Inscripcion.EstudianteId).Balance -= Inscripcion.Valor;
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
