using System;
using System.Linq;
using System.Web.Mvc;
using EXA_U3_Arce.Models;

namespace EXA_U3_Arce.Controllers
{
    public class LoginController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            // Si ya está logueado, redirige según el rol
            if (Session["Usuario"] is EXA_U3_Arce.Models.Usuario usuario)
            {
                if (usuario.Rol == "admin")
                    return RedirectToAction("Admin", "Login");
                else
                    return RedirectToAction("User", "Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Usuarios.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    Session["Usuario"] = user;
                    if (user.Rol == "admin")
                        return RedirectToAction("Admin", "Login");
                    else
                        return RedirectToAction("User", "Login");
                }
            }
            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }

        public ActionResult Admin()
        {
            var usuario = Session["Usuario"] as EXA_U3_Arce.Models.Usuario;
            if (usuario == null || usuario.Rol != "admin")
                return RedirectToAction("Index", "Login");
            return View();
        }

        public ActionResult User()
        {
            var usuario = Session["Usuario"] as EXA_U3_Arce.Models.Usuario;
            if (usuario == null || usuario.Rol != "user")
                return RedirectToAction("Index", "Login");
            return View();
        }

        public ActionResult TestConexion()
        {
            string mensaje;
            try
            {
                using (var db = new Models.AppDbContext())
                {
                    var count = db.Usuarios.Count();
                    mensaje = $"Conexión exitosa. Usuarios en BD: {count}";
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error de conexión: {ex.Message}";
            }
            ViewBag.Mensaje = mensaje;
            return View();
        }
    }
}
