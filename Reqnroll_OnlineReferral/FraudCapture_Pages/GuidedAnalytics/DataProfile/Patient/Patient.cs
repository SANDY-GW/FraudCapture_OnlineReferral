using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.DataProfile.Patient
{
    public class Patient : BaseSettings
    {
        public Patient(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By DataProfileTab = By.XPath("//a[@id='dataProfileId']");
        private readonly By PatientTab = By.XPath("//button[@id='dataProfilePatientButtonId']");



        #endregion
        public void ClickDataProfileTab()
        {
            Driver.FindElement(DataProfileTab).Click();
        }
        public void ClickPatientTab()
        {
            Driver.FindElement(PatientTab).Click();
        }
    
    }
}
