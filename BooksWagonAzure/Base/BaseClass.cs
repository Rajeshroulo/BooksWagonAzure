using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace BooksWagonAzure.Base
{
    public class BaseClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void StartBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications", "start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = ConfigurationManager.AppSettings["URL"];
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
