using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1erParcial_JonathanMaria.DAL;
using _1erParcial_JonathanMaria.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1erParcial_JonathanMaria.Controllers
{
    public class ArticulosController
    {
        public bool Guardar(Articulos Articulo)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Articulos.Add(Articulo);
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

        public bool Modificar(Articulos Articulo)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(Articulo).State = EntityState.Modified;
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

        public bool Eliminar(int Id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                Articulos Articulo = contexto.Articulos.Find(Id);
                contexto.Entry(Articulo).State = EntityState.Deleted;
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

        public Articulos Buscar(int Id)
        {

            Contexto contexto = new Contexto();
            Articulos Articulo = new Articulos();

            try
            {
                Articulo = contexto.Articulos.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Articulo;
        }
    }
}
