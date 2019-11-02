using DigiSalud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiSalud.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Encuesta()
        {
            return View();
        }
        [HttpPost]
        public void Encuesta(Encuesta encuesta)
        {
            Session["Encuesta"] = encuesta;
        }

    }
}