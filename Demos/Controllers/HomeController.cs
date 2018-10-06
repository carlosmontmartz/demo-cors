using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demos.Models;
using System.Net;
using System.IO;

namespace Demos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            // var request = (HttpWebRequest)WebRequest.Create("http://localhost:50617/location/cities");
            // var response = (HttpWebResponse)request.GetResponse();
            // string responseString;
            // using (var stream = response.GetResponseStream())
            // {
            //     using (var reader = new StreamReader(stream))
            //     {
            //         responseString = reader.ReadToEnd();
            //     }
            // }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
