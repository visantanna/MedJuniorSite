using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models;
using System.Diagnostics;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers.ModelControllers
{
    public class UsuariosController : Controller
    {
        private UsuarioDBContext db = new UsuarioDBContext();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            
            ViewBag.anoDeIngresso = AnoDeIngresso.GetListAnoDeIngresso();
            return View();
            
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,email,senha,confirmSenha,faculdade,nomeCompleto,anoDeIngresso")] UserCreateModelView usuarioModelView)
        {
            ViewBag.anoDeIngresso = AnoDeIngresso.GetListAnoDeIngresso();
            Usuario usuario = null;
            if (ModelState.IsValid)
            {
                usuario = new Usuario
                {
                    email         = usuarioModelView.email,
                    anoDeIngresso = Int32.Parse(usuarioModelView.anoDeIngresso),
                    faculdade     = usuarioModelView.faculdade.ToString(),
                    senha         = usuarioModelView.senha,
                    nomeCompleto  = usuarioModelView.nomeCompleto
                };
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarioModelView);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,email,senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [HttpPost]
        public JsonResult EmailExists(String email) {
            if (email != null)
            {
                //se não existe ele retorna true e permite a criação
               return Json(!db.Usuarios.Any(user => user.email == email), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
