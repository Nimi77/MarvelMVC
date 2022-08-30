﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelMVC.Controllers
{
    public class CalculateController : Controller
    {
        [HttpGet]
        public IActionResult SimpleInterest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SimpleInterest(string amount, string months )
        {
            if(String.IsNullOrEmpty(amount) || String.IsNullOrEmpty(months))
            {
                ViewBag.ErrorMessage = "Amount or months must not be null";
                return View();
            }

            var amountInt = int.Parse(amount);
            var monthsInt = int.Parse(months);

            var interest = (amountInt * 2.4 * monthsInt) / 100;

            ViewBag.Amount = amount;
            ViewBag.Months = months;
            ViewBag.Interest = interest;
            return View();
        }
    }
}
