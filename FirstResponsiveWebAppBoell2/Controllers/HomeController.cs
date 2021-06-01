using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppBoell2.Models;

//in charge of flow of data between view and model
namespace FirstResponsiveWebAppBoell2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // displays blank URL to the user
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            ViewBag.FV2 = 0;
            return View(); //returns view
        }

        [HttpPost] //processes data submitted by user
        public IActionResult Index(DetermineAgeModel model)
        {
            if (ModelState.IsValid) //if input is valid
            {
                ViewBag.FV = model.AgeThisYear(); //displays result of first method
                ViewBag.FV2 = model.AgeThisYear2(); //displays result of second method
            }
            else //if input is not valid
            {
                ViewBag.FV = 0; //displays if invalid input
                ViewBag.FV2 = 0;
            }
            return View(model); //returns/displays view with results and user input
        }

    }
}