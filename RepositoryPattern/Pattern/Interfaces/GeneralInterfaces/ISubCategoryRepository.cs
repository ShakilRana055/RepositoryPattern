using RepositoryPattern.EntityModel;
using RepositoryPattern.Pattern.Interfaces.BaseInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Pattern.Interfaces.GeneralInterfaces
{
    public interface ISubCategoryRepository : IBaseRepository<SubCategory>
    {
    }
}
