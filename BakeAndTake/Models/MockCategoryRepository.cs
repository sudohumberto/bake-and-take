namespace BakeAndTake.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ Id = 1, Name = "Fruit pies", Description = "All-fruit pie" },
                new Category{ Id = 1, Name = "Cheese cakes", Description = "Cheesy all the way" },
                new Category{ Id = 1, Name = "Seasonal pies", Description = "Get in the mood for a seasonal pie" }
            };
    }
}
