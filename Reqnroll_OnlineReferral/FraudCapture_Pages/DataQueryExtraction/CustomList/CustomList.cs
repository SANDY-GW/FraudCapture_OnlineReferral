using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction.CustomList
{
    public class CustomList : BaseSettings
    {
        public CustomList(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By customListTab = By.XPath("//*[@id=\"queryCustomListTabId\"]/a");
        private readonly By searchBtn = By.XPath("//*[@id=\"customList\"]/div/div[2]/div/div/div[3]/button[1]");
        private readonly By clearBtn = By.XPath("//*[@id=\"customList\"]/div/div[2]/div/div/div[3]/button[2]");
        private readonly By searchTxt = By.XPath("//*[@id=\"customList\"]/div/div[2]/div/div/div[2]/input");

        private readonly By idHeader = By.XPath("//*[@id=\"allCustomListTbl\"]/thead/tr/th[1]/small/div/span");
        private readonly By titleHeader = By.XPath("//*[@id=\"allCustomListTbl\"]/thead/tr/th[2]/small/div/span");

        private readonly By createdOnHeader = By.XPath("private readonly By idHeader = By.XPath(\"//*[@id=\\\"allCustomListTbl\\\"]/thead/tr/th[1]/small/div/span\");\r\n        private readonly By titleHeader = By.XPath(\"//*[@id=\\\"allCustomListTbl\\\"]/thead/tr/th[2]/small/div/span\");\r\n");
        private readonly By createdByHeader = By.XPath("//*[@id=\"allCustomListTbl\"]/thead/tr/th[4]/small/div/span");
        private readonly By accessHeader = By.XPath("//*[@id=\"allCustomListTbl\"]/thead/tr/th[5]/small/div/span");


        private readonly By accessTypeDDL = By.XPath("//*[@id=\"queryTypecustomlist\"]");

        private readonly By createdByDDL = By.XPath("//*[@id=\"userListcl\"]");
        private readonly By reApplyDefaultFitersBtn = By.XPath("//*[@id=\"reapplyCustomDefaultId\"]/b");
        private readonly By applyDynamicFilteringBtn = By.XPath("//*[@id=\"applyCustomDynamicId\"]/b");

        private readonly By addBtn = By.XPath("//*[@id=\"customList\"]/div/div[1]/div[1]/button[1]");

        #endregion
        public void ClickCustomList()
        {

            Driver.FindElement(customListTab).Click();
        }
        public void ClickAccessHeader()
        {

            Driver.FindElement(accessHeader).Click();
        }
        public void ClickCreatedByHeader()
        {

            Driver.FindElement(createdByHeader).Click();
        }
        public void ClickCreatedOnHeader()
        {

            Driver.FindElement(createdOnHeader).Click();
        }
        public void SelectCreatedBy(string createdBy)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(createdByDDL), createdBy);
            
        }
        public void ClickAdd()
        {

            Driver.FindElement(addBtn).Click();
        }
        public void ClickApplyDynamicFiltering()
        {

            Driver.FindElement(applyDynamicFilteringBtn).Click();
        }

        public void ClickReapplyDefaultFiters()
        {

            Driver.FindElement(reApplyDefaultFitersBtn).Click();
        }
        public void ClickIDHeader()
        {

            Driver.FindElement(idHeader).Click();
        }
        public void ClickTitleHeader()
        {

            Driver.FindElement(titleHeader).Click();
        }
        public void SelectAccessType(string accessType)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(accessTypeDDL), accessType);
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
