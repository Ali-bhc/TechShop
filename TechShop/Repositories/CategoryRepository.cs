using TechShop.DAO;
using TechShop.Models;

namespace TechShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TechShopDbContext _TechShopDbContext;

        public CategoryRepository(TechShopDbContext TechShopDbContext)
        {
            _TechShopDbContext = TechShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _TechShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
