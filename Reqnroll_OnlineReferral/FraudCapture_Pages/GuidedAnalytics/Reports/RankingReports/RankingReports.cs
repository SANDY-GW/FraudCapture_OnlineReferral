using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.Reports.RankingReports
{
    public class RankingReports: BaseSettings
    {
        public RankingReports(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");
        private readonly By RankingReportsTab = By.XPath("//button[contains(text(),'Ranking Reports')]");
        private readonly By RankingReportsSearch = By.XPath("(//button[@id='searchStartButton'])[1]");
        private readonly By RankingReportsClear = By.XPath("(//button[@id='searchClearButton'])[1]");
        private readonly By RankingReportsSearchTextbox = By.XPath("(//input[@id='searchInputField'])[1]");
        private readonly By ReportTitle= By.XPath("//span[contains(text(),'Report Title')]");
        private readonly By Description = By.XPath("(//span[contains(text(),'Description')])[2] ");
        private readonly By ReportType = By.XPath("//span[contains(text(),'Report Type')] ");


        #endregion
        public void ClickReportsTab()
        {
            driver.FindElement(ReportsTab).Click();
        }
        public void ClickRankingReportsTab()
        {
            driver.FindElement(RankingReportsTab).Click();
        }
        public void EnterRankingReportsSearchTextbox(string searchTextboxValue)
        {
            driver.FindElement(RankingReportsSearchTextbox).SendKeys(searchTextboxValue);
        }
        public void ClickRankingReportsSearch()
        {
            driver.FindElement(RankingReportsSearch).Click();
        }
        public void ClickRankingReportsClear()
        {
            driver.FindElement(RankingReportsClear).Click();
        }
        public void ClickReportTitle()
        {
            driver.FindElement(ReportTitle).Click();
        }
        public void ClickDescription()
        {
            driver.FindElement(Description).Click();
        }
        public void ClickReportType()
        {
            driver.FindElement(ReportType).Click();
        }
        public void ClickLoadButton()
        { 
            CommonHelpers.WaitForElementClickable(driver, By.XPath("//button[contains(text(),'Load')]"), 10);
            driver.FindElement(By.XPath("//button[contains(text(),'Load')]")).Click();
        }
        

    }
}

