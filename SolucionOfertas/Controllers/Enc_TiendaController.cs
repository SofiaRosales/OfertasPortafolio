using SolucionOfertas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolucionOfertas.Controllers
{
    public class Enc_TiendaController : Controller
    {
        EntitiesOfertas entityOferta = new EntitiesOfertas();


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
        public ActionResult ADD_oferta()
        {

            var getCategoriasList = entityOferta.CATEGORIA.ToList();
            SelectList list = new SelectList(getCategoriasList, "ID", "NOMBRE");
            ViewBag.categoriaListName = list;

            var getSubCategoriasList = entityOferta.SUBCATE.ToList();
            SelectList list2 = new SelectList(getSubCategoriasList, "ID", "NOMBRE");
            ViewBag.SubCategoriaListName = list2;

            return View();
        }
        public ActionResult ADD_producto()
        {
            

            var getCategoriasList = entityOferta.CATEGORIA.ToList();
            SelectList list = new SelectList(getCategoriasList, "ID", "NOMBRE");
            ViewBag.categoriaListName = list;

            var getSubCategoriasList = entityOferta.SUBCATE.ToList();
            SelectList list2 = new SelectList(getSubCategoriasList, "ID", "NOMBRE");
            ViewBag.SubCategoriaListName = list2;

            return View();
        }
        

        // Cargar Select de ADD_producto
        //public JsonResult getcategorias()
        //{
        //    var query = from c in db.Categorie
        //                select new { c.CategoryID, c.CategoryName };

        //    return Json(query, JsonRequestBehavior.AllowGet);

        //}
        //public JsonResult getsuppliers()
        //{
        //    var query = from s in db.Suppliers
        //                select new { s.SupplierID, s.CompanyName };

        //    return Json(query, JsonRequestBehavior.AllowGet);

        //}


    }
}