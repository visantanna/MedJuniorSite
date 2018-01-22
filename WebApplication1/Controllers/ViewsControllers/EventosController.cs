using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers.ViewsControllers
{
    public class EventosController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View("Eventos");
        }
    }
}