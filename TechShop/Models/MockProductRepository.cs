namespace TechShop.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {ProductId = 1, Name="Strawberry Product", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/fruitProducts/strawberryProduct.jpg", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/fruitProducts/strawberryProductsmall.jpg"},
                new Product {ProductId = 2, Name="Cheese cake", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/cheesecakes/cheesecake.jpg", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/cheesecakes/cheesecakesmall.jpg"},
                new Product {ProductId = 3, Name="Rhubarb Product", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/fruitProducts/rhubarbProduct.jpg", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/fruitProducts/rhubarbProductsmall.jpg"},
                new Product {ProductId = 4, Name="Pumpkin Product", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/seasonal/pumpkinProduct.jpg", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/seasonal/pumpkinProductsmall.jpg"}
            };

        public IEnumerable<Product> ProductsOfTheWeek
        {
            get
            {
                return AllProducts.Where(p => p.IsProductOfTheWeek);
            }
        }

        public Product? GetProductById(int productId) => AllProducts.FirstOrDefault(p => p.ProductId == productId);

        public IEnumerable<Product> SearchProducts(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
