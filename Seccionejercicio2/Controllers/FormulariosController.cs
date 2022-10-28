using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seccionejercicio2.Models;
using Seccionejercicio2.Models.Formulario;

namespace Seccionejercicio2.Controllers
{
    public class FormulariosController : Controller
    {
        // GET: Formularios
        public ActionResult Index()
        {
            return View();
        }
    }
}