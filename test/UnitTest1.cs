using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Models.Hospital;
using unq_iisoft_2021_c1_hospitalWebSite.Models;
using  unq_iisoft_2021_c1_hospitalWebSite.Controllers;
using  Models.Hospital;
using unq_iisoft_2021_c1_hospitalWebSite;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
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


namespace test
{
    [TestClass]
    public class UnitTest1
    {
        public HomeController controller ;

        [TestInitialize]
        public void SetUp(){
           var  opciones= new DbContextOptionsBuilder<SanatorioContext>().UseInMemoryDatabase("Hola.db").Options;
            SanatorioContext context = new SanatorioContext(opciones);
            var logger = new Mock<ILogger<HomeController>>().Object;
            controller = new HomeController(logger,context);
            controller.ControllerContext=new ControllerContext();
            controller.ControllerContext.HttpContext= new DefaultHttpContext();
            controller.ControllerContext.HttpContext.Session=new Mock<ISession>().Object ;
        }

        [TestMethod]
        public void LoginYRegisterExitoso()
        {
        var result=controller.RegistrarUsuario("tamara16@live.com.ar", "string nombre", "string apellido", "string obraSocial","12345") as ViewResult; 
        Assert.IsNotNull(result);
        Assert.AreEqual("RegistroResult",result.ViewName);
         var resultl = controller.Login("tamara16@live.com.ar","12345") as ViewResult;
        Assert.AreEqual("LogueoResult",resultl.ViewName);

        }
    }
}
