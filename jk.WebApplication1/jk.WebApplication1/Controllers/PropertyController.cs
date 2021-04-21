using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jk.WebApplication1.Controllers
{
    public class PropertyController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //url - Property/AllProperty
        public ViewResult getAllProperty()
        {
            //return "All Property";
            return View();
        }
        public string getProperty(int id)
        {
            return $"Property with id = {id}";
        }
        public string SearchProperty(string propertyName, string propertyTag)
        {
            return $"Property with name = {propertyName} & Tag {propertyTag}";
        }
    }
}
