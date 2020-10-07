using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumChallenge.TestDto;
using SeleniumExtras.PageObjects;
using Shouldly;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumChallenge.Pages
{
    public class QuoteDetailsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public QuoteDetailsPage(IWebDriver driver, WebDriverWait wait)
        {
            this._driver = driver;
            this._wait = wait;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//header[@data-test-id = 'Heading']")]
        private IWebElement HeaderTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Proceed to payment']")]
        private IWebElement ProceedToPaymentButton { get; set; }

        public QuoteDetailsPage VerifyQuoteDetails(QuoteDto quote)
        {
            // TODO: Depends on product requirements, this function should be updated
            ProceedToPaymentButton.Displayed.ShouldBeTrue();
            HeaderTitle.Text.ShouldBe("YOUR QUOTE FOR FULL PRODUCT PROTECTION");
            
            return this;
        }
    }
}