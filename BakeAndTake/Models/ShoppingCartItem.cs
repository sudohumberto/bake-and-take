﻿namespace BakeAndTake.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pie Pie { get; set; } = null!;
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; } = null!;
    }
}
