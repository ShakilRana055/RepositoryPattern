using RepositoryPattern.EntityModel;
using RepositoryPattern.Pattern.Interfaces.GeneralInterfaces;
using RepositoryPattern.Pattern.Repositories.BaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Pattern.Repositories.GeneralRepositories
{
    public class SubCategoryRepository:BaseRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository( DatabaseConnection.DatabaseConnection databaseConnection ):base(databaseConnection)
        {

        }
    }
}
