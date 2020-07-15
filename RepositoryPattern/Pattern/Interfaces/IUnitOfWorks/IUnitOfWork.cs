using RepositoryPattern.Pattern.Interfaces.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Pattern.Interfaces.IUnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        int Save();
        ICategoryRepository Categories { get; }
    }
}
