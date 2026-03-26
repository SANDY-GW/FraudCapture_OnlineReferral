using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics
{
    public class GuidedAnalytics_TopTargetsPage : BaseSettings
    {
        public GuidedAnalytics_TopTargetsPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By ProfessionalScoringBtn = By.XPath("//*[contains(text(),'Professional Scoring')]");
        private readonly By InstitutionalScoring = By.XPath("//*[contains(text(),'Institutional Scoring')]");
        private readonly By PharmacyScoringBtn = By.XPath("//*[contains(text(),'Pharmacy Scoring')]");
        private readonly By PatientScoringBtn = By.XPath("//*[contains(text(),'Patient Scoring')]");
      
        #endregion

        public void ClickProfessionalScoringBtn()
        {
            Driver.FindElement(ProfessionalScoringBtn).Click();
        }
        public void ClickInstitutionalScoringBtn()
        {
            Driver.FindElement(InstitutionalScoring).Click();
        }
        public void ClickPharmacyScoringBtn()
        {
            Driver.FindElement(PharmacyScoringBtn).Click();
        }
        public void ClickPatientScoringBtn()
        {
            Driver.FindElement(PatientScoringBtn).Click();
        }
    }
}
