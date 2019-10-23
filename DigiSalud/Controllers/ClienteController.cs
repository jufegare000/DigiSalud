using DigiSalud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiSalud.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ingresar()
        {
          
            return View(new Cliente() { PrimerNombre="" });
        }

        [HttpPost]
        public void Regresar(Cliente cliente)
        {
            Session["Cliente"] = cliente;
            //return View();
        }
    }
}