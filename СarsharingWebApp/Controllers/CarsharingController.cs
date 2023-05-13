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

        public CarsharingController(IDaoCar daoCar)
        {
            this.daoCar = daoCar;
        }


        [HttpGet]
        [Route("carsharing")]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> CarSearchAsync()
        {
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
