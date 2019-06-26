﻿using Parcial2_JonathanMaria.DAL;
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
        public static bool Guardar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto _contexto = new Contexto();
            try
            {
                if (_contexto.Inscripciones.Add(inscripcion) != null)
                {
                    foreach(var item in inscripcion.Detalle)
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

        public static bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto _contexto = new Contexto();
            try
            {
                var Anterior = Buscar(inscripcion.InscripcionId);
                foreach (var item in Anterior.Detalle)
                {
                    if (!inscripcion.Detalle.ToList().Exists(v => v.AsignaturaId == item.AsignaturaId))
                    {
                        _contexto.Estudiantes.Find(item.EstudianteId).Balance -= item.Valor;
                        _contexto.Entry(item).State = EntityState.Deleted;
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
    }
}
