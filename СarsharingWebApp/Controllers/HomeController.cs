﻿using Microsoft.AspNetCore.Mvc;
using OrderApiApp.Service.ClientService;
using System.Text.Json;
using System;
using СarsharingWebApp.Model.Entity;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using СarsharingWebApp.Service.CarCarOwner;
using СarsharingWebApp.Model;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace СarsharingWebApp.Controllers
{
    public class HomeController : Controller
    {
        IDaoCarOwner daoCarOwner;

        public HomeController(IDaoCarOwner daoCarOwner)
        {
            this.daoCarOwner = daoCarOwner;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password, string returnUrl)
        {

            var result = await daoCarOwner.GetAllAsync();

            foreach (var item in result)
            {
                if (item.Login == username && item.Password == password)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, username)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, "Login");

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return Redirect(returnUrl == null ? "/Carsharing" : returnUrl);
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
