using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction.ScheduledQueries
{
    public class ScheduledQueries : BaseSettings
    {
        public ScheduledQueries(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By scheduledQueriesTab = By.XPath("//*[@id=\"queryScheduledTabId\"]/a");
        private readonly By searchBtn = By.XPath("//*[@id=\"tabScheduledExport\"]/div/div[1]/div[2]/div/div[3]/button[1]");
        private readonly By clearBtn = By.XPath("//*[@id=\"tabScheduledExport\"]/div/div[1]/div[2]/div/div[3]/button[2]");
        private readonly By searchTxt = By.XPath("//*[@id=\"tabScheduledExport\"]/div/div[1]/div[2]/div/div[2]/input");

        private readonly By titleHeader = By.XPath("//*[@id=\"allScheduledQueryTbl\"]/thead/tr/th[1]/small/div");
        private readonly By distributionHeader = By.XPath("//*[@id=\"allScheduledQueryTbl\"]/thead/tr/th[2]/small/div");
        private readonly By nextRunDateHeader = By.XPath("//*[@id=\"allScheduledQueryTbl\"]/thead/tr/th[3]/small/div/span");

        #endregion
        public void ClickLastModifiedOnHeader()
        {

            Driver.FindElement(scheduledQueriesTab).Click();
        }
        public void ClickTitleHeader()
        {

            Driver.FindElement(titleHeader).Click();
        }
        public void ClickDistributionHeader()
        {

            Driver.FindElement(distributionHeader).Click();
        }
        public void ClickNextRunDateHeader()
        {

            Driver.FindElement(nextRunDateHeader).Click();
        }
        public void ClickSearch()
        {

            Driver.FindElement(searchBtn).Click();
        }
        public void ClickClear()
        {

            Driver.FindElement(clearBtn).Click();
        }
        public void EnterSearctValue(string value)
        {

            Driver.FindElement(searchTxt).SendKeys(value);
        }
    }
}
