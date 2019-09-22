using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyMarket.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult ArrozGraos()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }
    }
}