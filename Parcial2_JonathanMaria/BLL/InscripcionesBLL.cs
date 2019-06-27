using Parcial2_JonathanMaria.DAL;
using Parcial2_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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
            decimal val = 0;
            try
            {
                if (_contexto.Inscripciones.Add(inscripcion) != null)
                {
                    foreach(var item in inscripcion.Detalle)
                    {
                        val = _contexto.Asignaturas.Find(item.AsignaturaId).Precio;
                        inscripcion.Valor += val;
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

        public static bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto _contexto = new Contexto();
            decimal val = 0;
            try
            {
                var Anterior = Buscar(inscripcion.InscripcionId);
                foreach (var item in Anterior.Detalle)
                {
                    if (!inscripcion.Detalle.ToList().Exists(v => v.AsignaturaId == item.AsignaturaId))
                    {
                        val = _contexto.Asignaturas.Find(item.AsignaturaId).Precio;
                        inscripcion.Valor -= val;
                    }
                }

                foreach (var item in inscripcion.Detalle)
                {
                    var estado = item.AsignaturaId > 0 ? EntityState.Modified : EntityState.Added;
                    _contexto.Entry(item).State = estado;
                }
                _contexto.Entry(inscripcion).State = EntityState.Modified;
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
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto _contexto = new Contexto();
            try
            {
                var eliminar = _contexto.Inscripciones.Find(id);
                _contexto.Entry(eliminar).State = EntityState.Deleted;
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

        public static Inscripciones Buscar(int id)
        {
            Contexto _contexto = new Contexto();
            Inscripciones inscripcion = new Inscripciones();
            try
            {
                inscripcion = _contexto.Inscripciones.Find(id);
                inscripcion.Detalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return inscripcion;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> inscripcion)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto _contexto = new Contexto();
            try
            {
                Lista = _contexto.Inscripciones.Where(inscripcion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return Lista;
        }
    }
}
