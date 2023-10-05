using TechShop.Models;

namespace TechShop.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
