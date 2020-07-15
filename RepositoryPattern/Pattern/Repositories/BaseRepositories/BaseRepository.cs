using RepositoryPattern.DatabaseConnection;
using RepositoryPattern.Pattern.Interfaces.BaseInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryPattern.Pattern.Repositories.BaseRepositories
{
    public class BaseRepository<TEntity>:IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DatabaseConnection.DatabaseConnection context;
        public BaseRepository( DatabaseConnection.DatabaseConnection databaseConnection)
        {
            context = databaseConnection;
        }

        // Implementing IBaseRepository

        #region Searching
        public TEntity Get(int Id)
        {
            return context.Set<TEntity>().Find(Id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public IEnumerable<TEntity> Find( Expression <Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }
        #endregion

        #region Saving
        public void Save(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }
        public void SaveAll(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }
        #endregion

        #region Deleting
        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
        public void RemoveAll(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }
        #endregion
    }
}
