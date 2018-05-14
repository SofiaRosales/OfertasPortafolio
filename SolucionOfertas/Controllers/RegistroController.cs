using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolucionOfertas.Models;

namespace SolucionOfertas.Controllers
{
    public class RegistroController : Controller
    {
        private EntitiesOfertas datos = new EntitiesOfertas();


        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }
        
       [HttpPost]
        public ActionResult Registro(string rut,string correo, string pass)
        {
            if (ModelState.IsValid)
            {
                datos.PERSONA_PROCEDURE(correo,rut,pass);

            }
            return RedirectToAction("Index");
        }
    }
}