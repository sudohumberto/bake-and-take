using BakeAndTake.Context;
using BakeAndTake.Models;
using BakeAndTake.Repositories.Abstract;

namespace BakeAndTake.Repositories.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BakeAndTakeDbContext _bakeAndTakeDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(BakeAndTakeDbContext bethanysPieShopDbContext, IShoppingCart shoppingCart)
        {
            _bakeAndTakeDbContext = bethanysPieShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            //adding the order with its details

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _bakeAndTakeDbContext.Orders.Add(order);

            _bakeAndTakeDbContext.SaveChanges();
        }
    }
}
