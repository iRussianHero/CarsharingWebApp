using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace СarsharingWebApp.Controllers
{
    public class CarsharingController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
