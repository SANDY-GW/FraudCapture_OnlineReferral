using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseSearchOptions
{
    public class CaseSearchOptions : BaseSettings
    {
        public CaseSearchOptions(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By caseSearchCriteriaDDL = By.XPath("//*[@id='caseSearchCriteria']");
        private readonly By searchInputFieldTxt = By.XPath("//*[@id=\"searchInputField\"]");
        private readonly By searchStartBtn = By.XPath("//*[@id=\"searchStartButton\"]");
        private readonly By searchClearBtn = By.XPath("//*[@id=\"searchClearButton\"]");
        private readonly By caseSearchNumericOpertorDDL = By.XPath("//*[@id='caseSearchNumericOperator']");
        private readonly By searchInputFieldNumericTxt = By.XPath("//*[@id='searchInputFieldNumeric']");
        private readonly By caseSearchMonthsDDL = By.XPath("//*[@id='caseSearchMonths']");
        private readonly By caseSearchDatesDDL = By.XPath("//*[@id='caseSearchDates']");
        private readonly By caseSearchYearsDDL = By.XPath("//*[@id='caseSearchYears']");
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
        public void SelectCaseSearchYears(string years)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseSearchYearsDDL), years);
        }
        public void SelectCaseSearchDates(string dates)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseSearchDatesDDL), dates);
        }
        public void SelectCaseSearchMonths(string months)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseSearchMonthsDDL), months);
        }
        public void SelectCaseSearchNumericOperator(string numericOperator)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseSearchNumericOpertorDDL), numericOperator);
        }
        public void SelectCaseCriteria(string criteria)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseSearchCriteriaDDL), criteria);
        }
    }
}
