using GoogleHomePageTest.Pages;
using NUnit.Framework;

namespace GoogleHomePageTest.Tests
{
    public class TextInputToolTest : BaseTest
    {
        [Test(Description = "UI test - Text Input Tool")]
        public void CheckUIHomePage()
        {
            TextInputTool textInputTool = new TextInputTool(Driver);

            textInputTool.AcceptAllCookies();

            textInputTool.ClickTextToolButton();
            textInputTool.KeyboardDisplayVisibility();
            textInputTool.KeyboardLanguageVisibility();
            textInputTool.NumberOneVisibility();
        }

        [Test(Description = "UI test - Text Input Tool")]
        public void SearchTerm()
        {
            TextInputTool textInputTool = new TextInputTool(Driver);

            textInputTool.AcceptAllCookies();

            textInputTool.ClickTextToolButton();
            textInputTool.KeyboardDisplayVisibility();
            textInputTool.EnterValueByKeyboard();

            Assert.That(textInputTool.isEnterValueCorrect());
        }
    }
}