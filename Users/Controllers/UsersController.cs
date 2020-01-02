using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Users.Controllers
{
    //[Route("/Users")]
    //[Route("[controller]/[action]")]
    //[Route("[controller]")]
    public class UsersController : Controller
    {
        //[HttpGet]
        //public IActionResult Index(int id)
        //public IActionResult Index(String data)
        //[Route("/Userss/Hugo")]
        //[Route("/Userss/Enrique/{data}")]
        [Route("[controller]/[action]/{data}")]
        public IActionResult Index(String data, int age)
        {
            String datos = data + " " + age;
            //ViewData["id"] = data + " " + age;
            //ViewData["id"] = data;
            return View("Index", datos);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}