using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string userId)
        {
            ViewBag.userId = userId;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (String.IsNullOrEmpty(user.Username))
            {
                ViewBag.email = user.Email;
                ViewBag.error = "Bad username. Do better.";
                return View();
            }
            else if (user.Username.Length < 5  && user.Username.Length > 15)
            {
                ViewBag.userName = user.Username;
                ViewBag.email = user.Email;
                ViewBag.error = "Bad username. Do better.</br>Usernames need to be between 5 and 15 characters.";
                return View();
            }
            else if (user.Password.Length < 5)
            {
                ViewBag.userName = user.Username;
                ViewBag.email = user.Email;
                ViewBag.error = "Bad password. Do better.</br>Passwords need to be greater than 5 characters";
                return View();
            }
            else if (user.Password == verify && !String.IsNullOrEmpty(user.Username))
            {
                string url = String.Format("/User/Index?userId={0}", user.UserId);
                return Redirect(url);
            }
            else
            {
                ViewBag.userName = user.Username;
                ViewBag.email = user.Email;
                ViewBag.error = "Bad password(s). Do better.";
                return View();
            }
        }
    }
}
