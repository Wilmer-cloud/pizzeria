using Pizzeria.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pizzeria.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto = new ProductoModel();
            producto.Id = 1;
            producto.Id = 2;
            producto.Descripcion = "Pizza de 6 Quesos";
            producto.Descripcion = "Pizza de jamo";

            return View(producto);
        }
    }
}