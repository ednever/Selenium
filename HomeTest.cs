using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModel.Tests
{
    public class HomeTests
    {
        private IWebDriver driver;

        [SetUp]
        public void InitScript()
        {
            driver = new FirefoxDriver(@"C:\Users\opilane\source\repos\Selenium\drivers\");
        }

        [Test]
        public void SearchBrowserStack()
        {
            /////////////Переход на вебстрницу
            driver.Navigate().GoToUrl("https://neverovski21.thkit.ee/Aknaruloode_tootmine/index.php");
            Thread.Sleep(1000);

            //////////////Переход на страницу Mustrid
            driver.FindElement(By.XPath("//*[@id='myNavbar']/a[2]")).Click();
            Thread.Sleep(1000);

            //Выбор узора на странице
            IWebElement numberInput = driver.FindElement(By.XPath("/html/body/table/tbody/tr[last()]/td/form/input[1]"));
            numberInput.Clear();
            numberInput.SendKeys("2");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/table/tbody/tr[last()]/td/form/input[2]")).Click();
            Thread.Sleep(1000);

            ////////////Перход на страницу Lõikamine
            driver.FindElement(By.XPath("//*[@id='myNavbar']/a[3]")).Click();
            Thread.Sleep(1000);

            //Выбор действия
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[last()]/td[3]/a[1]")).Click();
            Thread.Sleep(1000);

            //////////Переход на страницу Värvimine
            driver.FindElement(By.XPath("//*[@id='myNavbar']/a[4]")).Click();
            Thread.Sleep(1000);

            //Выбор действия
            driver.FindElement(By.XPath("/html/body/table/tbody/tr[last()]/td[3]/a[2]")).Click(); //a[1]
            Thread.Sleep(1000);

            //////////Переход на страницу Tellimus
            driver.FindElement(By.XPath("//*[@id='myNavbar']/a[5]")).Click();
            Thread.Sleep(1000);

            try
            {
                driver.FindElement(By.XPath("/html/body/table/tbody/tr[last()]/td[5]/a")).Click();
                Thread.Sleep(1000);
                driver.Quit();
            }
            catch (Exception)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("console.log('Товар не готов к выпуску.');");
                throw;
            }


        }

        [TearDown]
        public void Cleanup()
        {
            //driver.Quit();
        }
    }
}