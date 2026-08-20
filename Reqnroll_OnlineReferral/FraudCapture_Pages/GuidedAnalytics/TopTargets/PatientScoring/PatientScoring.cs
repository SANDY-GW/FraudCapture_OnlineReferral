using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.TopTargets.PatientScoring
{
    public class PatientScoring : BaseSettings
    {
        public PatientScoring(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By TopTargets = By.XPath("//a[contains(text(),'Top Targets')]");
        private readonly By PatientScoringTab = By.XPath("//button[contains(text(),'Patient Scoring')]");

        #endregion
        public void ClickTopTargetsBtn()
        {
            driver.FindElement(TopTargets).Click();
        }
        public void ClickPatientScoring()
        {
            driver.FindElement(PatientScoringTab).Click();
        }
    }
    
}
