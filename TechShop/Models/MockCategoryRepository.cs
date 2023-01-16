namespace TechShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Smart Phones", Description="All-fruity Products"},
                new Category{CategoryId=2, CategoryName="Laptops", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal Products", Description="Get in the mood for a seasonal Product"}
            };
    }
}
