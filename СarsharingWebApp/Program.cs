using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using OrderApiApp.Service.ClientService;
using ÑarsharingWebApp.Model;
using ÑarsharingWebApp.Service.CarOrderService;
using ÑarsharingWebApp.Service.ClientService;
using ÑarsharingWebApp.Service.CarBrandService;
using ÑarsharingWebApp.Service.CarConditionService;
using ÑarsharingWebApp.Service.CarModelService;
using ÑarsharingWebApp.Service.CarCarOwner;
using ÑarsharingWebApp.Service.CarService;
using ÑarsharingWebApp.Service.CarServService;
using ÑarsharingWebApp.Service.OrderRateService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Àâòîðèçàöèÿ ñ ïîìîùüþ Cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => options.LoginPath = "/login");
builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IDaoCarBrand, DbDaoCarBrand>();
builder.Services.AddTransient<IDaoCarCondition, DbDaoCarCondition>();
builder.Services.AddTransient<IDaoCarModel, DbDaoCarModel>();
builder.Services.AddTransient<IDaoCarOwner, DbDaoCarOwner>();
builder.Services.AddTransient<IDaoCar, DbDaoCar>();
builder.Services.AddTransient<IDaoCarServ, DbDaoCarServ>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();
builder.Services.AddTransient<IDaoOrderRate, DbDaoOrderRate>();
builder.Services.AddTransient<IDaoOrder, DbDaoOrder>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{login?}/{password?}");



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapRazorPages();

app.Run();
