using BakeAndTake.Context;
using BakeAndTake.Models;
using BakeAndTake.Repositories.Abstract;
// using BakeAndTake.Repositories.Mocks;
using BakeAndTake.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews().AddJsonOptions(options => 
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddDbContext<BakeAndTakeDbContext>(options => {
    options.UseSqlServer(builder.Configuration["ConnectionStrings:BakeAndTakeDbContextConnection"]);
});

//builder.Services.AddControllers(); // API

var app = builder.Build();

app.UseStaticFiles();

app.UseSession();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
*/

// app.MapControllers(); // API

DbInitializer.Seed(app);

app.Run();
