using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jk.WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            //var obj = new { Id = 1, Name = "dotNET1" };
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }

        public ViewResult GetAllProperty()
        {
            return View();
        }

    }
}
