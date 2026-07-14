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
        private readonly By CaseTrackingOption = By.XPath("//ul[@id='menuDropdownOptions']//a[@id='Case Tracking']");
        private readonly By SelectLeadsTab = By.XPath("//a[@id='allLeadsTabId']");
        
        public void ClickMainNavigationBtn()
        {
            //CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(MainNavigationBtn).Click();
        }
        public void ClickCaseTrackingOption()
        {
            //CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(CaseTrackingOption).Click();
        }
        public void ClickSelectLeadsTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(SelectLeadsTab).Click();
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
