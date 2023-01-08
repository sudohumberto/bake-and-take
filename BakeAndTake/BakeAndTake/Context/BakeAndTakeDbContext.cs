using BakeAndTake.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeAndTake.Context
{
    public class BakeAndTakeDbContext : DbContext
    {
        public BakeAndTakeDbContext(DbContextOptions<BakeAndTakeDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
