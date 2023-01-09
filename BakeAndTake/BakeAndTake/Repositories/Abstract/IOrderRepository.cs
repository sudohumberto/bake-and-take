using BakeAndTake.Models;

namespace BakeAndTake.Repositories.Abstract
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
