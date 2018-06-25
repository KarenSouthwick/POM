using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace POM.PageObjects
{
    class LogInPage
    {
        private IWebDriver driver;

        [FindsBy]
        private IWebElement UserName;

        [FindsBy]
        private IWebElement Password;

        [FindsBy(How = How.Id, Using = "do-submit")]
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
