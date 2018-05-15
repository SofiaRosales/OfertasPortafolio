using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionOfertas.Controllers
{
    public class Enc_TiendaController : Controller
    {
        // GET: Enc_Tienda
        public ActionResult Index()
        {
            return View();
        }


        // Rutas
        public ActionResult Adm_producto()
        {
            return View();
        }
        public ActionResult ADD_producto()
        {
            return View();
        }
    }
}