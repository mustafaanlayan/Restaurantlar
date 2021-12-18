using Restaurant.Entites.Interfaces;
using Restaurantt.DataAcces.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantt.DataAcces.UnitOfWork
{
  public  interface IUnitOfWork:IDisposable
    {
        IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new();
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}
