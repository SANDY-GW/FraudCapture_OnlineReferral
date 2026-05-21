using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.TopTargets.ProfessionalScoring
{
    public class ProfessionalScoring : BaseSettings
    {
        public ProfessionalScoring(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By TopTargets = By.XPath("//a[contains(text(),'Top Targets')]");
        private readonly By ProfessScoring = By.XPath("//button[contains(text(),'Professional Scoring')]");
        

        #endregion
        public void ClickTopTargetsBtn()
        {
            Driver.FindElement(TopTargets).Click();
        }

        public void ClickProfessionalScoring()
        {
            Driver.FindElement(ProfessScoring).Click();
        }
       
        
    }
}
