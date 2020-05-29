using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AFS.StepDefinition
{
    [Binding]
    class NWSteps
    {
        private IWebDriver driver;
        private ProductsPage productsPage;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenURL(string url)
        {
            driver = new ChromeDriver
            {
                Url = url
            };
        }

        [When(@"I enter ""(.*)"" login")]
        public void WhenIEnterLogin(string myname)
        {
            new StartPage(driver).SetUserName(myname);
        }

        [When(@"I enter ""(.*)"" password")]
        public void WhenIEnterPassword(string mypass)
        {
            new StartPage(driver).SetUserPass(mypass);
        }

        [When(@"I click on login button")]
        public void WhenILogin()
        {
            new StartPage(driver).ClickButton();
        }

        [When(@"I create new product")]
        public void WhenICreateProduct()
        {
            new ProductsPage(driver).Add();
            new ProductsPage(driver).ClickButton();
        }

        [When(@"I type product name ""(.*)""")]
        public void WhenITypeProductName(string productname)
        {
            new ProductsPage(driver).SetProductName(productname);
        }

        [When(@"I set category ""(.*)""")]
        public void WhenISetCategory(string category)
        {
            new ProductsPage(driver).SetCategory(category);
        }

        [When(@"I set supplier ""(.*)""")]
        public void WhenISetSupplier(string supplier)
        {
            new ProductsPage(driver).SetSupplier(supplier);
        }

        [When(@"I type unit price ""(.*)""")]
        public void WhenITypeUnitPrice(string unitprice)
        {
            new ProductsPage(driver).SetPrice(unitprice);
        }

        [When(@"I type quantity per unit ""(.*)""")]
        public void WhenITypeQuantityPerUnit(string perunit)
        {
            new ProductsPage(driver).SetQuantity(perunit);
        }

        [When(@"I type units in stock ""(.*)""")]
        public void WhenITypeUnitsInStock(string instock)
        {
            new ProductsPage(driver).SetStock(instock);
        }

        [When(@"I type units on order ""(.*)""")]
        public void WhenITypeUnitsOnOrder(string onorder)
        {
            new ProductsPage(driver).SetOrder(onorder);
        }

        [When(@"I type reorder level ""(.*)""")]
        public void WhenITypeReorderLevel(string reorderlevel)
        {
            new ProductsPage(driver).SetRL(reorderlevel);
        }

        [When(@"I click on send button")]
        public void WhenIAddProduct()
        {
            new ProductsPage(driver).ClickButton();
        }

        [Then(@"""(.*)"" should be added")]
        public void ProductShouldBeAdded(string newproductname)
        {
            Assert.AreEqual(newproductname, new ProductsPage(driver).Check());
        }
    }
}
