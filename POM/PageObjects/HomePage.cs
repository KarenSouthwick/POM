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

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LogOff()
        {
            LogOffButton.Submit();
        }
    }
}
