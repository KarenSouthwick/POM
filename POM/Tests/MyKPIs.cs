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
using System.Threading;

namespace POM.Tests
{
    [TestFixture]
    public class MyKPIs
    {
        IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://qa-platform.authenticateis.com/Account/Logon");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 974);
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Quit();
        }

        [Test, Order(1)]
        public void MyKPIsTest()
        {            
            LogInPage logIn = new LogInPage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, logIn);
            logIn.LogIn("bakersgaynor", "Aramark22");

            Thread.Sleep(3000);

            HomePage homePage = new HomePage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, homePage);
            homePage.GoToMyKPIs();

            InternalKPIs internalKP = new InternalKPIs(driver);
            internalKP.AddNewKPIs();

        }
    }
}
