using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechShop.Repositories;
using TechShop.DAO;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TechShopDbContextConnection") ?? throw new InvalidOperationException("Connection string 'TechShopDbContextConnection' not found.");

builder.Services.AddDbContext<TechShopDbContext>(options =>
    options.UseSqlServer(connectionString)); ;

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<TechShopDbContext>();

builder.Services.AddControllersWithViews();


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();


builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<TechShopDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:TechShopDbContextConnection"]);
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.MapBlazorHub();

app.MapFallbackToPage("/app/{*catchall}", "/App/Index");


DbInitializer.Seed(app);

app.Run();
