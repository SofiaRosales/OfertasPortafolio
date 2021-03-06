﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolucionOfertas.Models;
using Microsoft.AspNet.Identity;

namespace LoginOfertas3.Controllers
{
    public class AdministradorController : Controller
    {
        private EntitiesOfertas datos = new EntitiesOfertas();
        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }


        // GET: Rutas Empresa
        public ActionResult Adm_empresas()
        {
            return View(datos.EMPRESA.ToList());
        }


        [HttpGet]
        public ActionResult Add_empresas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ADD_empresas(string nombre,string rut)
        {
            datos.ADD_EMPRESA_PROCEDURE(nombre, rut);
            return RedirectToAction("Adm_empresas");
        }

        public ActionResult Adm_producto(string nombre_prod, decimal precio_prod, string descripcion_prod, decimal categoriaProducto, string subCategoriaProducto)
        {
            //datos.ADD_EMPRESA_PROCEDURE(nombre_prod, 1, 0, descripcion_prod, precio_prod, "");
            return View();
        }
        public ActionResult UP_empresa(decimal id_empresa)
        {
            return View(datos.EMPRESA.Where(x => x.ID == id_empresa).First());
        }
        public ActionResult Adm_perfil()
        {
            return View();
        }

        // GET: Rutas Administrar Encargados de tienda
        public ActionResult Adm_encargado()
        {
            return View();
        }
        public ActionResult UP_encargado()
        {
            if (ModelState.IsValid)
            {

                //datos.ENCARGADO_PROCEDURE(nombre, apellidos, rut, region, provincia, comuna, direccion);

            }
            return View();
        }
        

        public ActionResult ADD_encargado(string nombre, string apellidos, string rut, REGION region, PROVINCIA provincia, COMUNA comuna, string direccion)
        {
            //datos.PERSONA_PROCEDURE();
            return View();
        }
    }
}