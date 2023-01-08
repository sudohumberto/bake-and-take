using BakeAndTake.Models;

namespace BakeAndTake.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; } = null!;

        public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
        {
            PiesOfTheWeek = piesOfTheWeek;
        }
    }
}
