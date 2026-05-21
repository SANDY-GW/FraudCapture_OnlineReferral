using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.Reports.PeerGroupingReports
{
    public class PeerGroupingReports : BaseSettings
    {
        public PeerGroupingReports(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");
        private readonly By PeerGroupReportsTab = By.XPath("//button[contains(text(),'Peer Grouping Reports')]");
        private readonly By PeerGroupReportsSearch = By.XPath("(//button[@id='searchStartButton'])[1]");
        private readonly By PeerGroupReportsClear = By.XPath("(//button[@id='searchClearButton'])[1]");
        private readonly By PeerGroupReportsSearchTextbox = By.XPath("(//input[@id='searchInputField'])[1]");
        private readonly By ReportTitle = By.XPath("//span[contains(text(),'Report Title')]");
        private readonly By Description = By.XPath("(//span[contains(text(),'Description')])[2] ");
        private readonly By ReportType = By.XPath("//span[contains(text(),'Report Type')] ");

        #endregion
        public void ClickReportsTab()
        {
            Driver.FindElement(ReportsTab).Click();
        }
        public void ClickPeerGroupReportsTab()
        {
            Driver.FindElement(PeerGroupReportsTab).Click();
        }
        public void EnterPeerGroupReportsSearchTextbox(string searchTextboxValue)
        {
            Driver.FindElement(PeerGroupReportsSearchTextbox).SendKeys(searchTextboxValue);
        }
        public void ClickClaimReportsSearch()
        {
            Driver.FindElement(PeerGroupReportsSearch).Click();
        }
        public void ClickClaimReportsClear()
        {
            Driver.FindElement(PeerGroupReportsClear).Click();
        }
        public void ClickReportTilte()
        {
            Driver.FindElement(ReportTitle).Click();
        }
        public void ClickDescription()
        {
            Driver.FindElement(Description).Click();
        }
        public void ClickReportType()
        {
            Driver.FindElement(ReportType).Click();
        }
        public void ClickLoadButton()
        {
            CommonHelpers.WaitForElementClickable(Driver, By.XPath("//button[contains(text(),'Load')]"), 10);
            Driver.FindElement(By.XPath("//button[contains(text(),'Load')]")).Click();
        }
    }
}
