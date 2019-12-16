using Microsoft.EntityFrameworkCore;
using PerformanceIndicator.Data.Interface;
using PerformanceIndicator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceIndicator.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected Context db;
        public Repository(Context db)
        {
            this.db = db;
        }
        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity Get(int Id)
        {
           return db.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAllUsers()
        {
            return db.Set<TEntity>().ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            db.Entry(entity).State=EntityState.Modified;
        }
    }
}
