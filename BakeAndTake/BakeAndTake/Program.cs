using BakeAndTake.Context;
using BakeAndTake.Repositories.Abstract;
using BakeAndTake.Repositories.Mocks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BakeAndTakeDbContext>(options => {
    options.UseSqlServer(builder.Configuration["BakeAndTakeDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
