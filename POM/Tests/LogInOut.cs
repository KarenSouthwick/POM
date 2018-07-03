using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using POM.PageObjects;
using SeleniumExtras.PageObjects;

namespace POM.Tests
{
    class LogInOut
    {
        [Test]
        public void LogTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://qa-platform.authenticateis.com/Account/Logon");

            LogInPage logIn = new LogInPage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, logIn);
            logIn.LogIn("blaircottingham", "Aramark22");

            HomePage homePage = new HomePage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, homePage);
            homePage.LogOff();

            driver.Quit();
        }
    }
}
