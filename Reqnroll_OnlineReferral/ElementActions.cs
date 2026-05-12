using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FC_OnlineReferral
{
    internal class ElementActions
    {

        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        //private readonly ScenarioContext _scenarioContext;

        public ElementActions(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(new SystemClock(), _driver, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(500));
        }


        public IWebElement WaitForVisible(By locator, int timeoutSeconds = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }


        public void EnterText(By locator, string text, bool clearFirst = true)
        {
            var element = WaitForVisible(locator);
            if (clearFirst)
                element.Clear();
            element.SendKeys(text);
        }

        public string GetText(By locator)
        {
            return WaitForVisible(locator).Text;
        }
    }
}
