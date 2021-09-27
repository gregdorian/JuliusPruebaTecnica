

using co.JuliusPruebaTecnica.Aplicacion.Interfaces;
using co.JuliusPruebaTecnica.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace co.JuliusPruebaTecnica.Aplicacion.Services
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        
        private readonly IBaseService<TEntity> baseService;


        public BaseAppService(IBaseService<TEntity> baseService)
        {
            this.baseService = baseService;
        }

        public BaseAppService(IPostsAppService postsService)
        {
        }

        public void Add(TEntity entity)
        {
            this.baseService.Add(entity);
        }

  
        public void Delete(int id)
        {
            this.baseService.Delete(id);
        }

        public void Dispose()
        {
            this.baseService.Dispose();
        }



        public TEntity GetById(int id)
        {
            return this.baseService.GetById(id);
        }


        public void Modify(TEntity entity)
        {
            this.baseService.Modify(entity);
        }

        IEnumerable<TEntity> IBaseAppService<TEntity>.GetAll()
        {
            return this.baseService.GetAll();
        }
    }
}
