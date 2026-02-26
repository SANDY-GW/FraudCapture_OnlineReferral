using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FC_OnlineReferral
{
    public class BaseSettings
    {

        //protected readonly IWebDriver _driver;
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);


        //public BaseSettings()
        //{
        //    Driver = new ChromeDriver();

        //}
        public BaseSettings(IWebDriver driver)
        {
            Driver = driver;
        }

        public void FC_OnlineReferralLogin(string URL= "https://fc-referrals-test.gainwelltechnologies.com/#/DEMO-AD2B")
        {
            //Driver.Navigate().GoToUrl("https://dev.fraudcapture.hms.com");
            
            Driver.Navigate().GoToUrl(URL); 
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
                    return new ChromeDriver(copt);
            }
        }

        public void Login_OnlineReferral()
        {
            BaseSettings baseSettings = new BaseSettings(Driver);
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
        public void NavigateTo(string url) => Driver.Navigate().GoToUrl(url);

        
    }
}
