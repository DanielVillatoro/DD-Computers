using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputersDD.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult LoginUser(string username, string pass,string sede)
        //{
        //    LoginModel modeloLogin = new LoginModel();
        //    DataTable dtResultado = modeloLogin.ValidacionLogin(username, pass);
        //    if (dtResultado.Rows.Count > 0)
        //    {
        //        HttpContext.Session.SetString("Sede", dtResultado.Rows[0]["tipo"].ToString());
        //        return RedirectToAction("Index", "Inicio");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Login");
        //    }
        //}
    }
}