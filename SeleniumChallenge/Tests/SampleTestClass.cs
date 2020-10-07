using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumChallenge.Pages;
using SeleniumChallenge.TestDto;
using SeleniumExtras.PageObjects;
using Xunit;

namespace SeleniumChallenge.Tests
{
    public class SampleTestClass : TestBase
    {
        public SampleTestClass()
        {
            Driver.Navigate().GoToUrl(Url);
        }
        
        [Fact]
        public void SampleTest()
        {
            var homePage = new HomePage(Driver, Wait);
            var quote = new QuoteDto();
            
            homePage.ClickGetQuoteButton()
                .SelectCategory(quote.Category)
                .FillAddress(quote.Address)
                .FillBrand(quote.Brand)
                .FillModel(quote.Model)
                .FillRetailValue(quote.RetailValue)
                .SelectDate(quote.BuyDate)
                .FillCondition(quote.Condition)
                .VerifyQuoteDetails(quote);
        }
    }
}