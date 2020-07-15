using RepositoryPattern.EntityModel;
using RepositoryPattern.Pattern.Interfaces.GeneralInterfaces;
using RepositoryPattern.Pattern.Interfaces.IUnitOfWorks;
using RepositoryPattern.Pattern.Repositories.GeneralRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Pattern.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseConnection.DatabaseConnection context;
        public UnitOfWork( DatabaseConnection.DatabaseConnection databaseConnection)
        {
            context = databaseConnection;
            Categories = new CategoryRepository(context); 
        }

        #region SaveChanges
        public int Save()
        {
            return context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
        #endregion

        #region Implementation
        public ICategoryRepository Categories { get; private set; }
        #endregion
    }
}
