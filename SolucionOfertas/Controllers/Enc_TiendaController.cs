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
        //Producto---------------------------------------------------------------------------------------------

        [HttpGet]
        public ActionResult Adm_producto()
        {
            
            return View(entityOferta.PRODUCTO.ToList());
        }
        //Add---------------------------------------------------------------------------------------------
        [HttpPost]
        public ActionResult Add_producto(string nombre_prod,decimal precio_prod,string descripcion_prod,decimal categoriaProducto,decimal subCategoriaProducto, string foto_prod)
        {
           
            entityOferta.ADD_PRODUCTO_PROCEDURE(nombre_prod, categoriaProducto, descripcion_prod, precio_prod, foto_prod);
            return RedirectToAction("Adm_producto");
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
        
        //UP---------------------------------------------------------------------------------------------
        [HttpPost]
        public ActionResult Up_producto(decimal precio_prod, string nombre_prod, string descripcion_prod, string foto_prod, decimal id_producto, decimal categoriaProducto)
        {

            entityOferta.UP_PRODUCTO_PROCEDURE(precio_prod, nombre_prod, categoriaProducto, descripcion_prod, foto_prod, id_producto);
            return RedirectToAction("Adm_producto");
        }
        [HttpGet]
        public ActionResult UP_producto(decimal id_producto)
        {
            var getCategoriasList = entityOferta.CATEGORIA.ToList();
            SelectList list = new SelectList(getCategoriasList, "ID", "NOMBRE");
            ViewBag.categoriaListName = list;

            return View(entityOferta.PRODUCTO.Where(x => x.ID == id_producto).First());
        }

        //Oferta---------------------------------------------------------------------------------------------
        public ActionResult Adm_oferta()
        {
            return View(entityOferta.OFERTA.ToList());
        }
        //Add---------------------------------------------------------------------------------------------
        [HttpPost]
        public ActionResult Add_oferta(decimal id_producto, decimal por_descuento, decimal stock, decimal pre_descuento,string estado)
        {
            entityOferta.ADD_OFERTA_PROCEDURE(id_producto, estado,por_descuento,stock);
            return RedirectToAction("Adm_oferta");
        }
        public ActionResult ADD_oferta()
        {

            var getCategoriasList = entityOferta.CATEGORIA.ToList();
            SelectList list = new SelectList(getCategoriasList, "ID", "NOMBRE");
            ViewBag.categoriaListName = list;

            var getProductosList = entityOferta.PRODUCTO.ToList();
            SelectList list2 = new SelectList(getProductosList, "ID", "NOMBRE");
            ViewBag.ProductoListName = list2;

            return View();
        }

        

        public ActionResult UP_oferta()
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