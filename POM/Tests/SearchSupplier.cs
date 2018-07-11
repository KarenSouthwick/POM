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
    public class SearchSupplier
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
        public void NetworkSearch()
        {
            LogInPage logIn = new LogInPage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, logIn);
            logIn.LogIn("bakersgaynor", "Aramark22");

            PopUp pop = new PopUp(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, pop);
            pop.ClosePopUp();

            Thread.Sleep(3000);

            HomePage home = new HomePage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, home);
            home.GoToNetworkDashboard();

            NetworkDashboard network = new NetworkDashboard(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, network);
            network.SearchCompany("adelie");

            NetworkResults results = new NetworkResults(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, results);
            results.ClickResult();

            Assert.AreEqual("www.adeliefoods.co.uk", driver.FindElement(By.LinkText("www.adeliefoods.co.uk")).Text);
            
            HomePage homePage = new HomePage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, homePage);
            homePage.LogOff();

        }
    }
}
