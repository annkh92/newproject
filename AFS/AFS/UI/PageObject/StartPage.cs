using OpenQA.Selenium;
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
        private IWebElement Title => driver.FindElement(By.CssSelector("h2"));
        public string Check()
        {
            return Title.Text;
        }
        public StartPage Login(LogPass logpass)
        {
            new Actions(driver).Click(MyName).SendKeys(logpass.myname).Build().Perform();
            new Actions(driver).Click(Pass).SendKeys(logpass.mypass).Build().Perform();
            return new StartPage(driver);
        }
        public StartPage ClickButton()
        {
            new Actions(driver).Click(OkButton).Build().Perform();
            return new StartPage(driver);
        }
        public void SetLoginPassword(IWebElement logpass, string value)
        {
            new Actions(driver).Click().Click(logpass).SendKeys(value).Build().Perform();
        }
        public void SetUserName(string value)
        {
            SetLoginPassword(MyName, value);
        }

        public void SetUserPass(string value)
        {
            SetLoginPassword(Pass, value);
        }
    }
}
