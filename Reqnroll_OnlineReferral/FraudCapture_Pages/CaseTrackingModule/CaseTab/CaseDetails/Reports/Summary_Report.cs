using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Reports
{
    public class Summary_Report : BaseSettings
    {
        public Summary_Report(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By reportsDropdown = By.XPath("//*[@id='caseDetailsTab']/div[1]/div/span/button");
        private readonly By SummaryReportButton = By.XPath("//a[contains(text(),'Summary Report')]");

        #endregion
        public void ClickReport()
        {
            driver.FindElement(reportsDropdown).Click();
        }
        public void ClickSummaryReprot()
        {
            driver.FindElement(SummaryReportButton).Click();
        }
    }
}
