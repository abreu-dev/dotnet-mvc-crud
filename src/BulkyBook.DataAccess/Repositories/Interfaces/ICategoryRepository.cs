using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
