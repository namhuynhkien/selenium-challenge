using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SeleniumChallenge.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            this._driver = driver;
            this._wait = wait;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//a[@href = '/en/get-quote/product']")]
        private IWebElement GetQuoteButton { get; set; }
        
        public GetQuotePage ClickGetQuoteButton()
        {
            GetQuoteButton.Click();
            
            return new GetQuotePage(_driver, _wait);
        }
    }
}