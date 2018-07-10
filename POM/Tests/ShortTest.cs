using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System.Threading;
using POM.PageObjects;

namespace POM.Tests
{
    [TestFixture]
    public class ShortTest
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
        public void ShortieTest()
        {
            LogInPage log = new LogInPage(driver);
            log.LogIn("blaircottingham", "Aramark22");
            HomePage home = new HomePage(driver);
            home.GoToNetworkDashboard();
            NetworkDashboard network = new NetworkDashboard(driver);
            network.SearchCompany("adelie");
            NetworkResults results = new NetworkResults(driver);
            results.ClickResult();
        }
    }
}
