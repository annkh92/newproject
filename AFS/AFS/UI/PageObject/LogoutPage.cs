using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using AFS;
using OpenQA.Selenium.Interactions;

namespace AFS
{
    class LogoutPage
    {
        private IWebDriver driver;

        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Leave => driver.FindElement(By.LinkText("Logout"));

        private IWebElement title => driver.FindElement(By.CssSelector("h2"));

        public void LogOut()
        {
            new Actions(driver).Click(Leave).Build().Perform();
        }
        public string Title()
        {
            return title.Text;
        }
    }
}
