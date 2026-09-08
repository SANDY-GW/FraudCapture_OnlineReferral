using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.DataProfile.Overview
{
    public class Overview : BaseSettings
    {
        public Overview(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By DataProfileTab = By.XPath("//a[@id='dataProfileId']");
        private readonly By OverviewTab = By.XPath("//button[@id='dataProfileOverviewButtonId']");



        #endregion
        public void ClickDataProfileTab()
        {
            driver.FindElement(DataProfileTab).Click();
        }
        public void ClickOverviewTab()
        {
            driver.FindElement(OverviewTab).Click();
        }

    }
    
    
}
