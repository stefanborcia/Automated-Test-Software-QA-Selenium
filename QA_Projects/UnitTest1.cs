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

            driver.FindElement(By.Id("ui-id-3")).Click();
            Thread.Sleep(2000); //Time for loading the website.

            driver.FindElement(By.XPath("//span[@class = 'more button']")).Click();
        }

        [Test]
        public void FilledInWithTextAndCreateAnAccount()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[contains(text(), 'Create an Account')][1]")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Id("firstname")).SendKeys("Stefan"); 
            driver.FindElement(By.Id("lastname")).SendKeys("Iulian");
            driver.FindElement(By.Id("is_subscribed")).Click();   // Check Button
            driver.FindElement(By.Id("email_address")).SendKeys("stefan121@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Password123*");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("Password123*");
            driver.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
            Thread.Sleep(3000);

            string expectedMessage = "Thank you for registering with Main Website Store.";
            string actualMessage = driver.FindElement(By.XPath("//div[contains(text(), 'Thank you' )]")).Text;

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void SignInAndAddProductToCard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[contains(text(), 'Sign In')]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys("stefan1@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("Password123*");
            driver.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[@id='ui-id-8']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(), 'Fitness Equipment')]")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("product-item-info")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
        }
    }
}