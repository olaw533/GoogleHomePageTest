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

            homePage.CheckElementVisibility(homePage._searchBoxSelector);
            homePage.CheckElementVisibility(homePage._browserLogoSelector);
            homePage.CheckElementVisibility(homePage._textInputToolSelector);
            homePage.CheckElementVisibility(homePage._voiceSearchSelector);
            homePage.CheckElementVisibility(homePage._googleSearchButtonSelector);
            homePage.CheckElementVisibility(homePage._luckySearchButtonSelector);
            homePage.CheckElementVisibility(homePage._gmailSelector);
            homePage.CheckElementVisibility(homePage._imageSearchSelector);
            homePage.CheckElementVisibility(homePage._logInSelector);
            homePage.CheckElementVisibility(homePage._lensSelector);
            homePage.CheckElementVisibility(homePage._searchResultTitleSelector);
            homePage.CheckElementVisibility(homePage._expandedSearchTab);
            homePage.CheckElementVisibility(homePage._expandedAppsTab);
        }

        [Test(Description = "Google search box test")]
        public void SearchTerm()
        {
            HomePage homePage = new HomePage(Driver);

            const string SearchText = "What is automated tests?";

            homePage.AcceptAllCookies();

            homePage.ClickSearchBox();
            homePage.FillSearchBox(SearchText); ;

            Assert.That(homePage.IsSearchBoxFilledCorrectly(SearchText));

            homePage.CheckElementVisibility(homePage._expandedSearchTab);
            homePage.ClickSearch();

            Assert.That(homePage.IsSearchResultCorrect(SearchText));
        }
    }
}
