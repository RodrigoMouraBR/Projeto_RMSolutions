using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RM.Domain.Core.Entities;

namespace RM.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
         void Add(TEntity obj);
         void Update(TEntity obj);
         TEntity GetById(Guid id);
         IEnumerable<TEntity> GetAll();
         void Delete(Guid id);
         IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    }
}