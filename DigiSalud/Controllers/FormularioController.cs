using DigiSalud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiSalud.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Formulario()
        {
            if(Session["Cliente"] != null)
            {
                Cliente cv = (Cliente)Session["Cliente"];
                return View(cv);
            }
            else
            {
                return View();
            }
        }
    }
}