using GoogleHomePageTest.Extentions;
using OpenQA.Selenium;

namespace GoogleHomePageTest.Pages
{
    public class TextInputTool : BasePage
    {
        public TextInputTool(IWebDriver driver) : base(driver) { }

        const string SearchText = "test";

        public By _searchBoxSelector = By.XPath("//*[@id=\"APjFqb\"]");
        public By _textInputToolSelector = By.CssSelector("[aria-label=\"Narzędzia do wprowadzania tekstu\"]");
        public By _keyboardDisplaySelector = By.XPath("//*[@id=\"kbd\"]"); 
        public By _keyboardLanguageSelector = By.XPath("//*[@id=\"kbd\"]/div[1]/div[1]/span[1]");
        public By _numberOneButtonSelector = By.XPath("//*[@id=\"K49\"]");
        public By _tButtonSelector = By.XPath("//*[@id=\"K84\"]");
        public By _eButtonSelector = By.XPath("//*[@id=\"K69\"]");
        public By _sButtonSelector = By.XPath("//*[@id=\"K83\"]");

        public void ClickTextToolButton()
        {
            WaitDriver.WaitForClick(_textInputToolSelector);
        }

        public void KeyboardDisplayVisibility() 
        { 
            WaitDriver.WaitForElement(_keyboardDisplaySelector);
        }

        public void KeyboardLanguageVisibility()
        {
            WaitDriver.WaitForElement(_keyboardLanguageSelector);
        }

        public void NumberOneVisibility()
        {
            WaitDriver.WaitForElement(_numberOneButtonSelector);
        }

        public void EnterValueByKeyboard() 
        {
            WaitDriver.WaitForClick(_tButtonSelector);
            WaitDriver.WaitForClick(_eButtonSelector);
            WaitDriver.WaitForClick(_sButtonSelector);
            WaitDriver.WaitForClick(_tButtonSelector);
        }
        public bool isEnterValueCorrect()
        {
            var element = WaitDriver.WaitForElement(_searchBoxSelector);
            var result = element.GetAttribute("value");

            return result.Equals(SearchText);
        }
    }
}
