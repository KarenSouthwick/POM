using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM.PageObjects
{
    class PopUp
    {
        private IWebDriver driver;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "do-closePopup")]
        private IWebElement FirstPopUp;

        public PopUp(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClosePopUp()
        {
            FirstPopUp.Click();
        }
    }
}
