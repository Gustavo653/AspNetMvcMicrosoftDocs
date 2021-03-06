using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AspNetMvcMicrosoftDocs.Controllers
{
    public class HelloWorldController : Controller
    {


        //https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0


        // 
        // GET: /HelloWorld/
        //https://localhost:5001/HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        //// 
        //// GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        ///
        ///https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        ///
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        ///
        //https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
