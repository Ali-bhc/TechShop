using TechShop.Models;

namespace TechShop.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
