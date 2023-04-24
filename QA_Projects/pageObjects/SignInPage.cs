using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QA_Projects_Test_Magento.pageObjects
{
    public class SignInPage
    {
        private IWebDriver driver;
        // driver.FindElement()
        // By.Id("firstname")
        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // Page Object Factory
        [FindsBy(How = How.Id, Using = "firstname")]

        private IWebElement firstname;

        public IWebElement GetUserName()
        {
            return firstname;
        }
    }
}
