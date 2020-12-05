using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputersDD.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Limon()
        {
            HttpContext.Session.SetString("sede", "1");
            return RedirectToAction("Index", "Shop");
        }
        public ActionResult Cartago()
        {
            HttpContext.Session.SetString("sede", "2");
            return RedirectToAction("Index", "Shop");
        }
    }
}