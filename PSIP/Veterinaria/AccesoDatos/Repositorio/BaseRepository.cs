using DominioModelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class BaseRpository<TEntity> : IDisponsable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el registro.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Eliminar el registro.", ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Encontrar el registro.", ex);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Remplazar el registro.", ex);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {

                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar registro", ex);
            }
        }
    }

    internal interface IDisponsable
    {
    }
}
