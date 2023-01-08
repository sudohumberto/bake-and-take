using BakeAndTake.Context;
using BakeAndTake.Repositories.Abstract;
// using BakeAndTake.Repositories.Mocks;
using BakeAndTake.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BakeAndTakeDbContext>(options => {
    options.UseSqlServer(builder.Configuration["ConnectionStrings:BakeAndTakeDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();

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

DbInitializer.Seed(app);

app.Run();
