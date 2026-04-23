using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction.Available_Exports
{
    public class AvailableExports : BaseSettings
    {
        public AvailableExports(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By availableExportsTab = By.XPath("//*[@id=\"queryExportTabId\"]/a");
        private readonly By searchBtn = By.XPath("//*[@id=\"tabAvailableExport\"]/div/div[1]/div[2]/div/div[3]/button[1]");
        private readonly By clearBtn = By.XPath("//*[@id=\"tabAvailableExport\"]/div/div[1]/div[2]/div/div[3]/button[2]");
        private readonly By searchTxt = By.XPath("//*[@id=\"tabAvailableExport\"]/div/div[1]/div[2]/div/div[2]/input");

        private readonly By statusHeader = By.XPath("//*[@id=\"allScheduledQueryTbl\"]/thead/tr/th[1]/small/div");
        private readonly By sizeHeader = By.XPath("//*[@id=\"allExportsTbl\"]/thead/tr/th[2]/small/div/span");
        private readonly By titleHeader = By.XPath("//*[@id=\"allExportsTbl\"]/thead/tr/th[3]/small/div/span");

        private readonly By categoryHeader = By.XPath("//*[@id=\"allExportsTbl\"]/thead/tr/th[4]/small/div/span");
        private readonly By runDateHeader = By.XPath("//*[@id=\"allExportsTbl\"]/thead/tr/th[5]/small/div/span");
        private readonly By expirationDateHeader = By.XPath("//*[@id=\"allExportsTbl\"]/thead/tr/th[6]/small/div/span");

        private readonly By downloadBtn = By.XPath("//*[@id=\"allExportsTbl0C16C20\"]");

        #endregion
        public void ClickAvailableExports()
        {

            Driver.FindElement(availableExportsTab).Click();
        }
        public void ClickCategoryHeader()
        {

            Driver.FindElement(categoryHeader).Click();
        }
        public void ClickDownload()
        {

            Driver.FindElement(downloadBtn).Click();
        }
        public void ClickExpirationDateHeader()
        {

            Driver.FindElement(expirationDateHeader).Click();
        }

        public void ClickRunDateHeader()
        {

            Driver.FindElement(runDateHeader).Click();
        }
        public void ClickStatusHeader()
        {

            Driver.FindElement(statusHeader).Click();
        }
        public void ClickSizeHeader()
        {

            Driver.FindElement(sizeHeader).Click();
        }
        public void ClickTitleHeader()
        {

            Driver.FindElement(titleHeader).Click();
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
