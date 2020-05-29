using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFS.Service.UI
{
    class Service
    {
        public static StartPage LoginPassword(LogPass logpass, IWebDriver driver)
        {
            StartPage startPage = new StartPage(driver);
            StartPage log = startPage.Login(logpass);
            return log.ClickButton();
        }
        public static ProductsPage AddProduct(Product pr, IWebDriver driver)
        {
            ProductsPage productsPage = new ProductsPage(driver);
            ProductsPage addPage = productsPage.AddProduct(pr);
            return addPage.ClickButton();
        }
        public static LogoutPage LogOut(IWebDriver driver)
        {
            LogoutPage logoutPage = new LogoutPage(driver);
            return logoutPage.LogOut();
        }
    }
}
