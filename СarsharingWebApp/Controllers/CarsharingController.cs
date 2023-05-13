using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Service.CarCarOwner;

namespace СarsharingWebApp.Controllers
{
    //[Authorize ("Administrator")]
    //[ValidateAntiForgeryToken]
    //[AllowAnonymous]
    //[ValidateAntiForgeryToken]

    public class CarsharingController : Controller
    {
        IDaoCar daoCar;
        IDaoCarBrand daoCarBrand;
        IDaoCarModel daoCarModel;

        public CarsharingController(IDaoCar daoCar, IDaoCarBrand daoCarBrand, IDaoCarModel daoCarModel)
        {
            this.daoCar = daoCar;
            this.daoCarBrand = daoCarBrand;
            this.daoCarModel = daoCarModel;
        }


        [HttpGet]
        [Route("carsharing")]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View();
        }

/*        public async Task<IActionResult> CarSearchAsync()
        {
            ViewBag.Brands = await daoCarBrand.GetAllAsync();
            ViewBag.Models = await daoCarModel.GetAllAsync();
            return View();
        }*/

        public async Task<IActionResult> CarSearchAsync(string? carNumber, int? carBrand, int? carModel)
        {
            ViewBag.Brands = await daoCarBrand.GetAllAsync();
            ViewBag.Models = await daoCarModel.GetAllAsync();
            ViewBag.Car = await daoCar.CarSearchAsync(carNumber, carBrand, carModel);
            ViewBag.Cars = await daoCar.GetAllAsync();
            return View();
        }

        public IActionResult CarAdd()
        {
            return View();
        }

        public IActionResult CarServ()
        {
            return View();
        }

        public IActionResult Other()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToRoute(new { controller = "Home", action = "Login" });
        }
    }
}
