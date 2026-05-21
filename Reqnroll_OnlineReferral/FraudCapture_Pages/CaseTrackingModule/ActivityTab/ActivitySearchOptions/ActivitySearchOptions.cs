using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.ActivityTab.ActivitySearchOptions
{
    public class ActivitySearchOptions : BaseSettings
    {

        public ActivitySearchOptions(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements

        //Add xpath here
        private readonly By activitySearchCriteria = By.XPath("//*[@id='activitySearchCriteria']");
        private readonly By searchInputFieldTxt = By.XPath("//*[@id=\"searchInputField\"]");
        private readonly By searchStartBtn = By.XPath("//*[@id=\"searchStartButton\"]");
        private readonly By searchClearBtn = By.XPath("//*[@id=\"searchClearButton\"]");
       
        private readonly By activitySearchMonthsDDL = By.XPath("//*[@id='activitySearchMonths']");
        private readonly By activitySearchDatesDDL = By.XPath("//*[@id='activitySearchDates']");
        private readonly By activitySearchYearsDDL = By.XPath("//*[@id='activitySearchYears']");
        private readonly By activityExportListBtn = By.XPath("//*[@id=\"activityListTable\"]/div[1]/div/div[2]/div/button");
        #endregion
        public void EnterSearchInputField(string value)
        {
            Driver.FindElement(searchInputFieldTxt).SendKeys(value);
        }
        public void ClickSearcBtn()
        {
            Driver.FindElement(searchStartBtn).Click();
        }
        public void ClickActivityExportListBtn()
        {
            Driver.FindElement(activityExportListBtn).Click();
        }
        public void ClickClearBtn()
        {
            Driver.FindElement(searchClearBtn).Click();
        }
       
        public void SelectActivitySearchYears(string years)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(activitySearchYearsDDL), years);
        }
        public void SelectActivitySearchDates(string dates)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(activitySearchDatesDDL), dates);
        }
        public void SelectActivitySearchMonths(string months)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(activitySearchMonthsDDL), months);
        }
       
        public void SelectActivityCriteria(string criteria)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(activitySearchCriteria), criteria);
        }
    }

}

