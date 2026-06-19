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

        public void AcceptDisclosure()
        {
            //var common = new CommonHelpers(Driver);
            //common.WaitForLoadingOverlayToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 2000);
            //WaitForWidgetLoading();
            //Driver.WrappedDriver.FindElement(By.XPath("//button[@id='btnAmaEulaAgree']")).Click();

            By acceptAMAButton = By.XPath("//button[@id='btnAmaEulaAgree']");
            CommonHelpers.WaitForElementClickable(Driver, acceptAMAButton, 300);
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(180));

            //wait.Until(ExpectedConditions.ElementToBeClickable(acceptAMAButton));
            Driver.FindElement(acceptAMAButton).Click();

            // check for Help Content Alerts
            try
            {
                var waitForAlerts = new WebDriverWait(Driver, TimeSpan.FromSeconds(200));
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
                       CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
                        //Common.WaitForLoadingOverlayToDisappear();

                        Driver.FindElement(CloseAlertButton).Click();
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
