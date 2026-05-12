using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseAndLeadReporting.CaseTrackingReports
{
    public class CaseTrackingReports : BaseSettings
    {
        public CaseTrackingReports(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By caseAndLeadReportingTab= By.XPath("//*[@id=\"caseLeadReportingTabId\"]");

        private readonly By caseTrackingReportsBtn = By.XPath("//*[@id=\"caseLeadReporting\"]/fc-case-lead-reporting/div/div[1]/button[1]");

        private readonly By searchTableTxt = By.XPath("//*[@id=\"searchInputField\"]");

        private readonly By searchBtn = By.XPath("//*[@id=\"searchStartButton\"]");
        private readonly By clearBtn = By.XPath("//*[@id=\"searchClearButton\"]");
        private readonly By reportTitleField = By.XPath("//*[@id=\"reportListTable\"]/thead/tr/th[1]");
        private readonly By descriptionField = By.XPath("//*[@id=\"reportListTable\"]/thead/tr/th[2]/small/div/span");
        private readonly By reportTypeField = By.XPath("//*[@id=\"reportListTable\"]/thead/tr/th[3]/small/div");
        #endregion
        public void ClickCaseTrackingReprots()
        {

            Driver.FindElement(caseTrackingReportsBtn).Click();
        }
        public void ClickClear()
        {

            Driver.FindElement(clearBtn).Click();
        }
        public void ClickReportTitle()
        {

            Driver.FindElement(reportTitleField).Click();
        }
        public void ClickReportType()
        {

            Driver.FindElement(reportTypeField).Click();
        }
        public void ClickDescription()
        {

            Driver.FindElement(descriptionField).Click();
        }

        public void ClickSearch()
        {

            Driver.FindElement(searchBtn).Click();
        }
        public void EnterSearchValue(string value)
        {

            Driver.FindElement(searchTableTxt).SendKeys(value);
        }
        public void ClickCaseAndLeadReporting()
        {

            Driver.FindElement(caseAndLeadReportingTab).Click();
        }

       
    }
}
