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
    public class Click
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
            driver.FindElement(By.CssSelector(".lock")).Click();
            driver.Quit();
        }

        [Test, Order(1)]
        public void ClickTest()
        {                
            LogInPage logIn = new LogInPage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, logIn);
            logIn.LogIn("blaircottingham", "Aramark22");

            PopUp popup = new PopUp(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, popup);
            popup.ClosePopUp();

            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("My Products")).Click();

            PopUp popup2 = new PopUp(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, popup2);
            popup2.ClosePopUp();

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='do-categoryRootNav']/div/div/ul/li[3]/div/div[2]/p/b")).Click();
            driver.FindElement(By.XPath("//ul[@id='do-productLines']/li/div/div/p/b")).Click();
            driver.FindElement(By.LinkText("Product Data")).Click();

            PopUp popup3 = new PopUp(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, popup3);
            popup3.CloseProdTour();

            HomePage homePage = new HomePage(driver);
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, homePage);
            homePage.LogOff();

        }
    }
}
