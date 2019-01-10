

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RM.Data.Context;
using RM.Domain.Core.Entities;
using RM.Domain.Interfaces;

namespace RM.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected RMContext Db;
        protected DbSet<TEntity> DbSet;
        public Repository(RMContext context) 
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Update(TEntity obj)
        {
           DbSet.Update(obj);
           //var entry = Db.Entry(obj);
           //DbSet.Attach(obj);
           //entry.State = EntityState.Modified;
        }
    }
}