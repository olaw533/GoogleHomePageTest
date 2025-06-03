using GoogleHomePageTest.Extentions;
using OpenQA.Selenium;

namespace GoogleHomePageTest.Pages
{
    public class CookiesPopUp : BasePage
    {
        public CookiesPopUp(IWebDriver driver) : base(driver) { }

        const string BrowserLanguage = "Language: ‪English‬";

        public By _changeLanguageButtonSelector = By.XPath("//*[@id=\"vc3jof\"]");
        public By _englishLanguageButtonSelector = By.XPath("//*[@id=\"tbTubd\"]/div/li[13]");
        public By _logInButtonSelector = By.XPath("//*[@id=\"gksS1d\"]");
        public By _googleLogoSelector = By.XPath("//*[@id=\"uMousc\"]");
        public By _rejectAllButtonSelector = By.XPath("//*[@id=\"W0wltc\"]");
        public By _moreOptionsButtonSelector = By.XPath("//*[@id=\"VnjCcb\"]");
        public By _privacyButtonSelector = By.XPath("//*[@id=\"RP3V5c\"]");
        public By _termsButtonSelector = By.XPath("//*[@id=\"HQ1lb\"]");

        public void ChangeLanguageButtonVisibility()
        {
            WaitDriver.WaitForElement(_changeLanguageButtonSelector);
        }

        public void GoogleLogoVisibility()
        {
            WaitDriver.WaitForElement(_googleLogoSelector);
        }

        public void LogInVisibility()
        {
            WaitDriver.WaitForElement(_logInButtonSelector);
        }

        public void RejectAllButtonVisibility()
        {
            WaitDriver.WaitForElement(_rejectAllButtonSelector);
        }

        public void AcceptAllButtonVisibility()
        {
            WaitDriver.WaitForElement(_acceptAllCookiesButtonSelector);
        }

        public void MoreOptionsButtonVisibility()
        {
            WaitDriver.WaitForElement(_moreOptionsButtonSelector);
        }

        public void PrivacyButtonVisibility()
        {
            WaitDriver.WaitForElement(_privacyButtonSelector);
        }

        public void TermsButtonVisibility()
        {
            WaitDriver.WaitForElement(_termsButtonSelector);
        }

        public void ChangeBrowserLanguage()
        {
            WaitDriver.WaitForClick(_changeLanguageButtonSelector);
            WaitDriver.WaitForClick(_englishLanguageButtonSelector);
        }

        public bool IsBrowserLanguageChanged()
        {
            var element = WaitDriver.WaitForElement(_changeLanguageButtonSelector);
            var result = element.GetAttribute("aria-label");

            return result.Equals(BrowserLanguage);
        }
    }
}
