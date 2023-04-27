using Microsoft.AspNetCore.Mvc;
using OrderApiApp.Service.ClientService;
using System.Text.Json;
using System;
using СarsharingWebApp.Model.Entity;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using СarsharingWebApp.Service.CarCarOwner;

namespace СarsharingWebApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login (string username, string password,  string returnUrl)
        {

            var carOwners = async (IDaoCarOwner daoCarOwner) =>
            await daoCarOwner.GetAllAsync();



            if (userCheck == true)
            {

            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
