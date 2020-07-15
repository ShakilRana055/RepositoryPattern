using Microsoft.EntityFrameworkCore;
using RepositoryPattern.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.DatabaseConnection
{
    public class DatabaseConnection:DbContext
    {
        public DatabaseConnection( DbContextOptions<DatabaseConnection> _context ):base(_context)
        {

        }

        DbSet<Category> Categories { get; set; }
        DbSet<SubCategory> SubCategories { get; set; }
    }
}
