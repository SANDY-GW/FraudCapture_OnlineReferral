using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.Reports.CostReports
{
    public class CostReports : BaseSettings
    {
        public CostReports(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");
        private readonly By CostReportsTab = By.XPath("//button[contains(text(),'Cost Reports')]");
        private readonly By CostReportsSearch = By.XPath("(//button[@id='searchStartButton'])[1]");
        private readonly By CostReportsClear = By.XPath("(//button[@id='searchClearButton'])[1]");
        private readonly By CostReportsSearchTextbox = By.XPath("(//input[@id='searchInputField'])[1]");
        private readonly By ReportTitle = By.XPath("//span[contains(text(),'Report Title')]");
        private readonly By Description = By.XPath("(//span[contains(text(),'Description')])[2] ");
        private readonly By ReportType = By.XPath("//span[contains(text(),'Report Type')] ");

        #endregion
        public void ClickReportsTab()
        {
            driver.FindElement(ReportsTab).Click();
        }
        public void ClickCostReportsTab()
        {
            driver.FindElement(CostReportsTab).Click();
        }
        public void EnterCostReportsSearchTextbox(string searchTextboxValue)
        {
            driver.FindElement(CostReportsSearchTextbox).SendKeys(searchTextboxValue);
        }
        public void ClickCostReportsSearch()
        {
            driver.FindElement(CostReportsSearch).Click();
        }
        public void ClickCostReportsClear()
        {
            driver.FindElement(CostReportsClear).Click();
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
