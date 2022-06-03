using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeproductos = productosBL.ObtenerProductos();
            return View(listadeproductos);
        }
    }
}