using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolucionOfertas.Models;
using Microsoft.AspNet.Identity;

namespace SolucionOfertas.Controllers
{
    public class RegistroController : Controller
    {

        private ApplicationUserManager b;

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
                PasswordHasher a = new PasswordHasher();
                

                datos.PERSONA_PROCEDURE(correo,rut,a.HashPassword(pass));

                //ManageController
                //UserManager.add
                //ApplicationUserManager b;
                string t= datos.PERSONA.Where(x => x.RUT == rut).Select(x => x.ID).First().ToString();
                b.AddPassword(t, pass);

            }
            return RedirectToAction("Index");
        }
    }
}