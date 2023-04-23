using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QA_Projects_Test_Magento
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GoToUrlAndGoToWhatNewPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com");
            Thread.Sleep(2000); //Time for loading the website

            driver.FindElement(By.XPath("//a[@id='ui-id-3']")).Click();
            Thread.Sleep(2000); //Time for loading the website.

            driver.FindElement(By.XPath("//span[@class = 'more button']")).Click();
        }
    }
}