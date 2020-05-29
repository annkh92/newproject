using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using AFS;
using OpenQA.Selenium.Interactions;

namespace AFS
{
    class StartPage
    {
        private IWebDriver driver;

        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement MyName => driver.FindElement(By.Id("Name"));
        private IWebElement Pass => driver.FindElement(By.Id("Password"));
        private IWebElement OkButton => driver.FindElement(By.CssSelector(".btn"));
        private IWebElement title => driver.FindElement(By.CssSelector("h2"));
        public void LogIn(LogPass logpass)
        {
            new Actions(driver).Click(MyName).SendKeys(logpass.myname).Build().Perform();
        }
        public void Password(LogPass logpass)
        {
            new Actions(driver).Click(Pass).SendKeys(logpass.mypass).Build().Perform();
        }
        public void ClickButton() 
        {
            new Actions(driver).Click(OkButton).Build().Perform();
        }
        public string Title()
        {
            return title.Text;
        }
    }
}
