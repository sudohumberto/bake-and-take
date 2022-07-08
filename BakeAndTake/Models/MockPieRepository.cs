namespace BakeAndTake.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie 
                { 
                    Id = 1, 
                    Name = "Strawberry Pie", 
                    Price = 15.95M, 
                    ShortDescription = "Lorem Ipsum",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="~/images/strawberry-pie.jpg", 
                    InStock=true, 
                    IsPieOfTheWeek=false, 
                    ImageThumbnail="~/images/strawberry-pie-small.jpg"
                },
                new Pie 
                { 
                    Id = 2, 
                    Name = "Cheese Cake", 
                    Price = 18.95M, 
                    ShortDescription = "Lorem Ipsum",
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    ImageUrl="~/images/lemon-cheesecake.jpg",
                    InStock=true,
                    IsPieOfTheWeek=false,
                    ImageThumbnail="~/images/lemon-cheesecake-small.jpg"
                },
                new Pie 
                { 
                    Id = 3, 
                    Name = "Apple Pie", 
                    Price = 15.95M, 
                    ShortDescription = "Lorem Ipsum",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="~/images/apple-pie.jpg", 
                    InStock=true, 
                    IsPieOfTheWeek=false, 
                    ImageThumbnail="~/images/apple-pie-small.jpg"
                },
                new Pie 
                { 
                    Id = 4, 
                    Name = "PumpkinPie", 
                    Price = 12.95M, 
                    ShortDescription = "Lorem Ipsum",
                    Category = _categoryRepository.AllCategories.ToList()[2],
                    ImageUrl="~/images/pumpkin-pie.jpg", 
                    InStock=true, 
                    IsPieOfTheWeek=true, 
                    ImageThumbnail="~/images/pumpkin-pie-small.jpg"
                },
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; } = null!;

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.Id == pieId)!;
        }
    }
}
