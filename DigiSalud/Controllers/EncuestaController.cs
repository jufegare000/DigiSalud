using DigiSalud.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiSalud.Controllers
{
    
    public class EncuestaController : Controller
    {
        private digisaludEntities db = new digisaludEntities();
        // GET: Encuesta
        public ActionResult Encuesta()
        {
            return View();
        }
        [HttpPost]
        public void Encuesta(encuesta encuesta)
        {
            encuesta.fechaDiligen = DateTime.Now;
            db.encuesta.Add(encuesta);
            db.SaveChanges();
            Session["Encuesta"] = encuesta;
        }

    }
}