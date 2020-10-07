using System;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.PortableExecutable;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumChallenge.Helpers;
using SeleniumChallenge.TestDto;
using SeleniumExtras.PageObjects;

namespace SeleniumChallenge.Pages
{
    public class GetQuotePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public GetQuotePage(IWebDriver driver, WebDriverWait wait)
        {
            this._driver = driver;
            this._wait = wait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit']")]
        private IWebElement NextButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "geosuggest__input")]
        private IWebElement AddressTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//ul[@id = 'geosuggest__list']/li")]
        private IWebElement AddressFirstSuggestedValue { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 'brand']")]
        private IWebElement BranchTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 'model']")]
        private IWebElement ModelTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 'retail_value']")]
        private IWebElement RetailTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@type = 'text']")]
        private IWebElement DatePicker{ get; set; }

        [FindsBy(How = How.CssSelector, Using = ".react-select__control")]
        private IWebElement ConditionDropdown { get; set; }
        
        public GetQuotePage SelectCategory(QuoteCategory category)
        {
            _driver.FindElement(By.XPath("//span[text() = '" + category.GetDescription() + "']")).Click();
            NextButton.Click();
            return this;
        }

        public GetQuotePage FillAddress(string address)
        {
            AddressTextBox.SendKeys(address);
            AddressFirstSuggestedValue.Click();
            NextButton.Click();
            return this;
        }

        public GetQuotePage FillBrand(string brand)
        {
            BranchTextBox.SendKeys(brand);
            NextButton.Click();
            return this;
        }

        public GetQuotePage FillModel(string model)
        {
            ModelTextBox.SendKeys(model);
            NextButton.Click();
            return this;
        }
        
        public GetQuotePage FillRetailValue(int value)
        {
            RetailTextBox.SendKeys(value.ToString());
            NextButton.Click();
            return this;
        }
        
        public GetQuotePage SelectDate(DateTime date)
        {
            // TODO: Need to have function to handle date picker control
            DatePicker.Click();
            DatePicker.FindElement(By.XPath("//td[@aria-label = '" + date.ToString("D") + "']")).Click();
            NextButton.Click();
            return this;
        }

        public QuoteDetailsPage FillCondition(QuoteCondition condition)
        {
           // TODO: Need to have function to handle react-select-control
           ConditionDropdown.Click();
           ConditionDropdown.FindElement(By.XPath($"//div[text() = '" + condition.GetDescription() + "']")).Click();
           NextButton.Click();

           return new QuoteDetailsPage(_driver, _wait);
        }
    }
}