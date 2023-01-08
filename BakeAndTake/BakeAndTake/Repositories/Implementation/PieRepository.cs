using BakeAndTake.Context;
using BakeAndTake.Models;
using BakeAndTake.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BakeAndTake.Repositories.Implementation
{
    public class PieRepository : IPieRepository
    {
        public readonly BakeAndTakeDbContext _bakeAndTakeDbContext;

        public PieRepository(BakeAndTakeDbContext bakeAndTakeDbContext)
        {
            _bakeAndTakeDbContext = bakeAndTakeDbContext;
        }

        public IEnumerable<Pie> AllPies {
            get 
            {
                return _bakeAndTakeDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bakeAndTakeDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _bakeAndTakeDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
