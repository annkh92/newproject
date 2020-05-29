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
            startPage = new StartPage(driver);
            startPage.LogIn(logpass);
            startPage.Password(logpass);
            startPage.ClickButton();
            Assert.AreEqual("Home page", startPage.Title());
        }

        [Test]
        public void TestAdd()
        {
            startPage = new StartPage(driver);
            startPage.LogIn(logpass);
            startPage.Password(logpass);
            startPage.ClickButton();
            productsPage = new ProductsPage(driver);
            productsPage.Add();
            productsPage.ClickButton();
            productsPage.AddProduct(pr);
            productsPage.ClickButton();
            Assert.AreEqual("Kungaloosh", productsPage.Check());
        }
        [Test]
        public void TestOut()
        {
            startPage = new StartPage(driver);
            startPage.LogIn(logpass);
            startPage.Password(logpass);
            startPage.ClickButton();
            logoutPage = new LogoutPage(driver);
            logoutPage.LogOut();
            Assert.AreEqual("Login", logoutPage.Title());
        }
    }
}