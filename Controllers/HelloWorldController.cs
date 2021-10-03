using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            ViewData["Message"] = "Hello " + name;
            //ViewData["NumTimes"] = numTimes;
            ViewBag.NumTimes = numTimes;
            ViewBag.DataAcesso = DateTime.Now;

            return View();
        }
    }
}