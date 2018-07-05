using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POM.PageObjects
{
    class NetworkResults
    {
        private IWebDriver driver;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//div[@id='mainBody']/div[4]/div/div/div[2]/div/table/tbody/tr/td[2]/a")]
        private IWebDriver CompanyResult;

        public NetworkResults(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void VerifyResult(string //div[@id='mainBody']/div[4]/div/div/div[2]/div/table/tbody/tr/td[2]/a))
        {
            CompanyResult.Equals(//div[@id='mainBody']/div[4]/div/div/div[2]/div/table/tbody/tr/td[2]/a));        
        }
    }
}
