using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
            _driver = new FirefoxDriver(@"C:\Users\opilane\source\repos\Selenium\drivers\");
        }

        [Test]
        public void SearchBrowserStack()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://tahvel.edu.ee");
            //hp.Search("Logi sisse");
            //Assert.True(_driver.Title.Contains("Logi sisse"));
        }

        [TearDown]
        public void Cleanup()
        {
            //_driver.Quit();
        }
    }
}
