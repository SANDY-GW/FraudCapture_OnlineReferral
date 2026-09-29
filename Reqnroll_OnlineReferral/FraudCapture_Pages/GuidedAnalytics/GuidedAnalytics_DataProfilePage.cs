using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics
{
    public class GuidedAnalytics_DataProfilePage : BaseSettings
    {
        public GuidedAnalytics_DataProfilePage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By OverViewBtn = By.XPath("//*[contains(text(),'Overview')]");
        private readonly By ProfessionalBtn = By.XPath("//*[contains(text(),'Professional')]");
        private readonly By InstitutionalBtn = By.XPath("//*[contains(text(),'Institutional')]");
        private readonly By PharmacyBtn = By.XPath("//*[contains(text(),'Pharmacy')]");
        private readonly By DentalBtn = By.XPath("//*[contains(text(),'Dental')]");
        private readonly By PatientBtn = By.XPath("//*[contains(text(),'Patient')]");
        private readonly By NewPatientsBtn = By.XPath("//*[contains(text(),'New Patients')]");
        private readonly By NewProviderBtn = By.XPath("//*[contains(text(),'New Providers')]");

       
        #endregion
        public void ClickOverViewBtn()
        {
            driver.FindElement(OverViewBtn).Click();
        }
        public void ClickProfessionalBtn()
        {
            driver.FindElement(ProfessionalBtn).Click();
        }
        public void ClickInstitutionalBtn()
        {
            driver.FindElement(InstitutionalBtn).Click();
        }
        public void ClickPharmacyBtn()
        {
            driver.FindElement(PharmacyBtn).Click();
        }
        public void ClickDentalBtn()
        {
            driver.FindElement(DentalBtn).Click();
        }
        public void ClickPatientBtn()
        {
            driver.FindElement(PatientBtn).Click();
        }
        public void ClickNewPatientsBtn()
        {
            driver.FindElement(NewPatientsBtn).Click();
        }
        public void ClickNewProviderBtn()
        {
            driver.FindElement(NewProviderBtn).Click();
        }
    }
}
