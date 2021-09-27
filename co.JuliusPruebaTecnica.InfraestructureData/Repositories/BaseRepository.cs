using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Repositories;
using co.JuliusPruebaTecnica.InfraestructureData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace co.JuliusPruebaTecnica.InfraestructureData.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {

            try
            {
                using (var context = new JuliusContext())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede guardar el registro", ex);
            }
        }


        public void Delete(int id)
        {
            try
            {
                using (var context = new JuliusContext())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el registro", ex);
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }


        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new JuliusContext())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }


        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new JuliusContext())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo recuperar el registro", ex);
            }
        }


        public void Modify(TEntity entity)
        {

            try
            {
                using (var context = new JuliusContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede actualizar el registro", ex);
            }
        }
    }
}
