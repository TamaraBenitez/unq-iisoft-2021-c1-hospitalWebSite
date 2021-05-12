using System.Reflection;
using System.IO;
using TechTalk.SpecFlow;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test {

[Binding]
public class TestSpectflow {

    [Given(@"precondicion")]
    public void Given(){
        
    } 

    [When(@"ejecuta algo")]
    public void When(){

    }

    [Then(@"funciona")]
    public void Then(){
        Assert.IsTrue(true);
    }

}
}