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
            Category = new CategoryRepository(context);
            SubCategory = new SubCategoryRepository(context);
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
        public ICategoryRepository Category { get; private set; }
        public ISubCategoryRepository SubCategory { get; private set; }
        #endregion
    }
}
