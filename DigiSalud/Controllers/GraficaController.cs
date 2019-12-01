using DigiSalud.Models;
using DigiSalud.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiSalud.Controllers
{
    public class GraficaController : Controller
    {
        // GET: Grafica
        private digisaludEntities db = new digisaludEntities();
        public ActionResult Grafica()
        {
            Grafica graf = new Grafica();
            graf.g10_14 = db.encuesta.Where(x => (x.Edad >= 10 && x.Edad <=14)).Count();
            graf.g15_19 = db.encuesta.Where(x => (x.Edad >= 15 && x.Edad <= 19)).Count();
            graf.g20_24 = db.encuesta.Where(x => (x.Edad >= 20 && x.Edad <= 24)).Count();
            graf.g25_29 = db.encuesta.Where(x => (x.Edad >= 25 && x.Edad <= 29)).Count();
            graf.g30_100 = db.encuesta.Where(x => (x.Edad >= 30 && x.Edad <= 100)).Count();
            return View(graf);
        }
    }
}
