﻿namespace TechShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            TechShopDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TechShopDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product { Name = "Caramel Popcorn Cheese Cake", Price = 22.95M, ShortDescription = "The ultimate cheese cake", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Cheese cakes"], ImageUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", AllergyInformation = "" },
                    new Product { Name = "Chocolate Cheese Cake", Price = 19.95M, ShortDescription = "The chocolate lover's dream", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Cheese cakes"], ImageUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", AllergyInformation = "" },
                    new Product { Name = "Pistache Cheese Cake", Price = 21.95M, ShortDescription = "We're going nuts over this one", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Cheese cakes"], ImageUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", AllergyInformation = "" },
                    new Product { Name = "Pecan Product", Price = 21.95M, ShortDescription = "More pecan than you can handle!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Fruit Products"], ImageUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://www.shutterstock.com/image-photo/closeup-photo-male-hands-laptop-600w-1922573471.jpg", AllergyInformation = "" },
                    new Product { Name = "Birthday Product", Price = 29.95M, ShortDescription = "A Happy Birthday with this Product!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Seasonal Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/seasonal/birthdayProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/seasonal/birthdaypiesmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Apple Product", Price = 12.95M, ShortDescription = "Our famous apple Products!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Fruit Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/appleProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/appleProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Cheese cakes"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/cheesecakes/blueberrycheesecake.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/cheesecakes/blueberrycheesecakesmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Cheese cakes"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/cheesecakes/cheesecake.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/TechShop/cheesecakes/cheesecakesmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Cherry Product", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Fruit Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Christmas Apple Product", Price = 13.95M, ShortDescription = "Happy holidays with this Product!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Seasonal Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Cranberry Product", Price = 17.95M, ShortDescription = "A Christmas favorite", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Seasonal Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Peach Product", Price = 15.95M, ShortDescription = "Sweet as peach", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Fruit Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachProduct.jpg", InStock = false, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Pumpkin Product", Price = 12.95M, ShortDescription = "Our Halloween favorite", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Seasonal Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Rhubarb Product", Price = 15.95M, ShortDescription = "My God, so sweet!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Fruit Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Strawberry Product", Price = 15.95M, ShortDescription = "Our delicious strawberry Product!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Fruit Products"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryProduct.jpg", InStock = true, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryProductsmall.jpg", AllergyInformation = "" },
                    new Product { Name = "Strawberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Product chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Product muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Product cake danish lemon drops. Brownie cupcake dragée gummies.", Category = Categories["Cheese cakes"], ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", InStock = false, IsProductOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", AllergyInformation = "" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fruit Products" },
                        new Category { CategoryName = "Cheese cakes" },
                        new Category { CategoryName = "Seasonal Products" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}