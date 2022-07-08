using BakeAndTake.Models;

namespace BakeAndTake.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; } = null!;
        public string CurrentCategory { get; set; } = null!;
    }
}
