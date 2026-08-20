using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace FC_OnlineReferral
{
    public class BaseSettings
    {

        //protected readonly IWebDriver _driver;
        protected readonly IWebDriver driver;
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);


        //public BaseSettings()
        //{
        //    Driver = new ChromeDriver();

        //}
        public BaseSettings(IWebDriver driver)
        {
            this.driver = driver;
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
