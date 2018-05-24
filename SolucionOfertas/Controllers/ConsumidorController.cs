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

        public ActionResult add_descuento(decimal porcentaje)
        {
            entityOferta.ADD_DESCUENTO_PROCEDURE(porcentaje);
            return RedirectToAction("Cupon");
        }

        public ActionResult add_cupon(decimal descuento_id, decimal perfil_persona_id, decimal descuento)
        {
            entityOferta.ADD_CUPON_PROCEDURE(descuento_id, perfil_persona_id, descuento);
            return RedirectToAction("Puntos");
        }

        public ActionResult Puntos()
        {
            //como mostrar los puntos de la sesion activa?
            return View();
        }
        public ActionResult Cupon()
        {
            return View();
        }
    }
}