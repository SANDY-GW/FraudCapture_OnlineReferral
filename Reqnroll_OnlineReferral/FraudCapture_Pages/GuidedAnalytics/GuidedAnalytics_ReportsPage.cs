using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics
{
    public class GuidedAnalytics_ReportsPage : BaseSettings
    {
        public GuidedAnalytics_ReportsPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By RankingReportsBtn= By.XPath("//*[contains(text(),Ranking Reports')]");
        private readonly By CostReportsBtn = By.XPath("//*[contains(text(),'Cost Reports')]");
        private readonly By ClaimReportsBtn = By.XPath("//*[contains(text(),'Claim Reports')]");
        private readonly By PeerGroupingReportsBtn = By.XPath("//*[contains(text(),'Peer Grouping Reports')]");

        private readonly By ReportsSearchTxt = By.XPath("//*[@id='searchInputField']");
        private readonly By ReportsSearchBtn = By.XPath("//*[@id='searchStartButton']");
        private readonly By ReportsSearchClearBtn = By.XPath("//*[@id='searchClearButton']");

        #endregion
        public void ClickRankingReportsBtn()
        {
            Driver.FindElement(RankingReportsBtn).Click();
        }
        public void ClickCostReportsBtn()
        {
            Driver.FindElement(CostReportsBtn).Click();
        }
        public void ClickClaimREportsBtn()
        {
            Driver.FindElement(ClaimReportsBtn).Click();
        }
        public void ClickPeerGroupingReportsBtn()
        {
            Driver.FindElement(PeerGroupingReportsBtn).Click();
        }
        public void EnterReportSearchDetails(string value)
        {
            Driver.FindElement(ReportsSearchTxt).SendKeys(value);
        }
        public void ClickReportSearchBtn()
        {
            Driver.FindElement(ReportsSearchBtn).Click();
        }
        public void ClickReportsSearchClearBtn()
        {
            Driver.FindElement(ReportsSearchClearBtn).Click();
        }
    }
}
