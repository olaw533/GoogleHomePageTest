using GoogleHomePageTest.Extentions;
using OpenQA.Selenium;

namespace GoogleHomePageTest.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        const string SearchTextTitle = " - Szukaj w Google";

        public By _searchBoxSelector = By.XPath("//*[@id=\"APjFqb\"]");       
        public By _browserLogoSelector = By.CssSelector("[class=\"k1zIA rSk4se\"]");
        public By _textInputToolSelector = By.CssSelector("[aria-label=\"Narzędzia do wprowadzania tekstu\"]");
        public By _voiceSearchSelector = By.CssSelector("[aria-label=\"Wyszukiwanie głosowe\"]");
        public By _googleSearchButtonSelector = By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]");
        public By _luckySearchButtonSelector = By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[2]");
        public By _gmailSelector = By.XPath("//a[text()='Gmail']");
        public By _imageSearchSelector = By.CssSelector("[aria-label=\"Wyszukiwanie obrazów \"]");
        public By _logInSelector = By.XPath("//*[@id=\"gb\"]/div[3]");
        public By _lensSelector = By.CssSelector("[aria-label=\"Wyszukiwanie obrazem\"]");
        public By _searchResultTitleSelector = By.XPath("/html/head/title");
        public By _expandedSearchTab = By.CssSelector("[aria-expanded=\"true\"]");
        public By _expandedAppsTab = By.CssSelector("[class=\"MCcOAc IqBfM e2G3Fb cjGgHb d8Etdd LcUz9d b30Rkd\"]");
        
        public void CheckElementVisibility(By elementSelector)
        {
            WaitDriver.WaitForElement(elementSelector);
        }
        public void ClickSearchBox() 
        {
            WaitDriver.WaitForClick(_searchBoxSelector);
        }

        public void FillSearchBox(string SearchText)
        {
            WaitDriver.WaitForSendKeys(_searchBoxSelector, SearchText);
        }


        public bool IsSearchBoxFilledCorrectly(string SearchText)
        {
            var element = WaitDriver.WaitForElement(_searchBoxSelector);
            var result = element.GetAttribute("value");

            return result.Equals(SearchText);
        }

        public void ClickSearch()
        {
            WaitDriver.WaitForSendKeys(_searchBoxSelector, Keys.Enter);
        }

        public bool IsSearchResultCorrect(string SearchText)
        {          
            var element = WaitDriver.WaitForElement(_searchResultTitleSelector);
            var result = element.GetAttribute("value");

            return result.Equals(SearchText + SearchTextTitle);
        } 
    }
}
