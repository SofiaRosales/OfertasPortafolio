using SolucionOfertas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginOfertas3.Controllers
{
    public class ConsumidorController : Controller
    {
        EntitiesOfertas entityOferta = new EntitiesOfertas();
        // GET: Consumidor :
        public ActionResult Index()
        {
            return View(entityOferta.PRODUCTO.ToList());
        }
        public ActionResult Detalle_oferta()
        {
            return View();
        }
        public ActionResult Puntos()
        {
            return View();
        }
    }
}