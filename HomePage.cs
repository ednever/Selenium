using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        //[FindsBy(How = How.Name, Using = "q")]
        //private IWebElement _searchtxtbox;

        [FindsBy(How = How.Id, Using = "login-button")]

        private IWebElement _searchbtn;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Search(string searchText)
        {
            //_searchtxtbox.SendKeys(searchText);
            _searchbtn.Click();
        }


    }
}