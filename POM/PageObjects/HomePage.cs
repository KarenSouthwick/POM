using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".lock")]
        private IWebElement LogOffButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.LinkText, Using = "My Network")]
        private IWebElement NetworkLink;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.LinkText, Using = "My Site KPI's (0)")]
        private IWebElement MyKPIs;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LogOff()
        {
            LogOffButton.Submit();
        }

        public void GoToNetworkDashboard()
        {
            NetworkLink.Click();
        }

        public void GoToMyKPIs()
        {
            MyKPIs.Click();
        }
    }
}
