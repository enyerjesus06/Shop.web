using Microsoft.EntityFrameworkCore;
using Shop.DAL.Context;
using Shop.DAL.Daos;
using Shop.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Registrar el Contexto
builder.Services.AddDbContext<ShopContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ShopContext")));
builder.Services.AddScoped<ICategoriesDb, CategoriesDb>();
builder.Services.AddScoped<ICustomersDb, CustomersDb>();
builder.Services.AddScoped<IEmployeesDb, EmployeesDb>();
builder.Services.AddScoped<IOrderDb, OrderDb>();
builder.Services.AddScoped<IOrderDetailsDb, OrderDetailsDb>();
builder.Services.AddScoped<IProductsDb, ProductsDb>();
builder.Services.AddScoped<IShippersDb, ShippersDb>();
builder.Services.AddScoped<ISuppliersDb, SuppliersDb>();


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
