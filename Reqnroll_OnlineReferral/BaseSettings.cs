using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace FC_OnlineReferral
{
    /// <summary>
    /// Wraps an <see cref="IWebDriver"/>, exposing it both as itself (via delegation) and via
    /// <see cref="WrappedDriver"/>, so page objects can call `Driver.WrappedDriver.FindElement(...)`,
    /// `(IJavaScriptExecutor)Driver`, and `new Actions(Driver)` uniformly.
    /// </summary>
    public class DriverWrapper : IWebDriver, IWrapsDriver, IJavaScriptExecutor
    {
        private readonly IWebDriver _driver;

        public DriverWrapper(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver WrappedDriver => _driver;

        public string Url { get => _driver.Url; set => _driver.Url = value; }
        public string Title => _driver.Title;
        public string PageSource => _driver.PageSource;
        public string CurrentWindowHandle => _driver.CurrentWindowHandle;
        public System.Collections.ObjectModel.ReadOnlyCollection<string> WindowHandles => _driver.WindowHandles;

        public void Close() => _driver.Close();
        public void Quit() => _driver.Quit();
        public IOptions Manage() => _driver.Manage();
        public INavigation Navigate() => _driver.Navigate();
        public ITargetLocator SwitchTo() => _driver.SwitchTo();
        public IWebElement FindElement(By by) => _driver.FindElement(by);
        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by) => _driver.FindElements(by);
        public void Dispose() => _driver.Dispose();

        public object ExecuteScript(string script, params object[] args)
            => ((IJavaScriptExecutor)_driver).ExecuteScript(script, args);
        public object ExecuteScript(PinnedScript script, params object[] args)
            => ((IJavaScriptExecutor)_driver).ExecuteScript(script, args);
        public object ExecuteAsyncScript(string script, params object[] args)
            => ((IJavaScriptExecutor)_driver).ExecuteAsyncScript(script, args);
    }

    public class BaseSettings
    {

        //protected readonly IWebDriver _driver;
        protected readonly IWebDriver driver;
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        /// <summary>
        /// Exposes the underlying driver wrapped so that `Driver.WrappedDriver`,
        /// `(IJavaScriptExecutor)Driver`, and `new Actions(Driver)` used throughout the
        /// page object classes all work as expected.
        /// </summary>
        protected DriverWrapper Driver => new DriverWrapper(driver);

        //public BaseSettings()
        //{
        //    Driver = new ChromeDriver();

        //}
        public BaseSettings(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>Waits for the page to finish loading (spinner/overlay based).</summary>
        protected void WaitForPageLoading()
        {
            CommonHelpers.WaitForPageLoading(driver);
        }

        /// <summary>Waits for a generic loader/spinner overlay to disappear.</summary>
        protected void WaitForLoaderToDisappear()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        /// <summary>Waits for a generic loader/spinner overlay to disappear (alias used across page objects).</summary>
        protected void WaitForLoadingOverlayToDisappear()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        /// <summary>Waits for a widget/grid loading indicator to disappear.</summary>
        protected void WaitForWidgetLoading()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        /// <summary>Selects an option by visible text in a native HTML select element.</summary>
        protected void SelectDropDownOption(IWebElement element, string value)
        {
            CommonHelpers.selectOptionByValue(element, value);
        }

        /// <summary>Scrolls an element into view and centers it.</summary>
        protected void ScrollAndCenterElement(IWebElement element)
        {
            CommonHelpers.ScrollAndCenterElement(this.driver, element);
        }

        /// <summary>Scrolls to an element's coordinates via JavaScript.</summary>
        protected void ScrollByElementCoordinates(IWebElement element)
        {
            CommonHelpers.ScrollByElementCoordinates(driver, element);
        }

        /// <summary>Waits for search results to load / dismisses search alert notifications.</summary>
        protected void WaitForSearchResultsLoading(int seconds)
        {
            CommonHelpers.WaitForSearchResultsLoading(driver, seconds);
        }

        public void FC_OnlineReferralLogin(string URL= "https://fc-referrals-test.gainwelltechnologies.com/#/DEMO-AD2B")
        {
            //Driver.Navigate().GoToUrl("https://test.fraudcapture.hms.com");
            
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
        }

        public void FC_OnlineLogin(string URL = "https://test.fraudcapture.hms.com/#/")
        {
            //Driver.Navigate().GoToUrl("https://dev.fraudcapture.hms.com");
            try
            {
                driver.Navigate().GoToUrl(URL);
                driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                driver.Navigate().Refresh();

            }

            //Driver.Navigate().Refresh();
            //Driver.Url = URL;
        }
        public static void QuitDriver(IWebDriver driver)
        {
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }
            }
            catch { }
            
        }

        public static IWebDriver Create()
        {
            var browser = Environment.GetEnvironmentVariable("BROWSER") ?? "Chrome";
            //var headless = (Environment.GetEnvironmentVariable("HEADLESS") ?? "true")
            //               .Equals("true", StringComparison.OrdinalIgnoreCase);
            var headless = false;
            switch (browser.ToLowerInvariant())
            {
                case "firefox":
                    var ff = new FirefoxOptions();
                    if (headless) ff.AddArgument("-headless");
                    var ffDriver = new FirefoxDriver(ff);
                    ffDriver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
                    return ffDriver;

                case "edge":
                    var eopt = new EdgeOptions();
                    if (headless) eopt.AddArgument("--headless=new");
                    eopt.AddArgument("--window-size=1920,1080");
                    return new EdgeDriver(eopt);

                default:
                    var copt = new ChromeOptions();
                    if (headless) copt.AddArgument("--headless=new");
                    copt.AddArgument("--window-size=1920,1080");
                    copt.AddArgument("--disable-gpu");
                    copt.AddArgument("--no-sandbox");
                    copt.AddArguments("--start-maximized");
                    copt.PageLoadStrategy = PageLoadStrategy.Normal; 
                    copt.AddUserProfilePreference("profile.default_content_setting_values.local_network_access", 1);
                    return new ChromeDriver(copt);
            }
        }

        public void Login_OnlineReferral()
        {
            BaseSettings baseSettings = new BaseSettings(driver);
            baseSettings.FC_OnlineReferralLogin();
        }


        public static IWebElement WaitUntilElementClickable(IWebDriver driver, By elementLocator, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
        }

        //protected BasePage(IWebDriver driver)
        //{
        //    Driver = driver;
        //    Wait = new WebDriverWait(driver, DefaultTimeout);
        //}

        protected IWebElement Find(By by)
        {
            return Wait.Until(drv =>
            {
                var el = drv.FindElement(by);
                return el.Displayed ? el : null;
            });
        }
        public void NavigateTo(string url) => driver.Navigate().GoToUrl(url);

        
    }
}
