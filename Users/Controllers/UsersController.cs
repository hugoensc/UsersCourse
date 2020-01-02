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
        //[Route("[controller]/[action]/{data}")]
        //[HttpGet("[controller]/[action]/{data:int}")]
        //[HttpGet("[controller]/[action]/{data:double}")]
        //public IActionResult Index(String data, int age)
        public IActionResult Index(double data)
        {
            //var url = Url.Action("Method", "Hugo");
            var url = Url.Action("Method", "Users");
            //String datos = data + " " +  age;
            //ViewData["id"] = data + " " + age;
            //ViewData["id"] = data;
            //return View("Index", data);
            //return Content(url);
            return Redirect(url);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Method()
        {
            return View();
        }
    }
}