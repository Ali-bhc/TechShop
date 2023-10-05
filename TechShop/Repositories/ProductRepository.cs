using Microsoft.EntityFrameworkCore;
using TechShop.DAO;
using TechShop.Models;

namespace TechShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TechShopDbContext _TechShopDbContext;

        public ProductRepository(TechShopDbContext TechShopDbContext)
        {
            _TechShopDbContext = TechShopDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _TechShopDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> ProductsOfTheWeek
        {
            get
            {
                return _TechShopDbContext.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek);
            }
        }

        public Product? GetProductById(int productId)
        {
            return _TechShopDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> SearchProducts(string searchQuery)
        {
            return _TechShopDbContext.Products.Where(p => p.Name.Contains(searchQuery));
        }
    }
}
