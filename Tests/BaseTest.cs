using GoogleHomePageTest.Config;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace GoogleHomePageTest.Tests
{
    public abstract class BaseTest
    {
        protected static IWebDriver Driver { get; set; }
        protected WebDriverWait WaitDriver { get; set; }
        protected string URL = "https://google.com/";

        [SetUp]
        public void Setup()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArgument("−−lang=en");

            Driver = DriverFactory.GetDriver(opt);
            Driver.Navigate().GoToUrl(URL);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WaitDriver = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
            Driver.Quit();
        }
    }
}
