using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputersDD.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Categoria()
        {
            return View();
        }
        public IActionResult Producto()
        {
            return View();
        }
        public IActionResult Inventario()
        {
            return View();
        }
        public IActionResult Factura()
        {
            return View();
        }
    }
}