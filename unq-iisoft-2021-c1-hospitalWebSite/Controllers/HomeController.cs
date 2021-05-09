using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Hospital;
using unq_iisoft_2021_c1_hospitalWebSite.Models;

namespace unq_iisoft_2021_c1_hospitalWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SanatorioContext db;

        public HomeController(ILogger<HomeController> logger,SanatorioContext contexto)
        {
            _logger = logger;
              this.db = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    public IActionResult Prestaciones() {

        return View();
    }
    public IActionResult Registro() {

        return View();
    }
    public IActionResult Staff() {

        return View();
    }
     public IActionResult Historia() {

        return View();
    }
     public IActionResult Autoridades() {

        return View();
    }

    public IActionResult RegistroResult(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Logueo()
        {
            return View();
        }
       
          [HttpPost]
        public IActionResult Login(string mail, string contraseña){
            Usuario usuarioLogin = db.Usuario.FirstOrDefault(usuario => usuario.Mail == mail);
            if(usuarioLogin != null){
                if(usuarioLogin.Contraseña == contraseña){
                     
                    AgregarUsuarioASession(usuarioLogin);
                    return View("LogueoResult");
                }else{
                    ViewBag.ErrorEnLogin = true;
                    return View("Logueo");
                }
            }else{
                ViewBag.ErrorEnLogin = true;
                return View("Logueo");
            }
        }

        public IActionResult MiPerfil(){
            Usuario usuarioLogeado = HttpContext.Session.Get<Usuario>("UsuarioLogueado");
            Usuario user = db.Usuario.FirstOrDefault(u => u.Mail == usuarioLogeado.Mail);
            ViewBag.Nombre = user.Nombre;
            ViewBag.Apellido = user.Apellido;
            ViewBag.Mail = user.Mail;
            ViewBag.ObraSocial = user.ObraSocial;
            ViewBag.Contraseña = user.Contraseña;
            return View();
        }
        
        public IActionResult IrAPerfil(){
            return RedirectToAction("MiPerfil","Home") ;
        }

          public IActionResult LogueoResult(){
            return View();
        }


         private JsonResult AgregarUsuarioASession(Usuario usuarioLogin) {
           HttpContext.Session.Set<Usuario>("UsuarioLogueado", usuarioLogin);
            return Json(usuarioLogin);
        }



        [HttpPost] 
         public IActionResult RegistrarUsuario(string mail, string nombre, string apellido, string obraSocial, string contraseña)   {

             Usuario user = db.Usuario.FirstOrDefault(u => u.Mail == mail);
              if(user != null){
                ViewBag.MailRegistrado = true;
                return View("RegistroResult");
            }

             Usuario nuevoUsuario = new Usuario{
                Mail = mail,
                Nombre = nombre,
                Apellido = apellido,
                ObraSocial = obraSocial,
                Contraseña = contraseña
            };
            
            db.Usuario.Add(nuevoUsuario);
            db.SaveChanges();
            return View("RegistroResult");

        }

        public IActionResult Salir(){
            HttpContext.Session.Remove("UsuarioLogueado");
            return RedirectToAction("Logueo", "Home") ;
        }


public IActionResult EliminarCuenta(){
            Usuario user = HttpContext.Session.Get<Usuario>("UsuarioLogueado");
            HttpContext.Session.Remove("UsuarioLogueado");
            Usuario usuario = db.Usuario.FirstOrDefault(u => u.Mail == user.Mail);
            db.Usuario.Remove(usuario);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
