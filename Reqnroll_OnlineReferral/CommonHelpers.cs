using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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
        public static void enterTextValue(IWebElement ele, string selectText)
        {
            ele.Clear();
            ele.SendKeys(selectText);


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
        public static void WaitForPageLoading(IWebDriver Driver)

        {

            // var loadingOverlay = By.ClassName("spinner-border ");

            var loadingOverlay = By.XPath("//*[contains(@class, 'spinner-border')]");

            if (IsElementDisplayed(Driver))

            {

                new WebDriverWait(Driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.InvisibilityOfElementLocated(loadingOverlay));

            }

        }

        public static void ScrollDown(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500)");
        }

        public static void ScrollToElement(IWebDriver driver, By element)
        {
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)driver;
            var webElement = driver.FindElement(element);
            jsExec.ExecuteScript("arguments[0].scrollIntoView(true);", webElement);
            Thread.Sleep(2000);
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
            WaitForPageLoading(driver);
            String currWindowHandle = driver.CurrentWindowHandle;

            IList<string> totWindowHandles = new List<string>(driver.WindowHandles);
            // WaitForPageLoading();
            foreach (String WindowHandle in totWindowHandles)
            {
                if (!WindowHandle.Equals(currWindowHandle))
                {

                    driver.SwitchTo().Window(WindowHandle);

                }
            }
            WaitForPageLoading(driver);

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

        public static bool IsLoadingOverlayDisplayed(IWebDriver driver)
        {
            var loadingOverlay = By.ClassName("inProgressClass");
            //var loadingOverlay = By.XPath(".//span[contains(text(),'Loading...')]");

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

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


        public static bool IsElementDisplayed(IWebDriver driver)
        {
            var loadingOverlay = By.XPath("//*[contains(@class, 'spinner-border')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

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
        public static void WaitForLoadingOverlayToDisappear(IWebDriver driver, int timeout)
        {
            var loadingOverlay = By.ClassName("inProgressClass");
            //var loadingOverlay = By.XPath(".//span[contains(text(),'Loading...')]");

            if (IsLoadingOverlayDisplayed(driver))
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until(ExpectedConditions.InvisibilityOfElementLocated(loadingOverlay));
            }
        }
        public static void ScrollByElementCoordinates(IWebDriver driver, IWebElement element)
        {
            System.Drawing.Point point = element.Location;
            int x_coordinate = point.X - 250;
            int y_coordinate = point.Y - 250;
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)driver;
            jsExec.ExecuteScript("window.scrollBy(" + x_coordinate + ", " + y_coordinate + ");");
        }

        public static string GetElementBackgroundColor(IWebDriver driver, IWebElement ele)
        {

            return (string)((IJavaScriptExecutor)driver)
                .ExecuteScript("return window.getComputedStyle(arguments[0]).backgroundColor;", ele);
        }

    }
}
