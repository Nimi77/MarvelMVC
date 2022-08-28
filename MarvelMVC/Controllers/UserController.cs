using MarvelMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelMVC.Controllers
{
    public class UserController : Controller
    {
        public static List<UserData> allUsers = new List<UserData>();
        public IActionResult Index()
        {
            return View(allUsers);
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(UserData user)
        {
            if (ModelState.IsValid)
            {
                allUsers.Add(user);
                return RedirectToAction("AddUser");
            }
            return View();
        }

    }
}
