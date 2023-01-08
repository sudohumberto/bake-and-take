using BakeAndTake.Models;

namespace BakeAndTake.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
