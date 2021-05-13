﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Hospital;
using unq_iisoft_2021_c1_hospitalWebSite.Models;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;

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
            Usuario usuarioLogueado = HttpContext.Session.Get<Usuario>("UsuarioLogueado");
            if(usuarioLogueado != null){
                ViewBag.NombreUsuario = usuarioLogueado.Nombre;
            }
            ViewBag.Notas = db.Nota.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    public IActionResult Prestaciones() {

        return View();
    }
   
   public IActionResult Staff() {
            ViewBag.Especialidades = db.Especialidad.OrderBy(e => e.Nombre).ToList();
            ViewBag.Medicos = db.Medico.Include(m => m.Especialidad).Include(m => m.RolEnEspecialidad).ToList();
            return View();
        }
     public IActionResult Historia() {

        return View();
    }
     public IActionResult Autoridades() {

        return View();
    }


     public IActionResult Coberturas() {
             ViewBag.ObrasSociales = db.ObraSocial.Include(o => o.Planes).Where(os => os.Estado == "Activa").OrderBy(o => o.Nombre).ToList();
            return View();
        }

    public IActionResult Contacto() {

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
       
    
        public IActionResult ConsultaEnviada() {

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
            ViewBag.ObrasSociales = db.ObraSocial.ToList();
            return View();
        }
        
       

          public IActionResult LogueoResult(){
            return View();
        }


         private JsonResult AgregarUsuarioASession(Usuario usuarioLogin) {
           HttpContext.Session.Set<Usuario>("UsuarioLogueado", usuarioLogin);
            return Json(usuarioLogin);
        }

    [HttpPost]
    public IActionResult EnviarContacto (string nombre, string mail, string consulta) {


        try {

           MailMessage correo = new MailMessage();
           correo.From = new MailAddress("fundacionfavaloro6@gmail.com");
           correo.To.Add("fundacionfavaloro6@gmail.com");
           correo.Body= consulta;
           correo.CC.Add(mail);
            correo.IsBodyHtml= true;
            correo.Priority= MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.Host= "smtp.gmail.com";
            smtp.Port=25;
            smtp.EnableSsl=true;
            smtp.UseDefaultCredentials=false;
            string scuentaCorreo="fundacionfavaloro6@gmail.com";
            string sPasswordCorreo="Fundacion123";
             smtp.Credentials= new System.Net.NetworkCredential(scuentaCorreo,sPasswordCorreo);
             smtp.Send(correo);
             ViewBag.Mensaje= "Mensaje enviado correctamente";
        }
        catch (Exception ex) {

            ViewBag.Error=ex.Message;
        }

             this.ViewBag.Nombre = nombre;
            this.ViewBag.Mail = mail;
            this.ViewBag.Consulta = consulta;
          return View("ConsultaEnviada");

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

     public IActionResult Registro(){
            ViewBag.ObrasSociales = db.ObraSocial.Where(os => os.Estado == "Activa").OrderBy(os => os.Nombre).ToList();
            return View();
        }
    
            public IActionResult Transaccion(){
            return View();
        }

        public IActionResult EditarUsuario(string mail, string nombre, string apellido, string obraSocial, string contraseña){
            Usuario usuario = db.Usuario.FirstOrDefault(u => u.Mail == mail);
            usuario.ObraSocial = obraSocial;
            usuario.Contraseña = contraseña;

            db.Usuario.Update(usuario);
            db.SaveChanges();
            return View("Transaccion");
        }
    }
}
