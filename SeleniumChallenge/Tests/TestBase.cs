using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniumChallenge.Tests
{
    public class TestBase : IDisposable
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;
        protected string Url = "https://www.xcover.com/";

        public TestBase()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
        }

        public void SpecifyBrowser()
        {
            // TODO: Get browser value from environment variable
        }

        public void SpecifyTestRunEnvironment()
        {
            // TODO: Allow tests to be run on local or selenium grid
        }

        public void ImportEnvironmentInfo()
        {
            // TODO: This can use to determine which environment that tests will run against
        }
        
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}