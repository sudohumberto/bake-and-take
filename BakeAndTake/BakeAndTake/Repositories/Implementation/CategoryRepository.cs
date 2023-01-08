using BakeAndTake.Context;
using BakeAndTake.Models;
using BakeAndTake.Repositories.Abstract;

namespace BakeAndTake.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly BakeAndTakeDbContext _bakeAndTakeDbContext;

        public CategoryRepository(BakeAndTakeDbContext bakeAndTakeDbContext)
        {
            _bakeAndTakeDbContext = bakeAndTakeDbContext;
        }

        public IEnumerable<Category> AllCategories => 
            _bakeAndTakeDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
