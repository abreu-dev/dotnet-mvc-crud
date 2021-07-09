using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repositories.Interfaces;
using BulkyBook.Models;
using System.Linq;

namespace BulkyBook.DataAccess.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Update(Category category)
        {
            var objFromDb = _dbSet.FirstOrDefault(f => f.CategoryId == category.CategoryId);

            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
