using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;
using Tarea123.Models;

namespace Tarea123.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


      //  [HttpPost]
        public ActionResult ShowTable()
        {
            return View();
        }

       // [HttpPost]
        public ActionResult EQN()
        {
            return View();
        }

        public ActionResult Zsing()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EQNC(double a, Double b, double c)
        {
            ViewBag.X1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            ViewBag.X2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            return View();
        }
       [HttpPost]
        public ActionResult SaintSeiya(string Mes, string Dia)
        {
            if ((Mes == "Abril" || Mes == "Junio" || Mes == "Septiembre" || Mes == "Noviembre") && (int.Parse(Dia) > 30))
            {
                return Content(string.Format("{0} no tine {1} dias", Mes, Dia));
            }
            else if (Mes == "Febrero" && int.Parse(Dia) > 29)
            {
                return Content(string.Format("{0} no tine {1} dias", Mes, Dia));
            }
            else
            {
                ViewBag.YourZsing = ZodiacLogic.YourZsing(Mes, int.Parse(Dia));
                return View("SaintSeiya");
            }

        }
    }
}