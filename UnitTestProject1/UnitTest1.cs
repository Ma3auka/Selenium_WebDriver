using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using Selenium.WebDriver;
using OpenQA.Selenium;
using Selenium.Helper;
using System.Linq;
using System.Text;
using System.IO;
using Selenium;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void OpenCloce()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        [TestMethod]
        public void FastPromotion_Smok()
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://52.174.154.151:5587");
            driver.FindElement(By.Id("logo-container")).Click();
            //driver.FindElement(By.)
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Url = "http://52.174.154.151:5587";
            IWebElement myDynamicElement5 = driver.FindElement(By.Id("download-button"));




            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        public void Googl1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://googl.com");





            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
