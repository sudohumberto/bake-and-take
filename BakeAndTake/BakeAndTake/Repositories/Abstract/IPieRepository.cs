using BakeAndTake.Models;

namespace BakeAndTake.Repositories.Abstract
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int pieId);
    }
}
