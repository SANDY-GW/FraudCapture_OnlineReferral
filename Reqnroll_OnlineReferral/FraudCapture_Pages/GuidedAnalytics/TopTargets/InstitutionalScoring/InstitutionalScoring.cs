using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.TopTargets.InstitutionalScoring
{
    public class InstitutionalScoring : BaseSettings
    {
        public InstitutionalScoring(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By TopTargets = By.XPath("//a[contains(text(),'Top Targets')]");
        private readonly By InstitutionalScoringTab = By.XPath("//button[contains(text(),'Institutional Scoring')]");
       

        #endregion
        public void ClickTopTargetsBtn()
        {
            driver.FindElement(TopTargets).Click();
        }
        public void ClickInstitutionalScoring()
        {
            driver.FindElement(InstitutionalScoringTab).Click();
        }
        
    }
    
}
 