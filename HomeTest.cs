using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Tests
{
    public class HomeTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            _driver = new ChromeDriver();
        }


        [Test]
        public void SearchBrowserStack()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://google.com");
            hp.Search("BrowserStack");
            Assert.True(_driver.Title.Contains("browserstack"));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
