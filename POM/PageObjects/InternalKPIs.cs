using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM.PageObjects
{
    class InternalKPIs
    {
        private IWebDriver driver;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.LinkText, Using = "add new KPI's")][CacheLookup]
        private IWebElement AddInternalKPI;

        public InternalKPIs(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void AddNewKPIs()
        {
            AddInternalKPI.Click();
        }
        

    }
}
