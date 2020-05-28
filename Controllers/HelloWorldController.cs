using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Inde()
        {

            return "Esse é a minha ação padrão";
        }

        public string Welcome(string name, int numTimes)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

            //($"Hello {name}, NumTimes is: {numTimes}");
        }

        public float Soma(float num1, float num2)
        {
            float soma = num1 + num2;

            return soma;

            //($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}