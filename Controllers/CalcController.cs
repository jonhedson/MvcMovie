using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Soma(float num1, float num2)
        {
            //            soma = num1 + num2;

            // ViewBag
            ViewBag.soma = num1 + num2 ;

            // ViewData
            ViewData["soma"] = num1 + num2;


            return View();
        }

        public ActionResult Sub(float num1, float num2)
        {
            //float sub = num1 + num2;
            // ViewData
            ViewData["sub"] = num1 - num2;

            return View();
        }

        //public float Sub(float num1, float num2)
        //{
        //    float sub = num1 + num2;

        //    return sub;
        //}

        public ActionResult Div(float num1, float num2)
        {
            //float div = num1 / num2;

            ViewData["div"] = num1 / num2;

            return View();
        }

        public ActionResult Mul(float num1, float num2)
        {
            // float mult = num1 + num2;


            ViewData["mul"] = num1 * num2;



            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}