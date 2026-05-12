using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseAndLeadReporting.LeadDashBoard
{
    public  class LeadDashBoard : BaseSettings
    {
        public LeadDashBoard(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By leadDashBoard = By.XPath("//*[@id=\"caseLeadReporting\"]/fc-case-lead-reporting/div/div[1]/button[3]");
        
        #endregion
        
        public void ClickLeadDashBoard()
        {

            Driver.FindElement(leadDashBoard).Click();
        }
    }
}
