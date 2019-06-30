using Parcial2_JonathanMaria.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JonathanMaria.BLL
{
    public class AsignaturasBLL
    {
        public static bool Existe(string descipcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Asignaturas.Any(p => p.Descripcion.Equals(descipcion)))
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }
    }
}
