using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class AuditLog : BaseSettings
    {
        public AuditLog(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By auditLogTab = By.XPath("//*[@id=\"auditlogTabId\"]");
        private readonly By searchTxt = By.XPath("//*[@id=\"searchInputField\"]");
        private readonly By searchBtn = By.XPath("//*[@id=\"searchStartButton\"]");
        private readonly By clearBtn = By.XPath("//*[@id=\"searchClearButton\"]");
        private readonly By downloadCSVExport = By.XPath("//*[@id=\"auditLogTable\"]/div[2]/div/div[4]");

        #endregion
        public void EnterAuditSearch(string value)
        {
            driver.FindElement(searchTxt).SendKeys(value);
        }
        public void ClickCSVExport()
        {
            driver.FindElement(downloadCSVExport).Click();
        }
        public void ClickSearch()
        {
            driver.FindElement(searchBtn).Click();
        }
        public void ClickClear()
        {
            driver.FindElement(clearBtn).Click();
        }
        public void ClickLeadReason()
        {
            driver.FindElement(auditLogTab).Click();
        }
    }
}
