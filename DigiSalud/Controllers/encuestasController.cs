using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DigiSalud.Models.Entities;

namespace DigiSalud.Controllers
{
    public class encuestasController : Controller
    {
        private digisaludEntities db = new digisaludEntities();

        // GET: encuestas
        public ActionResult Index()
        {
            return View(db.encuesta.ToList());
        }

        // GET: encuestas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encuesta encuesta = db.encuesta.Find(id);
            if (encuesta == null)
            {
                return HttpNotFound();
            }
            return View(encuesta);
        }

        // GET: encuestas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: encuestas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FormatoEnPapel,PartiCipa,Edad,Sexo,CiudadOrigen,CiudadActual,Retraso,SemestresAtrasados,Dificultades,ProblemasEcon,ProblemasSalud,ProblemasSaludMen,ProblemasFamil,CalamidadDomes,Estudio,Deporte,Culturales,Entretenimiento,Trabajo,Religiosas,Otras,CondicionMedica,CondicionMedicaDet,MadreEnfMen,PadreEnfMen,HermanoEnfMen,ParejaEnfMen,AbueloEnfMen,PrimoEnfMen,SobrinoEnfMen,HijoEnfMen,TioEnfMen,MadreDep,PadreDep,HermanoDep,ParejaDep,AbueloDep,PrimoDep,SobrinoDep,HijoEnfDep,TioEnfDep,MadreAns,PadreAns,HermanoAns,ParejaAns,AbueloAns,PrimoAns,SobrinoAns,HijoEnfAns,TioEnfAns,MadreEsq,PadreEsq,HermanoEsq,ParejaEsq,AbueloEsq,PrimoEsq,SobrinoEsq,HijoEnfEsq,TioEnfEsq,MadreLicDrog,PadreLicDrog,HermanoLicDrog,ParejaLicDrog,AbueloLicDrog,PrimoLicDrog,SobrinoLicDrog,HijoEnfLicDrog,TioEnfLicDrog,MadreOtra,PadreOtra,HermanoOtra,ParejaOtra,AbueloOtra,PrimoOtra,SobrinoOtra,HijoEnfOtra,TioEnfOtra,MadreTiempoD,PadreTiempoD,HermanoTiempoD,ParejaTiempoD,AbueloTiempoD,PrimoTiempoD,SobrinoTiempoD,HijoEnfTiempoD,TioEnfTiempoD,MadreTrat,PadreTrat,HermanoTrat,ParejaTrat,AbueloTrat,PrimoTrat,SobrinoTrat,HijoTrat,TioEnfTrat,Alcohol,Nicotina,Cannabis,Cocaina,Sedantes,Opiaceos,Otros,LoUsa,SmarthPhone,Tablet,ComputadorFamiliar,ComputadorPropio,PortatilFamiliar,PortatilPropio,TV,Consola,SalaHogar,Habitacion,Universidad,TrabajoI,CasaAmigo,CasaFamiliar,OtrosPublicos,OtraVia,InternetCasa,InternetMobil,InternetTrabajo,InternetUniversidad,InternetPublico,fechaDiligen")] encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                db.encuesta.Add(encuesta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encuesta);
        }

        // GET: encuestas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encuesta encuesta = db.encuesta.Find(id);
            if (encuesta == null)
            {
                return HttpNotFound();
            }
            return View(encuesta);
        }

        // POST: encuestas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FormatoEnPapel,PartiCipa,Edad,Sexo,CiudadOrigen,CiudadActual,Retraso,SemestresAtrasados,Dificultades,ProblemasEcon,ProblemasSalud,ProblemasSaludMen,ProblemasFamil,CalamidadDomes,Estudio,Deporte,Culturales,Entretenimiento,Trabajo,Religiosas,Otras,CondicionMedica,CondicionMedicaDet,MadreEnfMen,PadreEnfMen,HermanoEnfMen,ParejaEnfMen,AbueloEnfMen,PrimoEnfMen,SobrinoEnfMen,HijoEnfMen,TioEnfMen,MadreDep,PadreDep,HermanoDep,ParejaDep,AbueloDep,PrimoDep,SobrinoDep,HijoEnfDep,TioEnfDep,MadreAns,PadreAns,HermanoAns,ParejaAns,AbueloAns,PrimoAns,SobrinoAns,HijoEnfAns,TioEnfAns,MadreEsq,PadreEsq,HermanoEsq,ParejaEsq,AbueloEsq,PrimoEsq,SobrinoEsq,HijoEnfEsq,TioEnfEsq,MadreLicDrog,PadreLicDrog,HermanoLicDrog,ParejaLicDrog,AbueloLicDrog,PrimoLicDrog,SobrinoLicDrog,HijoEnfLicDrog,TioEnfLicDrog,MadreOtra,PadreOtra,HermanoOtra,ParejaOtra,AbueloOtra,PrimoOtra,SobrinoOtra,HijoEnfOtra,TioEnfOtra,MadreTiempoD,PadreTiempoD,HermanoTiempoD,ParejaTiempoD,AbueloTiempoD,PrimoTiempoD,SobrinoTiempoD,HijoEnfTiempoD,TioEnfTiempoD,MadreTrat,PadreTrat,HermanoTrat,ParejaTrat,AbueloTrat,PrimoTrat,SobrinoTrat,HijoTrat,TioEnfTrat,Alcohol,Nicotina,Cannabis,Cocaina,Sedantes,Opiaceos,Otros,LoUsa,SmarthPhone,Tablet,ComputadorFamiliar,ComputadorPropio,PortatilFamiliar,PortatilPropio,TV,Consola,SalaHogar,Habitacion,Universidad,TrabajoI,CasaAmigo,CasaFamiliar,OtrosPublicos,OtraVia,InternetCasa,InternetMobil,InternetTrabajo,InternetUniversidad,InternetPublico,fechaDiligen")] encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encuesta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encuesta);
        }

        // GET: encuestas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encuesta encuesta = db.encuesta.Find(id);
            if (encuesta == null)
            {
                return HttpNotFound();
            }
            return View(encuesta);
        }

        // POST: encuestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            encuesta encuesta = db.encuesta.Find(id);
            db.encuesta.Remove(encuesta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
