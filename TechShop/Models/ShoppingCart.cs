using Microsoft.EntityFrameworkCore;

namespace TechShop.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly TechShopDbContext _TechShopDbContext;

        public string? ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(TechShopDbContext TechShopDbContext)
        {
            _TechShopDbContext = TechShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            TechShopDbContext context = services.GetService<TechShopDbContext>() ?? throw new Exception("Error initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product)
        {
            var shoppingCartItem =
                    _TechShopDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Amount = 1
                };

                _TechShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _TechShopDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem =
                    _TechShopDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _TechShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _TechShopDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??=
                       _TechShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Product)
                           .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _TechShopDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _TechShopDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _TechShopDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _TechShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.Amount).Sum();
            return total;
        }
    }
}
