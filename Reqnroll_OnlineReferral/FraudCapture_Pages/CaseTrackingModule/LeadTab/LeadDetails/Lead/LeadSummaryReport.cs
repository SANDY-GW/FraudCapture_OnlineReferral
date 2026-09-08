using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class LeadSummaryReport : BaseSettings
    {
        public LeadSummaryReport(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements

        //Add xpath here
        private readonly By reportsDropdown = By.XPath("//*[@id=\"leadcomponent\"]/div[1]/div/span/button");
        private readonly By LedSummaryReportBtn = By.XPath("//a[contains(text(),'Lead Summary Report  ')]");
        
        
        #endregion

        public void ClickReport()
        {
            driver.FindElement(reportsDropdown).Click();
        }

        public void ClickLeadSummaryReport()
        {
            driver.FindElement(LedSummaryReportBtn).Click();
        }

      
    }
}
