using Microsoft.EntityFrameworkCore;
using Registro_Completo.DAL;
using Registro_Completo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Registro_Completo.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Persona persona)
        {
            if (!Existe(persona.PersonaId))
                return Insertar(persona);
            else
                return Modificar(persona);
        }

        private static bool Insertar(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Agregar la persona que se desea insertar al contexto
                contexto.Personas.Add(persona);
                paso = contexto.SaveChanges() > 0;
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
        private static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //marcar la persona como modificada para que el contexto sepa como proceder
                contexto.Entry(persona).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
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
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //buscar la persona que se desea eliminar
                var adicionales = PersonasBLL.Buscar(id);

                if (adicionales != null)
                {
                    contexto.Personas.Remove(adicionales); //Borra la persona
                    paso = contexto.SaveChanges() > 0;
                }

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
        public static Persona Buscar(int id)
        {
            Persona persona = new Persona();
            Contexto contexto = new Contexto();

            try
            {
                persona = contexto.Personas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return persona;
        }
        public static List<Persona> GetList(Expression<Func<Persona, bool>> criterio)
        {
            List<Persona> Lista = new List<Persona>();
            Contexto contexto = new Contexto();

            try
            {
                //obtiene la lista de persona y filtrarla según el criterio recibido por parametro.
                Lista = contexto.Personas.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Personas.Any(e => e.PersonaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
    }
}
