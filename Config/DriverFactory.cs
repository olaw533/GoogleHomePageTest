using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleHomePageTest.Config
{
    public static class DriverFactory
    {
        public static IWebDriver GetDriver(ChromeOptions opt) => new ChromeDriver();
    }
}
