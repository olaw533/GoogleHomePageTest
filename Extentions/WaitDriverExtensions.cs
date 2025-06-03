using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace GoogleHomePageTest.Extentions
{
    public static class WaitDriverExtensions
    {
        public static void WaitForClick(this WebDriverWait waitDriver, By selector)
        {
            var element = waitDriver
                .Until(ExpectedConditions.ElementIsVisible(selector));
            element.Click();
        }

        public static IWebElement WaitForElement(this WebDriverWait waitDriver, By selector)
        {
            var element = waitDriver
                .Until(ExpectedConditions.ElementIsVisible(selector));
            return element;
        }

        public static void WaitForSendKeys(this WebDriverWait waitDriver, By selector, string text)
        {
            var element = waitDriver
                .Until(ExpectedConditions.ElementIsVisible(selector));
            element.SendKeys(text);
        }
    }
}
