﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputersDD.Controllers
{
    public class CorporativoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }  
        public IActionResult Inventario()
        {
            return View();
        }

        public IActionResult FacturadoSucursal()
        {
            return View();
        }
        public IActionResult FacturadoConsolidado()
        {
            return View();
        }
    }
}