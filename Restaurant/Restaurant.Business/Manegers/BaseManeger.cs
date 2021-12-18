using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Business.Services.Base;
using Restaurant.Entites.Interfaces;
using System.ComponentModel;
using Restaurantt.DataAcces.UnitOfWork;

namespace Restaurant.Business.Manegers
{
    public class BaseManeger<TEntity> : IBaseServices<TEntity> where TEntity : class, IEntity, new()
    {
        private IUnitOfWork _uow;

        public BaseManeger(IUnitOfWork uow)
        {
            _uow = uow;
        }
        private bool disposedValue;

        public virtual void Add(TEntity entity)
        {
            _uow.Dal<TEntity>().Add(entity);
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().Add(entities);
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
            _uow.Dal<TEntity>().AddOrUpdate(entity);
        }

        public virtual void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().AddOrUpdate(entities);
        }

        public virtual System.ComponentModel.BindingList<TEntity> BindingList()
        {
          return  _uow.Dal<TEntity>().BindingList();
        }

        public virtual void Delete(TEntity entity)
        {
            _uow.Dal<TEntity>().Delete(entity);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().Delete(entities);
        }

        public virtual void Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            _uow.Dal<TEntity>().Delete(filter);
        }

        public virtual bool Exist(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
           return _uow.Dal<TEntity>().Exist(filter);
        }

        public virtual TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter, params System.Linq.Expressions.Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().Get(filter, includes);
        }

        public virtual IEnumerable<TEntity> GetList(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter, params System.Linq.Expressions.Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().GetList(filter, includes);
        }

        public  bool HasChanges()
        {
            return _uow.Dal<TEntity>().HasChanges();
        }

        public virtual void Load(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter, params System.Linq.Expressions.Expression<Func<TEntity, object>>[] includes)
        {
             _uow.Dal<TEntity>().Load(filter, includes);
        }

        public virtual IQueryable<TEntity> Select(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter, System.Linq.Expressions.Expression<Func<TEntity, TEntity>> selector, params System.Linq.Expressions.Expression<Func<TEntity, object>>[] includes)
        { 
           return _uow.Dal<TEntity>().Select(filter,selector ,includes);
        }

        public virtual IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter, System.Linq.Expressions.Expression<Func<TEntity, TResult>> selector, params System.Linq.Expressions.Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual void Update(TEntity entity)
        {
             _uow.Dal<TEntity>().Update(entity);
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
             _uow.Dal<TEntity>().Update(entities);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseManeger()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
