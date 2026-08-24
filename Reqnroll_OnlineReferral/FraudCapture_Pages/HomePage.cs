using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    public class HomePage : BaseSettings
    {
        public HomePage(IWebDriver driver) : base(driver) { }
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        private readonly By CloseAlertButton = By.XPath("//*[@id='HelpContentViewForm']//button[contains(text(),'Close')]");
        private readonly By MainNavigationBtn = By.XPath("//button[@id='navigationMenuId']");
        private readonly By CaseTrackingOption = By.XPath("//ul[@id='menuDropdownOptions']//a[@id='Case Tracking' or normalize-space()='Case Tracking' or contains(normalize-space(),'Case Tracking')]");
        private readonly By SelectLeadsTab = By.XPath("//a[@id='allLeadsTabId' or normalize-space()='Leads' or contains(normalize-space(),'Leads')]");
        
        public void ClickMainNavigationBtn()
        {
            ClickWithRetry(MainNavigationBtn, 30);
        }
        public void ClickCaseTrackingOption()
        {
            ClickWithRetry(CaseTrackingOption, 30);
        }
        public void ClickSelectLeadsTab()
        {
            ClickWithRetry(SelectLeadsTab, 30);
        }

        private void ClickWithRetry(By locator, int timeoutInSeconds)
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(timeoutInSeconds);

            while (DateTime.UtcNow < timeoutAt)
            {
                try
                {
                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);
                    CommonHelpers.WaitForElementClickable(Driver, locator, 5);

                    var element = Driver.FindElements(locator).FirstOrDefault(e => e.Displayed);
                    if (element == null)
                    {
                        Thread.Sleep(250);
                        continue;
                    }

                    try
                    {
                        element.Click();
                    }
                    catch (ElementClickInterceptedException)
                    {
                        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                    }

                    return;
                }
                catch (NoSuchElementException)
                {
                }
                catch (StaleElementReferenceException)
                {
                }
                catch (WebDriverTimeoutException)
                {
                }

                Thread.Sleep(250);
            }

            throw new WebDriverTimeoutException($"Timed out after {timeoutInSeconds} seconds while clicking element: {locator}");
        }


        public void AcceptDisclosure()
        {
            
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 40);
            By acceptAMAButton = By.XPath("//button[@id='btnAmaEulaAgree']");
            CommonHelpers.WaitForElementClickable(Driver, acceptAMAButton, 100);
            Driver.FindElement(acceptAMAButton).Click();

            // check for Help Content Alerts
            try
            {
                var waitForAlerts = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
                waitForAlerts.Until(d =>
                {
                    try
                    {
                        var waitedAlertButton = d.FindElement(By.XPath("//*[@id='HelpContentViewForm']//button[contains(text(),'Close')]"));
                        return waitedAlertButton.Displayed;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });

                try
                {
                    while (Driver.FindElements(CloseAlertButton).Any())                    
                    {
                       CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 40);
                        //Common.WaitForLoadingOverlayToDisappear();

                        Driver.FindElement(CloseAlertButton).Click();
                        Driver.Close();
                    }
                }
                catch (NoSuchElementException)
                {
                    // no more alerts found, move along
                }
            }
            catch (WebDriverTimeoutException)
            {
                // no Alerts found, move along
            }
        }
    }
}
