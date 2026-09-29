using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Activities
{
    public class Activities : BaseSettings
    {
        public Activities(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By activityTab = By.XPath("//*[@id=\"activityTabId\"]");
        private readonly By addActivityBtn = By.XPath("//*[@id=\"addActivityId\"]");
        private readonly By activityTableToolsDDL = By.XPath("//*[@id=\"activityTableTools\"]");
        private readonly By searchInputTxt = By.XPath("//*[@id=\"searchInputField\"]");
        private readonly By searchStartBtn = By.XPath("//*[@id=\"searchStartButton\"]");
        private readonly By searchClearBtn = By.XPath("//*[@id=\"searchClearButton\"]");

        #endregion
        public void ClickActivityTab()
        {
            driver.FindElement(activityTab).Click();
        }
        public void EnterSearchInput(string value)
        {
            driver.FindElement(searchInputTxt).SendKeys(value);
        }
        public void SelectActivityTableTools(string tools)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(activityTableToolsDDL), tools);
        }
        public void ClickAddActivityBtn()
        {
            driver.FindElement(addActivityBtn).Click();
        }
        public void ClickSearchBtn()
        {
            driver.FindElement(searchStartBtn).Click();
        }
        public void ClickClearBtn()
        {
            driver.FindElement(searchClearBtn).Click();
        }
    }
}
