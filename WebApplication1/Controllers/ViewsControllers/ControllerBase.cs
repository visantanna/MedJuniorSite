using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public abstract class ControllerBase : Controller
    {
        // GET: ControllerBase
        public abstract ActionResult Index();
        public ActionResult SignIn()
        {
            return View("SignInPage");
        }
    }
}