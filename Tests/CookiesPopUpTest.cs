using GoogleHomePageTest.Pages;
using NUnit.Framework;

namespace GoogleHomePageTest.Tests
{
    public class CookiesPopUpTest : BaseTest
    {       

        [Test(Description = "UI test - Cookies Pop Up")]
        public void CheckUICookiePopUp()
        {
            CookiesPopUp cookiesPopUp = new CookiesPopUp(Driver);

            cookiesPopUp.ChangeLanguageButtonVisibility();
            cookiesPopUp.GoogleLogoVisibility();
            cookiesPopUp.LogInVisibility();
            cookiesPopUp.RejectAllButtonVisibility();
            cookiesPopUp.AcceptAllButtonVisibility();
            cookiesPopUp.MoreOptionsButtonVisibility();
            cookiesPopUp.PrivacyButtonVisibility();
            cookiesPopUp.TermsButtonVisibility();
        }

        [Test(Description = "Browser language change test")]
        public void CheckLanguageChange()
        {
            CookiesPopUp cookiesPopUp = new CookiesPopUp(Driver);

            cookiesPopUp.ChangeBrowserLanguage();
            Assert.That(cookiesPopUp.IsBrowserLanguageChanged());
        }  
    }
}
