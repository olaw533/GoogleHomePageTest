using GoogleHomePageTest.Pages;
using NUnit.Framework;

namespace GoogleHomePageTest.Tests
{
    public class HomePageTest : BaseTest
    {
        
        [Test(Description = "UI test - Google home page")]
        public void CheckUIHomePage() 
        {
            HomePage homePage = new HomePage(Driver);

            homePage.AcceptAllCookies();

            homePage.TextInputToolVisibility();
            homePage.BrowserLogoVisibility();
            homePage.SearchBoxVisibility();
            homePage.VoiceSearchVisibility();
            homePage.LensVisibility();
            homePage.GoogleSearchButtonVisibility();
            homePage.LuckySearchButtonVisibility();
            homePage.GmailButtonVisibility();
            homePage.ImageSearchButtonVisibility();
            homePage.LogInButtonVisibility();
        }

        [Test(Description = "Google search box test")]
        public void SearchTerm()
        {
            HomePage homePage = new HomePage(Driver);

            homePage.AcceptAllCookies();

            homePage.ClickSearchBox();
            homePage.FillSearchBox();

            Assert.That(homePage.IsSearchBoxFilledCorrectly());
            
            homePage.ExpandedSearchTabVisibility();
            homePage.ClickSearch();

            Assert.That(homePage.IsSearchResultCorrect());
        }
    }
}
