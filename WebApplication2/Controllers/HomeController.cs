using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
         public IActionResult Index()
         {
             return View();
         }

        [HttpPost]
        public IActionResult Index(Regulars expr)
        {
            if (ModelState.IsValid)
            {
                OrderData.Items.Add(new Order()
                {
                    Name = expr.Name,
                    Count = expr.Count,
                    Price = expr.Price,
                });
                return RedirectToAction("Index");
            }
            return View(expr);
        }


        //=================================
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

        public IActionResult Error()
        {
            return View();
        }

    }
  

}
