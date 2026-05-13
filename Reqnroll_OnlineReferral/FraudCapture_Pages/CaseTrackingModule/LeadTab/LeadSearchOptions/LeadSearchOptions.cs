using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadSearchOptions
{
    public class LeadSearchOptions : BaseSettings
    {
        public LeadSearchOptions(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By leadSearchCriteriaDDL = By.XPath("//*[@id='leadSearchCriteria']");
        private readonly By searchInputFieldTxt = By.XPath("//*[@id=\"searchInputField\"]");
        private readonly By searchStartBtn = By.XPath("//*[@id=\"searchStartButton\"]");
        private readonly By searchClearBtn = By.XPath("//*[@id=\"searchClearButton\"]");
        private readonly By leadSearchNumericOpertorDDL = By.XPath("//*[@id='leadSearchNumericOperator']");
        private readonly By searchInputFieldNumericTxt = By.XPath("//*[@id='searchInputFieldNumeric']");
        private readonly By leadSearchMonthsDDL = By.XPath("//*[@id='leadSearchMonths']");
        private readonly By leadSearchDatesDDL = By.XPath("//*[@id='leadSearchDates']");
        private readonly By leadSearchYearsDDL = By.XPath("//*[@id='leadSearchYears']");
        private readonly By caseExportListBtn = By.XPath("//*[@id=\"allCases\"]/div[3]/div[1]/div/div[2]/div/button");

        #endregion
        public void EnterSearchInputField(string value)
        {
            Driver.FindElement(searchInputFieldTxt).SendKeys(value);
        }
        public void ClickCaseExpoertListBtn()
        {
            Driver.FindElement(caseExportListBtn).Click();
        }
        public void ClickSearcBtn()
        {
            Driver.FindElement(searchStartBtn).Click();
        }
        public void ClickClearBtn()
        {
            Driver.FindElement(searchClearBtn).Click();
        }
        public void EnterSearchInputFieldNumeric(string numericValue)
        {
            Driver.FindElement(searchInputFieldNumericTxt).SendKeys(numericValue);
        }
        public void SelectLeadSearchYears(string years)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSearchYearsDDL), years);
        }
        public void SelectLeadSearchDates(string dates)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSearchDatesDDL), dates);
        }
        public void SelectLeadSearchMonths(string months)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSearchMonthsDDL), months);
        }
        public void SelectLeadSearchNumericOperator(string numericOperator)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSearchNumericOpertorDDL), numericOperator);
        }
        public void SelectLeadCriteria(string criteria)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSearchCriteriaDDL), criteria);
        }
    }
}
