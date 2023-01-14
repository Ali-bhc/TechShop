namespace TechShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TechShopDbContext _TechShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(TechShopDbContext TechShopDbContext, IShoppingCart shoppingCart)
        {
            _TechShopDbContext = TechShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Price = shoppingCartItem.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _TechShopDbContext.Orders.Add(order);

            _TechShopDbContext.SaveChanges();
        }
    }
}
