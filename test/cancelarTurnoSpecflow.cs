using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using TechTalk.SpecFlow;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;


namespace test {

[Binding]
public class cancelarTurnoSpecflow {
    IWebDriver  driver = new ChromeDriver();
    IReadOnlyList<IWebElement> turnos;

    [Given(@"un usuario solicita cancelar un turno")]
    public void Given(){

        driver.Navigate().GoToUrl ("https://localhost:5001/Home/Logueo");
        driver.Manage().Window.Maximize();
            
        System.Threading.Thread.Sleep(1000);

        var usernameBox = driver.FindElement(By.Id("user_email"));            
            
        var passwordBox = driver.FindElement(By.Id("user_password"));           
            
        var submitBtn = driver.FindElement(By.Id("loggin-usuario"));
          
        //Perform Required action with the element
        usernameBox.SendKeys("tamara16@live.com.ar");
        System.Threading.Thread.Sleep(1000);
    
        passwordBox.SendKeys("12345");
        System.Threading.Thread.Sleep(1000);
    
        submitBtn.Click();
        System.Threading.Thread.Sleep(1000);
        driver.Navigate().GoToUrl ("https://localhost:5001/Home/VerMisTurnos");

    } 

    [When(@"presiona el boton de cancelar turno")]
    public void When(){
        //Locate the Web Elements
        IReadOnlyList<IWebElement> turnos = driver.FindElements(By.TagName("ul"));
        var cancelar = driver.FindElement(By.Id("btn-9"));
        System.Threading.Thread.Sleep(1000);

        cancelar.Click();
        System.Threading.Thread.Sleep(1000);
        var aceptar = driver.FindElement(By.Id("btn-si"));
        System.Threading.Thread.Sleep(1000);
        aceptar.Click();
    }

    [Then(@"se pierde un turno")]
    public void Then(){
        Assert.IsTrue(12 != driver.FindElements(By.TagName("ul")).Count());
        driver.Close();
    }

    [TestCleanup]
    public void TearDown(){
        driver.Quit();
    }

}
}