﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginOfertas3.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }


        // GET: Rutas Empresa
        public ActionResult Adm_empresas()
        {
            return View();
        }
        public ActionResult ADD_empresa()
        {
            return View();
        }
        public ActionResult UP_empresa()
        {
            return View();
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
            return View();
        }
        public ActionResult ADD_encargado()
        {
            return View();
        }
    }
}