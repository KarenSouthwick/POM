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
    class LogInPage
    {
        private IWebDriver driver;

        [SeleniumExtras.PageObjects.FindsBy]
        private IWebElement UserName;

        [SeleniumExtras.PageObjects.FindsBy]
        private IWebElement Password;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "do-submit")]
        private IWebElement LoginButton;
        private string testName;

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LogIn(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Submit();
        }
    }
}
