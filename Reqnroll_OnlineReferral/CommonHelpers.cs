using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace FC_OnlineReferral
{
    internal class CommonHelpers
    {
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
    }
}
