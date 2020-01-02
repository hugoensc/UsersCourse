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
            //var url = Url.Action("Method", "Users", new {  age = 28, name = "Hugo"});
            //String datos = data + " " +  age;
            //ViewData["id"] = data + " " + age;
            //ViewData["id"] = data;
            //return View("Index", data);
            //return Content(url);
            var url = Url.RouteUrl("Hugo", new { age = 28, name = "Enrique" });
            return Redirect(url);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet("[controller]/[action]",  Name = "Hugo")]
        //public IActionResult Method(int age, String name)
        //{
        //    var data = $"Nombre {name} : Edad {age}";
        //    return View("Index", data);
        //}


        /*----------Segunda Parte----------*/
        [HttpGet("[controller]/[action]", Name = "Hugo")]
        public IActionResult Method(int code)
        {
            var data = $"Código de estado {code}";
            return View("Index", data);
        }
    }
}