using BakeAndTake.Models;

namespace BakeAndTake.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; } = null!;
        public decimal ShoppingCartTotal { get; set; }
    }
}
