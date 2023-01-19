namespace TechShop.Models
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
                    new Product { Name = "The Dell XPS 15", Price = 12000.95M, ShortDescription = "The Dell XPS 15,10th Gen Intel Core i7 processor and 16GB of RAM and 512GB SSD.", LongDescription = "The Dell XPS 15 is a high-performance laptop powered by a 10th Gen Intel Core i7 processor and 16GB of RAM. It also features an NVIDIA GeForce GTX 1650 graphics card and a 512GB SSD hard drive.", Category = Categories["Laptops"], ImageUrl = "/DBInitializer/1.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/1.jpeg", AllergyInformation = "" },
                    new Product { Name = "The Lenovo ThinkPad T490s", Price = 6500.95M, ShortDescription = "The Lenovo ThinkPad T490s 8th Gen Intel Core i5 processor, 8GB of RAM and 256GB SSD ", LongDescription = "The Lenovo ThinkPad T490s is a business-class laptop equipped with a 8th Gen Intel Core i5 processor, 8GB of RAM, and integrated Intel UHD 620 graphics. It also has a 256GB SSD hard drive.", Category = Categories["Laptops"], ImageUrl = "/DBInitializer/2.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/2.jpeg", AllergyInformation = "" },
                    new Product { Name = "The HP Spectre x360", Price = 13000.95M, ShortDescription = "The HP Spectre x360 is a versatile 2-in-1 laptop powered by a 11th Gen Intel Core i7 processor and 16GB of RAM, and 1TB SSD ", LongDescription = "The HP Spectre x360 is a versatile 2-in-1 laptop powered by a 11th Gen Intel Core i7 processor and 16GB of RAM. It also features an NVIDIA GeForce MX450 graphics card and a 1TB SSD hard drive.", Category = Categories["Laptops"], ImageUrl = "/DBInitializer/3.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "\"/DBInitializer/3.jpeg", AllergyInformation = "" },
                    new Product { Name = "The ASUS ROG Zephyrus S GX701", Price = 16000.95M, ShortDescription = "The ASUS ROG Zephyrus S GX701 ,Intel Core i7-9750H processor and 32GB of DDR4 RAM,NVIDIA GeForce RTX 2070 graphics card with 8GB of GDDR6 VRAM and a 1TB NVMe SSD hard drive.", LongDescription = "The ASUS ROG Zephyrus S GX701 is a high-performance gaming laptop powered by a Intel Core i7-9750H processor and 32GB of DDR4 RAM. It also features an NVIDIA GeForce RTX 2070 graphics card with 8GB of GDDR6 VRAM and a 1TB NVMe SSD hard drive.", Category = Categories["Laptops"], ImageUrl = "/DBInitializer/4.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/4.jpeg", AllergyInformation = "" },
                    new Product { Name = "The Lenovo ThinkPad X1 Carbon", Price = 14000, ShortDescription = "The Lenovo ThinkPad X1 Carbon ,Intel Core i5-10210U processor, 8GB of LPDDR3 RAM , Intel UHD 620 graphics.and 256GB NVMe SSD hard drive.", LongDescription = "The Lenovo ThinkPad X1 Carbon is a business-class laptop with a 14-inch display, equipped with an Intel Core i5-10210U processor, 8GB of LPDDR3 RAM and integrated Intel UHD 620 graphics. It also has a 256GB NVMe SSD hard drive and a long battery life.", Category = Categories["Laptops"], ImageUrl = "/DBInitializer/5.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/5.jpeg", AllergyInformation = "" },


                    new Product { Name = "The Samsung Galaxy S21", Price = 6000.95M, ShortDescription = "The Samsung Galaxy S21 , 12GB of RAM and 4,000 mAh battery.", LongDescription = "The Samsung Galaxy S21 is a flagship smartphone powered by a Snapdragon 888 processor and 12GB of RAM. It also features a triple-lens camera system and a 4,000 mAh battery.", Category = Categories["Smart Phones"], ImageUrl = "/DBInitializer/6.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/6.jpeg", AllergyInformation = "" },
                    new Product { Name = "The iPhone 12 Pro Max", Price = 7500.95M, ShortDescription = "The iPhone 12 Pro Max ,6GB of RAM,triple-lens camera system and a 3,687 mAh battery.", LongDescription = "The iPhone 12 Pro Max is Apple's top-of-the-line smartphone, featuring an A14 Bionic chip and 6GB of RAM. It also has a triple-lens camera system and a 3,687 mAh battery.", Category = Categories["Smart Phones"], ImageUrl = "/DBInitializer/7.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/7.jpeg", AllergyInformation = "" },
                    new Product { Name = "The Google Pixel 5", Price = 5000.95M, ShortDescription = "The Google Pixel 5 ,Snapdragon 765G processor , 8GB of RAM and a 4,080 mAh battery.", LongDescription = "The Google Pixel 5 is a high-end smartphone powered by a Snapdragon 765G processor and 8GB of RAM. It also features a dual-lens camera system and a 4,080 mAh battery.", Category = Categories["Smart Phones"], ImageUrl = "/DBInitializer/8.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/8.jpeg", AllergyInformation = "" },
                    new Product { Name = "The OnePlus 9 Pro", Price = 7000.95M, ShortDescription = "The OnePlus 9 Pro Snapdragon 888 processor and 12GB of RAM. quad-lens camera system with a 48MP main lens and a 4500 mAh battery .", LongDescription = "The OnePlus 9 Pro is a high-end smartphone powered by a Snapdragon 888 processor and 12GB of RAM. It also features a quad-lens camera system with a 48MP main lens and a 4500 mAh battery with fast charging and wireless charging capabilities.", Category = Categories["Smart Phones"], ImageUrl = "/DBInitializer/9.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/9.jpeg", AllergyInformation = "" },
                    new Product { Name = "The Oppo Find X2 Pro ", Price = 9000.95M, ShortDescription = "The Oppo Find X2 Pro ,Snapdragon 865 processor and 12GB of RAM,triple-lens camera system with a 48MP main lens and a 4200 mAh battery .", LongDescription = "The Oppo Find X2 Pro is a flagship smartphone powered by a Snapdragon 865 processor and 12GB of RAM. It also features a triple-lens camera system with a 48MP main lens and a 4200 mAh battery with fast charging and wireless charging capabilities.", Category = Categories["Smart Phones"], ImageUrl = "/DBInitializer/10.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/10.jpeg", AllergyInformation = "" },


                    new Product { Name = "The iPad Pro", Price = 5000.95M, ShortDescription = "The iPad Pro ,the A12Z Bionic chip and 6GB of RAM.", LongDescription = "The iPad Pro is a high-performance tablet from Apple, powered by the A12Z Bionic chip and 6GB of RAM. It also features a dual-lens camera system and a 10.5-inch Retina display.", Category = Categories["Tablet"], ImageUrl = "/DBInitializer/11.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/11.jpeg", AllergyInformation = "" },
                    new Product { Name = "Samsung Galaxy Tab S6", Price = 6000.95M, ShortDescription = "Samsung Galaxy Tab S6 ,Snapdragon 855 processor ,6GB of RAM, dual-lens camera system and an S Pen stylus for drawing and note-taking.", LongDescription = "Samsung Galaxy Tab S6 - A high-end tablet with a 10.5-inch Super AMOLED display, powered by a Snapdragon 855 processor and 6GB of RAM. It also features a dual-lens camera system and an S Pen stylus for drawing and note-taking.", Category = Categories["Tablet"], ImageUrl = "/DBInitializer/12.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/12.jpeg", AllergyInformation = "" },
                    new Product { Name = "Samsung Galaxy Tab A7", Price = 7500.95M, ShortDescription = "Samsung Galaxy Tab A7 - A mid-range tablet with a 10.4-inch ,Snapdragon 662 processor , 3GB of RAM, 8MP main camera and a 7,040mAh battery.", LongDescription = "Samsung Galaxy Tab A7 - A mid-range tablet with a 10.4-inch TFT LCD display, powered by a Snapdragon 662 processor and 3GB of RAM. It also has a 8MP main camera and a 7,040mAh battery.", Category = Categories["Tablet"], ImageUrl = "/DBInitializer/13.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/13.jpeg", AllergyInformation = "" },
                    new Product { Name = "iPad (8th Gen)", Price = 3500.95M, ShortDescription = "iPad (8th Gen) - A budget-friendly tablet with a 10.2-inch Retina display,A12 Bionic chip , 3GB of RAM, and  8MP main camera", LongDescription = "iPad (8th Gen) - A budget-friendly tablet with a 10.2-inch Retina display, powered by the A12 Bionic chip and 3GB of RAM. It also features a Touch ID fingerprint sensor and a 8MP main camera.", Category = Categories["Tablet"], ImageUrl = "/DBInitializer/14.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/14.jpeg", AllergyInformation = "" },
                    new Product { Name = "iPad Pro (2nd Gen) ", Price = 2000.95M, ShortDescription = "iPad Pro (11-inch) (2nd Gen) the A12Z Bionic chip and up to 6GB of RAM, dual-lens camera system, Face ID and supports the Apple Pencil and Smart Keyboard.", LongDescription = "iPad Pro (11-inch) (2nd Gen) - A high-performance tablet with a 11-inch Liquid Retina display, powered by the A12Z Bionic chip and up to 6GB of RAM. It also features a dual-lens camera system, Face ID and supports the Apple Pencil and Smart Keyboard.", Category = Categories["Tablet"], ImageUrl = "/DBInitializer/15.jpeg", InStock = true, IsProductOfTheWeek = true, ImageThumbnailUrl = "/DBInitializer/15.jpeg", AllergyInformation = "" });

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
                        new Category { CategoryName = "Smart Phones" },
                        new Category { CategoryName = "Laptops" },
                        new Category { CategoryName = "Tablet" }
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
