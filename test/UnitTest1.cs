using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Moq;  
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Models.Hospital;
using unq_iisoft_2021_c1_hospitalWebSite.Controllers;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        public HomeController controller ;
        public SanatorioContext context;

        [TestInitialize]
        public void SetUp(){
           var  opciones= new DbContextOptionsBuilder<SanatorioContext>().UseInMemoryDatabase("Hola.db").Options;
             context = new SanatorioContext(opciones);
            var logger = new Mock<ILogger<HomeController>>().Object;
            controller = new HomeController(logger,context);
            controller.ControllerContext=new ControllerContext();
            controller.ControllerContext.HttpContext= new DefaultHttpContext();
            var session= new Mock<ISession>();
            controller.ControllerContext.HttpContext.Session=session.Object ;
        }

        [TestMethod]
        public void LoginYRegisterExitoso()
        {
        var result=controller.RegistrarUsuario("tamara16@live.com.ar", "string nombre", "string apellido", "string obraSocial","12345") as ViewResult; 
        Assert.IsNotNull(result);
        Assert.IsNull(controller.ViewBag.MailRegistrado);
        Assert.AreEqual("RegistroResult",result.ViewName);
         var resultl = controller.Login("tamara16@live.com.ar","12345") as ViewResult;
        Assert.AreEqual("LogueoResult",resultl.ViewName);

        }

    [TestMethod]
    public void RegistarUsuarioYaRegistrado(){
        controller.RegistrarUsuario("tamara16@live.com.ar", "string nombre", "string apellido", "string obraSocial","12345");
          var result=controller.RegistrarUsuario("tamara16@live.com.ar", "string nombre", "string apellido", "string obraSocial","12345") as ViewResult; 
        Assert.IsNotNull(result);
        Assert.IsNotNull(controller.ViewBag.MailRegistrado);
        Assert.AreEqual("RegistroResult",result.ViewName);
    }
    [TestMethod]
    public void LoginUserError(){
        var resultl = controller.Login("tamara15@live.com.ar","12345") as ViewResult;
        Assert.IsTrue(controller.ViewBag.ErrorEnLogin);
        Assert.AreEqual("Logueo",resultl.ViewName);

    }

        [TestMethod]
    public void LoginUserErrorIncorrectPassword(){
        var resultl = controller.Login("tamara16@live.com.ar","1234") as ViewResult;
        Assert.IsTrue(controller.ViewBag.ErrorEnLogin);
        Assert.AreEqual("Logueo",resultl.ViewName);

    }

     


    [TestCleanup]
    public void TearDown(){
        context.Database.EnsureDeleted();
        context.Dispose();
    }
    
    }

}
