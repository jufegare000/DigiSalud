using DigiSalud.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiSalud.Controllers
{
    public class DetalleController : Controller
    {
        // GET: Detalle
        public ActionResult Detalle()
        {
            if (Session["Encuesta"] != null)
            {
                encuesta cv = (encuesta)Session["Encuesta"];
                return View(cv);
            }
            else
            {
                return View();
            }
        }
    }
}