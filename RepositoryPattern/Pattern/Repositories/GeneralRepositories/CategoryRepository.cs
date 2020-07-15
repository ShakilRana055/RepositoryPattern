using RepositoryPattern.EntityModel;
using RepositoryPattern.Pattern.Interfaces.BaseInterfaces;
using RepositoryPattern.Pattern.Interfaces.GeneralInterfaces;
using RepositoryPattern.Pattern.Repositories.BaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Pattern.Repositories.GeneralRepositories
{
    public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository( DatabaseConnection.DatabaseConnection databaseConnection ):base(databaseConnection)
        {
            
        }
    }
}
