using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.DataProfile.Institutional
{
    public class Institutional : BaseSettings
    {
        public Institutional(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By DataProfileTab = By.XPath("//a[@id='dataProfileId']");
        private readonly By InstitutioanlTab = By.XPath("//button[@id='dataProfileInstitutionalButtonId']");



        #endregion
        public void ClickDataProfileTab()
        {
            Driver.FindElement(DataProfileTab).Click();
        }
        public void ClickInstitutioanlTab()
        {
            Driver.FindElement(InstitutioanlTab).Click();
        }
    
    }
}
