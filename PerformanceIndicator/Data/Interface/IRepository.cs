using PerformanceIndicator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceIndicator.Data.Interface
{
   public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAllUsers();
        TEntity Get(int Id);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Save();
    }
}
