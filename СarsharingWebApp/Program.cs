using OrderApiApp.Service.ClientService;
using �arsharingWebApp.Model;
using �arsharingWebApp.Service.CarOrderService;
using �arsharingWebApp.Service.ClientService;
using �arsharingWebApp.Service.CarBrandService;
using �arsharingWebApp.Service.CarConditionService;
using �arsharingWebApp.Service.CarModelService;
using �arsharingWebApp.Service.CarCarOwner;
using �arsharingWebApp.Service.CarService;
using �arsharingWebApp.Service.CarServService;
using �arsharingWebApp.Service.OrderRateService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

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


/*app.MapControllerRoute(
    name: "carsharing",
    pattern: "{controller = Carsharing}/{action = Index}");*/

/*app.MapControllerRoute(
    name: "LoginIn",
    pattern: "{controller=Home}/{action=Login}/{username}/{password}");

app.MapControllerRoute(
    name: "LoginIn",
    pattern: "{controller=Home}/{action=Login}");*/


/*app.UseHttpsRedirection();
app.UseStaticFiles();*/


/*app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();*/


app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");

app.Run();
