using TechShop.Models;

namespace TechShop.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product? GetProductById(int productId);
        IEnumerable<Product> SearchProducts(string searchQuery);
    }
}
