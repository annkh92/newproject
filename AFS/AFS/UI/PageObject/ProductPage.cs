using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using AFS;
using OpenQA.Selenium.Interactions;

namespace AFS
{
    class ProductsPage
    {
        private IWebDriver driver;
        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement AllProductsLink => driver.FindElement(By.LinkText("All Products"));
        private IWebElement OkButton => driver.FindElement(By.CssSelector(".btn"));
        private IWebElement ProductName => driver.FindElement(By.Id("ProductName"));
        private IWebElement Category => driver.FindElement(By.Id("CategoryId"));
        private IWebElement Supplier => driver.FindElement(By.Id("SupplierId"));
        private IWebElement UnitPrice => driver.FindElement(By.Id("UnitPrice"));
        private IWebElement QuantityPerUnit => driver.FindElement(By.Id("QuantityPerUnit"));
        private IWebElement UnitsInStock => driver.FindElement(By.Id("UnitsInStock"));
        private IWebElement UnitsOnOrder => driver.FindElement(By.Id("UnitsOnOrder"));
        private IWebElement ReorderLevel => driver.FindElement(By.Id("ReorderLevel"));
        private IWebElement NewProduct => driver.FindElement(By.XPath($"//tr[last()]/td/a"));
        
        public ProductsPage Add()
        {
            new Actions(driver).Click(AllProductsLink).Build().Perform();
            return this;
        }
        public ProductsPage AddProduct(Product pr)
        {
            new Actions(driver).Click(AllProductsLink).Build().Perform();
            new Actions(driver).Click(OkButton).Build().Perform();
            new Actions(driver).Click(ProductName).SendKeys(pr.prodname).Build().Perform();
            new Actions(driver).Click(Category).SendKeys(pr.category).Build().Perform();
            new Actions(driver).Click(Supplier).SendKeys(pr.supplier).Build().Perform();
            new Actions(driver).Click(UnitPrice).SendKeys(pr.unitprice).Build().Perform();
            new Actions(driver).Click(QuantityPerUnit).SendKeys(pr.quantity).Build().Perform();
            new Actions(driver).Click(UnitsInStock).SendKeys(pr.instock).Build().Perform();
            new Actions(driver).Click(UnitsOnOrder).SendKeys(pr.onorder).Build().Perform();
            new Actions(driver).Click(ReorderLevel).SendKeys(pr.reorderlevel).Build().Perform();
            return this;
        }
        public void SetProductParameter(IWebElement parameter, string value)
        {
            new Actions(driver).Click(parameter).SendKeys(value).Build().Perform();
        }

        public void SetProductName(string value)
        {
            SetProductParameter(ProductName, value);
        }

        public void SetCategory(string value)
        {
            SetProductParameter(Category, value);
        }

        public void SetSupplier(string value)
        {
            SetProductParameter(Supplier, value);
        }
        public void SetPrice(string value)
        {
            SetProductParameter(UnitPrice, value);
        }
        public void SetQuantity(string value)
        {
            SetProductParameter(QuantityPerUnit, value);
        }
        public void SetStock(string value)
        {
            SetProductParameter(UnitsInStock, value);
        }

        public void SetOrder(string value)
        {
            SetProductParameter(UnitsOnOrder, value);
        }
        public void SetRL(string value)
        {
            SetProductParameter(ReorderLevel, value);
        }

        public ProductsPage ClickButton()
        {
            new Actions(driver).Click(OkButton).Build().Perform();
            return this;
        }

        public string Check()
        {
            return NewProduct.Text;
        }
    }
}
