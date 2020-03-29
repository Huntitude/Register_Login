using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Register_Login.Models;

namespace Register_Login.Controllers
{
    public class HomeController : Controller
    {
        // Index / Home page 
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        // GET Route /result => Index 
        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }

        // POST Route for Sign Up Form
        [HttpPost("SignUp")]
        public IActionResult SignUp(NewUser newUser)
        {
            if(ModelState.IsValid)
            {
                return View("Result", newUser);
            }
            else
            {
                return View("Index");
            }
           
        }

        // POST Route for LoginForm
        [HttpPost("Login")]
        public IActionResult Login(LoginUser loginUser)
        {
            if(ModelState.IsValid)
            {
                return Redirect("Result");
            }
            else 
            {
                return View("Index");
            }
        }
    }

}
