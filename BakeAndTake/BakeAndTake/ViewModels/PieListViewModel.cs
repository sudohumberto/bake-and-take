using BakeAndTake.Models;

namespace BakeAndTake.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; } = null!;
        public string? CurrentCategory { get; set; }

        public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
        {
            Pies = pies;
            CurrentCategory = currentCategory;
        }
    }
}
