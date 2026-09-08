using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.TopTargets.PharmacyScoring
{
    public class PharmacyScoring : BaseSettings
    {
        public PharmacyScoring(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By TopTargets = By.XPath("//a[contains(text(),'Top Targets')]");
        private readonly By PharmacyscoringTab = By.XPath("//button[contains(text(),'Pharmacy Scoring')]");
        

        #endregion
        public void ClickTopTargetsBtn()
        {
            driver.FindElement(TopTargets).Click();
        }
        public void ClickPharmacyScoring()
        {
            driver.FindElement(PharmacyscoringTab).Click();
        }
        
    }
}
