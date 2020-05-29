using AFS.Service.UI;
using AFS.Test;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AFS
{
    public class Tests : Test01
    {
        private StartPage startPage;
        private ProductsPage productsPage;
        private LogoutPage logoutPage;
        private Product pr = new Product("Kungaloosh", "Beverages", "Exotic Liquids", "25,000", "5", "20", "100", "75");
        private LogPass logpass = new LogPass("user", "user");

        [Test]
        public void TestLog()
        {
            startPage = Service.UI.Service.LoginPassword(logpass, driver);
            Assert.AreEqual("Home page", startPage.Check());
        }

        [Test]
        public void TestAdd()
        {
            startPage = Service.UI.Service.LoginPassword(logpass, driver);
            productsPage = Service.UI.Service.AddProduct(pr, driver);
            Assert.AreEqual("Kungaloosh", productsPage.Check());
        }
        [Test]
        public void TestOut()
        {
            startPage = Service.UI.Service.LoginPassword(logpass, driver);
            logoutPage = Service.UI.Service.LogOut(driver);
            Assert.AreEqual("Login", logoutPage.Check());
        }
    }
}