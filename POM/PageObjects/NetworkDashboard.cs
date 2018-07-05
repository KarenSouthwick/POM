using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace POM.PageObjects
{
    class NetworkDashboard
    {
        private IWebDriver driver;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "companySiteSearchQuery")]
        private IWebElement SearchSupplier;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "(//input[@value='search'])[3]")]
        private IWebElement SearchButton;


        public NetworkDashboard(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SearchCompany(string companySiteSearchQuery)
        {
            SearchSupplier.SendKeys(companySiteSearchQuery);
            SearchButton.Submit();

        }
    }
}
