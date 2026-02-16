using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void WaitForElementVisiblity(IWebDriver driver,By element, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        }

        public static void WaitForElementClickable(IWebDriver driver, By element, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static void selectOptionByValue(IWebElement ele,string selectValue)
        {
            SelectElement selectElement = new SelectElement(ele);

            // Select by Visible Text
            selectElement.SelectByText(selectValue);

            
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

        public static string checkElementBackgroundColor(IWebDriver driver,By element)
        {
            var eleColorChk = driver.FindElement(element);
            var colorOfEle = eleColorChk.GetCssValue("border-color");
            if (colorOfEle != null)
            {
                //with highlight-rgb(0, 134, 113)
                //no highlight-rgb(206, 212, 218)
                return colorOfEle;
            }
            else { return null; }

        }
    }
}
