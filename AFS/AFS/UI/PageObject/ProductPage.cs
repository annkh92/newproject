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
        private IWebElement ProductCheck => driver.FindElement(By.LinkText("Kungaloosh"));
        
        public void Add()
        {
            new Actions(driver).Click(AllProductsLink).Build().Perform();
        }
        
        public void AddProduct(Product pr)
        {
            new Actions(driver).Click().Click(ProductName).SendKeys(pr.prodname).Build().Perform();
            new Actions(driver).Click().Click(Category).SendKeys(pr.category).Build().Perform();
            new Actions(driver).Click().Click(Supplier).SendKeys(pr.supplier).Build().Perform();
            new Actions(driver).Click().Click(UnitPrice).SendKeys(pr.unitprice).Build().Perform();
            new Actions(driver).Click().Click(QuantityPerUnit).SendKeys(pr.quantity).Build().Perform();
            new Actions(driver).Click().Click(UnitsInStock).SendKeys(pr.instock).Build().Perform();
            new Actions(driver).Click().Click(UnitsOnOrder).SendKeys(pr.onorder).Build().Perform();
            new Actions(driver).Click().Click(ReorderLevel).SendKeys(pr.reorderlevel).Build().Perform();
        }

        public void SetSetProductParameter(IWebElement parameter, string value)
        {
            new Actions(driver).Click().Click(parameter).SendKeys(value).Build().Perform();
        }

        public void SetProductName(string value)
        {
            SetSetProductParameter(ProductName, value);
        }

        public void SetCategory(string value)
        {
            SetSetProductParameter(Category, value);
        }

        public void SetSupplier(string value)
        {
            SetSetProductParameter(Supplier, value);
        }
        public void SetPrice(string value)
        {
            SetSetProductParameter(UnitPrice, value);
        }
        public void SetQuantity(string value)
        {
            SetSetProductParameter(QuantityPerUnit, value);
        }
        public void SetStock(string value)
        {
            SetSetProductParameter(UnitsInStock, value);
        }

        public void SetOrder(string value)
        {
            SetSetProductParameter(UnitsOnOrder, value);
        }
        public void SetRL(string value)
        {
            SetSetProductParameter(ReorderLevel, value);
        }

        public void ClickButton()
        {
            new Actions(driver).Click(OkButton).Build().Perform();
        }

        public string Check()
        {
            return ProductCheck.Text;
        }
    }
}
