using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using GoogleHomePageTest.Extentions;

namespace GoogleHomePageTest.Pages
{
    public abstract class BasePage
    {
        private IWebDriver Driver;
        public WebDriverWait WaitDriver { get; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            WaitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public By _acceptAllCookiesButtonSelector = By.XPath("//*[@id=\"L2AGLb\"]/div");
        public void AcceptAllCookies()
        {
            WaitDriver.WaitForClick(_acceptAllCookiesButtonSelector);
        }

        

    }
}
