using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral
{
    public class CommonHelpers
    {
        public CommonHelpers(IWebDriver driver)
        {
            Driver = driver;
        }
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        public static void WaitForPageToLoad(IWebDriver driver, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(webDriver => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void WaitForInstructionsButton(IWebDriver driver, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(.,'Instructions')]")));
        }

        public static void WaitForElementVisiblity(IWebDriver driver, By element, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        }
        public static void ScrollUp(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // Scroll to the top of the page (coordinates 0, 0)
            js.ExecuteScript("window.scrollTo(0, 0);");
        }

        public static void WaitForElementClickable(IWebDriver driver, By element, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static void selectOptionByValue(IWebElement ele, string selectText)
        {
            Thread.Sleep(5000);
            SelectElement selectElement = new SelectElement(ele);

            // Select by Visible Text
            selectElement.SelectByText(selectText);


        }

        public static void selectOptionByIndex(IWebElement ele, int index)
        {
            Thread.Sleep(5000);
            SelectElement selectElement = new SelectElement(ele);

            // Select by Visible Text
            selectElement.SelectByIndex(index);


        }

        /// <summary>
        /// Checks to see if the loading spinner is displayed.
        /// </summary>
        public bool IsLoadingSpinnerDisplayed()
        {
            var loadingOverlay = By.XPath("//span[contains(text(),'Loading...')]");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(loadingOverlay));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
        /// <summary>
        /// Closes the displayed alert.
        /// </summary>
        public void CloseAlert()
        {
            var alert = By.ClassName("close");

            if (IsAlertDisplayed())
            {
                Driver.FindElement(alert).Click();
            }
        }
        /// <summary>
        /// Waits for the page to finish loading.
        /// </summary>
        public void WaitForPageLoading()
        {
            // var loadingOverlay = By.ClassName("spinner-border ");
            var loadingOverlay = By.XPath("//*[contains(@class, 'spinner-border')]");

            if (IsElementDisplayed())
            {
                new WebDriverWait(Driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.InvisibilityOfElementLocated(loadingOverlay));
            }
        }
        private void WaitForAttachmentUpload(int seconds)
        {
            By alertDismissBtn = By.ClassName("close");
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(alertDismissBtn));
            CloseAlert();
        }


        /// <summary>
        /// Checks to see if the alert is displayed.
        /// </summary>
        public bool IsAlertDisplayed()
        {
            var alert = By.ClassName("close");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(alert));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }



        public static void SwitchtoNewWindow(IWebDriver driver)
        {
            driver.SwitchTo().NewWindow(WindowType.Tab);

            Thread.Sleep(2);

        }

        public static void switchWindowByTitle(IWebDriver driver, string windowTitle)
        {
            var originalWindow = driver.CurrentWindowHandle;
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                if (driver.Title.Equals(windowTitle))
                {
                    return;
                }
            }
            driver.SwitchTo().Window(originalWindow); // Switch back if not found
        }

        public bool IsLoadingOverlayDisplayed()
        {
            var loadingOverlay = By.ClassName("inProgressClass");
            //var loadingOverlay = By.XPath(".//span[contains(text(),'Loading...')]");

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(loadingOverlay));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
       

        public bool IsElementDisplayed()
        {
            var loadingOverlay = By.XPath("//*[contains(@class, 'spinner-border')]");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(loadingOverlay));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
        public void FC_OnlineLogin(string URL = "https://test.fraudcapture.hms.com/#/")
        {
            //Driver.Navigate().GoToUrl("https://dev.fraudcapture.hms.com");

            Driver.Navigate().GoToUrl(URL);
        }
        public void WaitForLoadingOverlayToDisappear()
        {
            var loadingOverlay = By.ClassName("inProgressClass");
            //var loadingOverlay = By.XPath(".//span[contains(text(),'Loading...')]");

            if (IsLoadingOverlayDisplayed())
            {
                new WebDriverWait(Driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.InvisibilityOfElementLocated(loadingOverlay));
            }
        }
        public void SwitchWindow()
        {
            WaitForPageLoading();
            String currWindowHandle = Driver.CurrentWindowHandle;

            IList<string> totWindowHandles = new List<string>(Driver.WindowHandles);
            // WaitForPageLoading();
            foreach (String WindowHandle in totWindowHandles)
            {
                if (!WindowHandle.Equals(currWindowHandle))
                {

                    Driver.SwitchTo().Window(WindowHandle);

                }
            }
            WaitForPageLoading();


        }
    }
}
