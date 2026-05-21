using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class LeadPriority : BaseSettings
    {
        public LeadPriority(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By leadReasonBtn = By.XPath("//*[@id='leadReasonTabId']");
       
        #endregion
        public void ClickLeadReason()
        {
            Driver.FindElement(leadReasonBtn).Click();
        }
    }
}
