﻿using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza> {

                new Pizza("Margherita", "Pomodoro, Mozzarella", "/img/pizza-margherita.jpg", 5),
                new Pizza("Diavola", "Pomodoro, Mozzarella, salame piccante", "/img/pizza-diavola.jpg", 7),
                new Pizza("Marinara", "Pomodoro", "/img/pizza-margherita.jpg", 4),
                new Pizza("Salsiccia", "Pomodoro, Mozzarella, salsiccia", "/img/pizza-margherita.jpg", 7),

            };

            return View(pizze);
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