using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();
            return View("SignIn");
        }
    }
}